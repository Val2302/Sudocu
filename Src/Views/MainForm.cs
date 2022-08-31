using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

using Sudocu.Src.Collections;
using Sudocu.Src.Models.Creators;
using Sudocu.Src.Models.Solutions;
using Sudocu.Src.Systems.Windows.Forms;

namespace Sudocu.Src.Views
{
    public partial class MainForm : Form
    {
        #region FIELDS_BEGIN

        private const int GAME_TABLE_RANK   = 9;
        private const int NUMBER_TABLE_RANK = 3;

        private const int COL_WIDTH  = 44;
        private const int ROW_HEIGHT = 44;

        private const int EMPTY_CELL = 0;

        private Area _area;

        #endregion FIELDS_END

        #region CONSTRUCTORS_BEING

        public MainForm ( )
        {
            InitializeComponent( );

            _area = GameConditionCreator.AreaCreator( );
            BuildGameTables( );
        }

        #endregion CONSTRUCTORS_END

        #region METHODS_BEING

        private DataGridViewTextBoxColumn CreateNumberCol ( int width )
        {
            return new DataGridViewTextBoxColumn
            {
                Resizable = DataGridViewTriState.False,
                SortMode  = DataGridViewColumnSortMode.NotSortable,
                Width     = width
            };
        }

        private void BuildGameTables ( )
        {
            int i, j;

            for ( i = 0; i < 3; i++ )
            {
                for ( j = 0; j < 3; j++ )
                {
                    gridTable.Columns.Add( CreateNumberCol( COL_WIDTH ) );
                }

                gridNumbers.Columns.Add( CreateNumberCol( 20 ) );
            }

            gridTable.RowTemplate.Height   = ROW_HEIGHT;
            gridTable.RowCount             = GAME_TABLE_RANK;
            gridNumbers.RowTemplate.Height = 20;
            gridNumbers.RowCount           = 3;
        }

        private void ShowingTableNumbers ( int rowIndex, int colIndex )
        {
            int i, j;
            int number = 1;

            for ( i = 0; i < 3; i++ )
            {
                for ( j = 0; j < 3; j++ )
                {
                    gridNumbers[ j, i ].Selected = false;
                    gridNumbers[ j, i ].Value = number.ToString( );

                    number++;
                }
            }

            int r, c;
            int value;

            for ( i = 0; i < GAME_TABLE_RANK; i++ )
            {
                if ( gridTable[ colIndex, i ].Value != null )
                {
                    value = Convert.ToInt16( gridTable[ colIndex, i ].Value.ToString( ) ) - 1;

                    r = value / 3;
                    c = value % 3;

                    gridNumbers[ c, r ].Value = null;
                }

                if ( gridTable[ i, rowIndex ].Value != null )
                {
                    value = Convert.ToInt16( gridTable[ i, rowIndex ].Value.ToString( ) ) - 1;

                    r = value / 3;
                    c = value % 3;

                    gridNumbers[ c, r ].Value = null;
                }
            }

            r = rowIndex / 3 * 3;
            c = colIndex / 3 * 3;

            int row, col;

            for ( i = 0; i < 3; i++ )
            {
                for ( j = 0; j < 3; j++ )
                {
                    if ( gridTable[ c + j, r + i ].Value != null )
                    {
                        value = Convert.ToInt16( gridTable[ c + j, r + i ].Value.ToString( ) ) - 1;
                        row = value / 3;
                        col = value % 3;
                        gridNumbers[ col, row ].Value = null;
                    }
                }
            }

            var rectangle = gridTable.GetCellDisplayRectangle( colIndex, rowIndex, true );

            rectangle.X += rectangle.Width / 2 - gridNumbers.Width / 2 + gridTable.Left;
            rectangle.Y += rectangle.Height / 2 - gridNumbers.Height / 2 + gridTable.Top;
            
            gridNumbers.Location = rectangle.Location;
            gridNumbers.Show( );
        }

        private void ClearGameTable ( )
        {
            int i, j;

            for ( i = 0; i < GAME_TABLE_RANK; i++ )
            {
                for ( j = 0; j < GAME_TABLE_RANK; j++ )
                {
                    gridTable[ j, i ].Value = null;
                }
            }
        } 

        private void CreateNewGame ( )
        {
            ClearGameTable( );
        }

        private void LoadGame ( )
        {
            var file     = new FileStream( "save", FileMode.Open );
            var reader   = new StreamReader( file );
            var readText = reader.ReadToEnd();

            int i, j, k;

            for ( i = k = 0; i < GAME_TABLE_RANK; i++ )
            {
                for ( j = 0; j < GAME_TABLE_RANK; j++ )
                {
                    if ( readText[ k ] == ' ' )
                    {
                        gridTable[ j, i ].Value = null;
                    }
                    else
                    {
                        gridTable[ j, i ].Value = readText[ k ];
                    }

                    k++;
                }

                k++;
            }

            gridTable[ 4, 4 ].Selected = true;
            gridTable.Focus( );

            ShowingTableNumbers( 4, 4 );
            reader.Close( );

            MessageBoxShower.ShowInformationMessage( "Загружено", "Приятной игры!" );
        }

        private void SaveGame ( ) 
        {
            var file   = new FileStream( "save", FileMode.Create );
            var writer = new StreamWriter( file );

            int i, j;

            for ( i = 0; i < GAME_TABLE_RANK; i++ )
            {
                for ( j = 0; j < GAME_TABLE_RANK; j++ )
                {
                    if ( gridTable[ j, i ].Value == null )
                    {
                        writer.Write( " " );
                    }
                    else
                    {
                        writer.Write( gridTable[ j, i ].Value.ToString( ) );
                    }
                }

                writer.Write( "\n" );
            }

            writer.Close( );

            MessageBoxShower.ShowInformationMessage( "Сохранение", "Игра сохранена" );
        }

        private bool IsWin ( )
        {
            const int ITEM_NUMBER_SUM = 45;

            var rowCount = gridTable.RowCount;
            var colCount = gridTable.ColumnCount;

            var rowSums = new int [ rowCount ];
            var colSums = new int [ colCount ];

            object value;

            int number;
            int i, j;

            for ( i = 0; i < GAME_TABLE_RANK; i++ )
            {
                for ( j = 0; j < GAME_TABLE_RANK; j++ )
                {
                    value = gridTable[ j, i ].Value;
                    number = value is null ? EMPTY_CELL : int.Parse( value.ToString( ) );

                    rowSums[ i ] += number;
                    colSums[ j ] += number;
                }
            }

            var sumRows = rowSums.Sum();
            var sumCols = colSums.Sum();

            return ( sumRows == ITEM_NUMBER_SUM * rowCount ) && ( sumCols == ITEM_NUMBER_SUM * colCount );
        }

        private void CheckGame ( )
        {
            if ( IsWin( ) )
            {
                var soundPlayer = new SoundPlayer( @"Resources/Sounds/win.wav" );
                soundPlayer.Play( );

                MessageBoxShower.ShowInformationMessage( "Победа!", "Вы выиграли!" );
            }
        }

        private ConditionTable BuildGameConditionTable ( )
        {
            var rowCount = gridTable.RowCount;
            var colCount = gridTable.ColumnCount;

            var gameConditionTable = new int [ rowCount, colCount ];
            
            object value;

            int i, j;

            for ( i = 0; i < rowCount; i++ )
            {
                for ( j = 0; j < colCount; j++ )
                {
                    value = gridTable[ j, i ].Value;
                    gameConditionTable[ i, j ] = value is null ? EMPTY_CELL : int.Parse( value.ToString( ) );
                }
            }

            return new ConditionTable( gameConditionTable );
        }

        private void ShowSolution ( SingleSolution singleSolution )
        {
            var rowCount = singleSolution.RowCount;
            var colCount = singleSolution.ColCount;

            var singleSolutionTable = singleSolution.Array;

            int number;
            int i, j;

            for ( i = 0; i < rowCount; i ++ )
            {
                for ( j = 0; j < colCount; j ++ )
                {
                    number = singleSolutionTable[ i, j ];

                    if ( number == EMPTY_CELL )
                    {
                        gridTable[ j, i ].Value = number;
                    }
                }
            }
        }

        private void SolveGame ( )
        {
            var conditionTable = BuildGameConditionTable( );
            var gameCondition  = new GameCondition( conditionTable, _area );

            var solver   = new Solver( gameCondition );
            var solution = solver.Solve();


            switch ( solution.SolutionCount )
            {
                case ESolutionCount.None:
                    MessageBoxShower.ShowInformationMessage( "Случай решений", "Нет решений" );
                    break;
                case ESolutionCount.Single:
                    ShowSolution( solver.Solve( ).SingleVariant );
                    break;
                case ESolutionCount.Multi:
                    MessageBoxShower.ShowInformationMessage( "Случай решений", "Решений безконечно много" );
                    break;
            }
        }

        private void ShowHelp ( )
        {
            System.Diagnostics.Process.Start( "Help.chm" );
        }

        #endregion METHODS_END

        #region EVENT_HANDLERS_BEGIN

        private void MainForm_Load ( object sender, EventArgs e )
        {
            gridTable.Focus( );
            gridTable[ NUMBER_TABLE_RANK + 1, NUMBER_TABLE_RANK + 1 ].Selected = true;
            ShowingTableNumbers( NUMBER_TABLE_RANK + 1, NUMBER_TABLE_RANK + 1 );
        }

        private void GridTable_Paint ( object sender, PaintEventArgs e )
        {
            Pen pen = new Pen(Color.Navy, 10);
            e.Graphics.DrawRectangle( pen, 0, 0, gridTable.Width, gridTable.Height );

            int i, j;
            int prevI, prevJ;
            int rangeHeight = ROW_HEIGHT * 3;
            int rangeWidth = COL_WIDTH * 3;

            pen.Width = 5;

            for ( i = 1; i < 4; i++ )
            {
                prevI = i - 1;

                for ( j = 1; j < 4; j++ )
                {
                    prevJ = j - 1;
                    e.Graphics.DrawRectangle( pen, prevJ * rangeWidth, prevI * rangeHeight, j * rangeWidth, i * rangeHeight );
                }
            }
        }

        private void GridTable_CellMouseMove ( object sender, DataGridViewCellMouseEventArgs e )
        {
            gridTable[ e.ColumnIndex, e.RowIndex ].Selected = true;
            Cursor.Show( );
            gridTable.Focus( );
        }

        private void GridNumbers_Paint ( object sender, PaintEventArgs e )
        {
            Pen pen = new Pen( Color.DeepSkyBlue, 2 );
            e.Graphics.DrawRectangle( pen, 1, 1, gridNumbers.Width - 2, gridNumbers.Height - 2 );
        }

        private void GridNumbers_CellClick ( object sender, DataGridViewCellEventArgs e )
        {
            gridTable.CurrentCell.Value = gridNumbers.CurrentCell.Value;
            gridNumbers.Hide( );
            CheckGame( );
        }

        private void MainForm_KeyDown ( object sender, KeyEventArgs e )
        {
            if ( e.Control )
            {
                switch ( e.KeyCode )
                {
                    case Keys.N:
                        CreateNewGame( );
                        break;
                    case Keys.L:
                        LoadGame( );
                        break;
                    case Keys.S:
                        SaveGame( );
                        break;
                    case Keys.C:
                        CheckGame( );
                        break;
                    case Keys.R:
                        SolveGame( );
                        break;
                }
            }

            if ( e.KeyCode == Keys.F1 )
            {
                ShowHelp( );
            }

            GridTable_KeyDown( sender, e );
        }

        private void SplitContainer_Panel2_MouseMove ( object sender, MouseEventArgs e )
        {
            gridTable[ 4, 4 ].Selected = true;
            gridTable.Focus( );
            ShowingTableNumbers( 4, 4 );
        }

        private void GridTable_SelectionChanged ( object sender, EventArgs e )
        {
            ShowingTableNumbers( gridTable.CurrentCell.RowIndex, gridTable.CurrentCell.ColumnIndex );
        }

        private void GridTable_KeyDown ( object sender, KeyEventArgs e )
        {
            if ( e.KeyData == Keys.Space || e.KeyData == Keys.Back || e.KeyData == Keys.Delete || e.KeyData == Keys.D0 )
            {
                gridTable.CurrentCell.Value = null;
            }

            switch ( e.KeyData )
            {
                case Keys.Left:
                    if ( gridTable.CurrentCell.ColumnIndex > 0 )
                    {
                        Cursor.Position = new Point( Cursor.Position.X - COL_WIDTH / 2, Cursor.Position.Y );
                    }
                    break;
                case Keys.Right:
                    if ( gridTable.CurrentCell.ColumnIndex < gridTable.ColumnCount - 1 )
                    {
                        Cursor.Position = new Point( Cursor.Position.X + COL_WIDTH / 2, Cursor.Position.Y );
                    }
                    break;
                case Keys.Up:
                    if ( gridTable.CurrentCell.RowIndex > 0 )
                    {
                        Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y - ROW_HEIGHT / 2 );
                    }
                    break;
                case Keys.Down:
                    if ( gridTable.CurrentCell.RowIndex < gridTable.RowCount - 1 )
                    {
                        Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y + ROW_HEIGHT / 2 );
                    }
                    break;
                default:
                    if ( e.KeyData.ToString( ).Length > 1 )
                    {
                        var tmpStr = e.KeyData.ToString().Substring( 1, 1 );
                        int i, j;

                        for ( i = 0; i < 3; i++ )
                        {
                            for ( j = 0; j < 3; j++ )
                            {
                                if ( gridNumbers[ j, i ].Value != null )
                                {
                                    if ( gridNumbers[ j, i ].Value.ToString( ) == tmpStr )
                                    {
                                        gridTable.CurrentCell.Value = tmpStr;
                                        CheckGame( );
                                    }
                                }
                            }
                        }
                    }
                    break;
            }

            gridNumbers.Hide( );
        }

        private void BtnNewGame_Click ( object sender, EventArgs e )
        {
            CreateNewGame( );
        }

        private void BtnLoadGame_Click ( object sender, EventArgs e )
        {
            LoadGame( );
        }

        private void BtnSaveGame_Click ( object sender, EventArgs e )
        {
            SaveGame( );
        }

        private void BtnCheckGame_Click ( object sender, EventArgs e )
        {
            CheckGame( );
        }

        private void BtnSolveGame_Click ( object sender, EventArgs e )
        {
            SolveGame( );
        }

        private void BtnShowHelp_Click ( object sender, EventArgs e )
        {
            ShowHelp( );
        }

        #endregion EVENT_HANDLERS
    }

}
