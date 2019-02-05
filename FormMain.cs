using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Sudocu {

	public partial class FormMain : Form {

		private const int rank = 9;
		private const int colWidth = 44;
		private const int rowHeight = 44;

		public FormMain ( ) {
			InitializeComponent( );
			formGridTable( );
		}

		private DataGridViewTextBoxColumn createCol ( int width ) {
			DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn( );
			dataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			dataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			dataGridViewTextBoxColumn.Width = width;
			return dataGridViewTextBoxColumn;
		}

		private void formGridTable ( ) {
			int i, j;
			
			for ( i = 0; i < 3; i++ ) {
				for ( j = 0; j < 3; j++ ) {
					gridTable.Columns.Add( createCol( colWidth ) );
				}

				gridNumbers.Columns.Add( createCol( 20 ) );
			}

			gridTable.RowTemplate.Height = rowHeight;
			gridTable.RowCount = rank;
			gridNumbers.RowTemplate.Height = 20;
			gridNumbers.RowCount = 3;
		}

		private void gridTable_Paint ( object sender, PaintEventArgs e ) {
			Pen pen = new Pen( Color.Navy, 10 );
			e.Graphics.DrawRectangle( pen, 0,0, gridTable.Width, gridTable.Height );

			int i, j;
			int prevI, prevJ;
			int rangeHeight = rowHeight * 3;
			int rangeWidth = colWidth * 3;
			pen.Width = 5;

			for ( i = 1; i < 4; i++ ) {
				prevI = i - 1;

				for ( j = 1; j < 4; j++ ) {
					prevJ = j - 1;
					e.Graphics.DrawRectangle( pen, prevJ * rangeWidth, prevI * rangeHeight, j * rangeWidth, i * rangeHeight );
				}
			}
		}

		private void gridTable_CellMouseMove ( object sender, DataGridViewCellMouseEventArgs e ) {
			gridTable[ e.ColumnIndex, e.RowIndex ].Selected = true;
			Cursor.Show( );
			gridTable.Focus( );
		}

		private void showingTableNumbers ( int colIndex, int rowIndex ) {
			int i, j;
			int number = 1;

			for ( i = 0; i < 3; i++ ) {
				for ( j = 0; j < 3; j++ ) {
					gridNumbers[ j, i ].Selected = false;
					gridNumbers[ j, i ].Value = number.ToString( );
					number++;
				}
			}

			int r, c;
			int value;

			for ( i = 0; i < rank; i++ ) {
				if ( gridTable[ colIndex, i ].Value != null ) {
					value = Convert.ToInt16( gridTable[ colIndex, i ].Value.ToString( ) ) - 1;
					r = value / 3;
					c = value % 3;
					gridNumbers[ c, r ].Value = null;
				}

				if ( gridTable[ i, rowIndex ].Value != null ) {
					value = Convert.ToInt16( gridTable[ i, rowIndex ].Value.ToString( ) ) - 1;
					r = value / 3;
					c = value % 3;
					gridNumbers[ c, r ].Value = null;
				}
			}

			r = rowIndex / 3 * 3;
			c = colIndex / 3 * 3;
			int row, col;

			for ( i = 0; i < 3; i++ ) {
				for ( j = 0; j < 3; j++ ) {
					if ( gridTable[ c + j, r + i ].Value != null ) {
						value = Convert.ToInt16( gridTable[ c + j, r + i ].Value.ToString( ) ) - 1;
						row = value / 3;
						col = value % 3;
						gridNumbers[ col, row ].Value = null;
					}
				}
			}

			Rectangle rectangle = gridTable.GetCellDisplayRectangle( colIndex, rowIndex, true );
			rectangle.X += rectangle.Width / 2 - gridNumbers.Width / 2 + gridTable.Left;
			rectangle.Y += rectangle.Height / 2 - gridNumbers.Height / 2 + gridTable.Top;
			gridNumbers.Location = rectangle.Location;
			gridNumbers.Show( );
		}

		private void gridNumbers_Paint ( object sender, PaintEventArgs e ) {
			Pen pen = new Pen( Color.DeepSkyBlue, 2 );
			e.Graphics.DrawRectangle( pen, 1, 1, gridNumbers.Width-2, gridNumbers.Height-2 );
		}

        private void isWin ( ) {
            int sumInRow, sumInCol;
			int i, j;
			int count = 0;
			
			for ( i = 0; i < rank; i++ ) {
				sumInRow = 0;
				sumInCol = 0;

				for ( j = 0; j < rank; j++ ) {
					if ( gridTable[ j, i ].Value != null ) {
						sumInRow += Convert.ToInt16( gridTable[ j, i ].Value.ToString() );
					}

					if ( gridTable[ i, j ].Value != null ) {
						sumInCol += Convert.ToInt16( gridTable[ i, j ].Value.ToString( ) );
					}
				}

				count += sumInRow + sumInCol;
			}

            if ( count == 45 * 9 * 2 ) {
				SoundPlayer sp = new System.Media.SoundPlayer( Properties.Resources.win );
				sp.Play( );
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBoxIcon icons = MessageBoxIcon.Information;
                MessageBox.Show( "Победа!\nВы выиграли!", "Победа!", buttons, icons );
            }
        }

		private void gridNumbers_CellClick ( object sender, DataGridViewCellEventArgs e ) {
            gridTable.CurrentCell.Value = gridNumbers.CurrentCell.Value;
            isWin( );
		}

		private void splitContainer_Panel2_MouseMove ( object sender, MouseEventArgs e ) {
			gridTable[ 4, 4 ].Selected = true;
			gridTable.Focus( );
			showingTableNumbers( 4, 4 );
		}

		private void FormMain_Load ( object sender, EventArgs e ) {
			gridTable.Focus( );
			gridTable[ 4, 4 ].Selected = true;
			showingTableNumbers( 4, 4 );
		}

		private void gridTable_SelectionChanged ( object sender, EventArgs e ) {
			showingTableNumbers( gridTable.CurrentCell.ColumnIndex, gridTable.CurrentCell.RowIndex );
		}

		private void gridTable_KeyDown ( object sender, KeyEventArgs e ) {

			switch ( e.KeyData ) { 
				case Keys.Left :
					if ( gridTable.CurrentCell.ColumnIndex > 0 ) {
						Cursor.Position = new Point( Cursor.Position.X - colWidth, Cursor.Position.Y );
					}
					break;
				case Keys.Right:
					if ( gridTable.CurrentCell.ColumnIndex < gridTable.ColumnCount - 1 ) {
						Cursor.Position = new Point( Cursor.Position.X + colWidth, Cursor.Position.Y );
					}
					break;
				case Keys.Up:
					if ( gridTable.CurrentCell.RowIndex > 0 ) {
						Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y - rowHeight );
					}
					break;
				case Keys.Down:
					if ( gridTable.CurrentCell.RowIndex < gridTable.RowCount - 1 ) {
						Cursor.Position = new Point( Cursor.Position.X, Cursor.Position.Y + rowHeight );
					}
					break;
				default:
					if ( e.KeyData == Keys.Space || e.KeyData == Keys.Back || e.KeyData == Keys.Delete || e.KeyData == Keys.D0 ) {
						gridTable.CurrentCell.Value = null;
					} else {
						if ( e.KeyData.ToString( ).Length > 1 ) {
							string tmpStr = e.KeyData.ToString( ).Substring( 1, 1 );
							int i, j;

							for ( i = 0; i < 3; i++ ) {
								for ( j = 0; j < 3; j++ ) {
									if ( gridNumbers[ j, i ].Value != null ) {
										if ( gridNumbers[ j, i ].Value.ToString( ) == tmpStr ) {
											gridTable.CurrentCell.Value = tmpStr;
											isWin( );
										}
									}
								}
							}
						}
					}

					break;
			}

			gridNumbers.Hide( );
		}

		private void buttonNew_Click ( object sender, EventArgs e ) {
			int i, j;
			
			for ( i = 0; i < rank; i++ ) {
				for ( j = 0; j < rank; j++ ) {
					gridTable[ j, i ].Value = null;
				}
			}
		}

		private void buttonSave_Click ( object sender, EventArgs e ) {
			FileStream file = new FileStream( "save", FileMode.Create );
			StreamWriter writer = new StreamWriter( file );
			int i, j;

			for ( i = 0; i < rank; i++ ) {
				for ( j = 0; j < rank; j++ ) {
					if ( gridTable[ j, i ].Value == null ) {
						writer.Write( " " );
					} else {
						writer.Write( gridTable[ j, i ].Value.ToString() );
					}
				}

				writer.Write( "\n" );
			}

			writer.Close( );
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			MessageBoxIcon icons = MessageBoxIcon.Information;
			MessageBox.Show( "Игра сохранена", "Сохранение", buttons, icons );
		}

		private void buttonLoad_Click ( object sender, EventArgs e ) {
			FileStream file = new FileStream( "save", FileMode.Open );
			StreamReader reader = new StreamReader( file );
			string readText = reader.ReadToEnd( );
			int i, j, k;

			for ( i = k = 0; i < rank; i++ ) {
				for ( j = 0; j < rank; j++ ) {
					if ( readText[ k ] == ' ' ) {
						gridTable[ j, i ].Value = null;
					} else {
						gridTable[ j, i ].Value = readText[ k ];
					}

					k ++;
				}

				k ++;
			}

			gridTable[ 4, 4 ].Selected = true;
			gridTable.Focus( );
			showingTableNumbers( 4, 4 );
			reader.Close( );
			MessageBoxButtons buttons = MessageBoxButtons.OK;
			MessageBoxIcon icons = MessageBoxIcon.Information;
			MessageBox.Show( "Игра загрузена", "Загрузка", buttons, icons );
		}

		private void buttonSolve_Click ( object sender, EventArgs e ) {
			int i, j, k, g;
			int r, c;
			int row, col;
			int ri, cj;
			List<string> [,] listValues = new List<string>[ rank, rank ];
			string tmpStr;
			int countValues = 82;
            bool isFind, isDelete;

			for ( i = 0; i < rank; i++ ) {
				for ( j = 0; j < rank; j++ ) {
					listValues[ j, i ] = new List<string>( );

					if ( gridTable[ j, i ].Value != null ) {
						listValues[ j, i ].Add( gridTable[ j, i ].Value.ToString() );
					} else {
						for ( k = 0; k < rank; k++ ) {
							listValues[ j, i ].Add( ( k + 1 ).ToString() );
						}
					}
				}
			}

			isDelete = true;
			i = j = 0;
			ri = 0; 
			cj = 0;

			int rr, cc;
			rr = 0; cc = 0;

			do {
				
                if ( !isDelete ) {
                    isFind = false;
					
					if ( rr == 8 ) rr = 0;
					if ( cc == 8 ) cc = 0;
					
                    for ( i = rr; i < rank && !isFind; i++ ) {
                        for ( j = cc; j < rank && !isFind; j++ ) {
                            countValues = listValues[ j, i ].Count;

                            if ( gridTable[ j, i ].Value == null && countValues > 1 ) {
                                listValues[ j, i ].RemoveRange( 1, countValues - 1 );
                                gridTable[ j, i ].Value = listValues[ j, i ][ 0 ];
                                isFind = true;
								rr = i;
								cc = j;
                            }
                        }
                    }

                }

				isDelete = false;

				for ( i = 0; i < rank; i++ ) {
					for ( j = 0; j < rank; j++ ) {
						if ( gridTable[ j, i ].Value != null ) {

							tmpStr = gridTable[ j, i ].Value.ToString( );

							for ( k = 0; k < rank; k++ ) {
								if ( listValues[ j, k ].IndexOf( tmpStr ) > -1 && listValues[ j, k ].Count > 1 ) {
									listValues[ j, k ].Remove( tmpStr );
									isDelete = true;
								}

								if ( listValues[ k, i ].IndexOf( tmpStr ) > -1 && listValues[ k, i ].Count > 1 ) {
									listValues[ k, i ].Remove( tmpStr );
									isDelete = true;
								}
							}

							r = i / 3 * 3;
							c = j / 3 * 3;

							for ( k = 0; k < 3; k++ ) {
								for ( g = 0; g < 3; g++ ) {
									row = r + k;
									col = c + g;

									if ( listValues[ col, row ].IndexOf( tmpStr ) > -1 && listValues[ col, row ].Count > 1 ) {
										listValues[ col, row ].Remove( tmpStr );
										isDelete = true;
									}
								}
							}

						} else {
							if ( listValues[ j, i ].Count == 1 ) {

								tmpStr = listValues[ j, i ][ 0 ];

								for ( k = 0; k < rank; k++ ) {
									if ( listValues[ j, k ].IndexOf( tmpStr ) > -1 && listValues[ j, k ].Count > 1 ) {
										listValues[ j, k ].Remove( tmpStr );
										isDelete = true;
									}

									if ( listValues[ k, i ].IndexOf( tmpStr ) > -1 && listValues[ k, i ].Count > 1 ) {
										listValues[ k, i ].Remove( tmpStr );
										isDelete = true;
									}
								}

								ri = i / 3 * 3;
								cj = j / 3 * 3;

								for ( r = 0; r < 3; r++ ) {
									for ( c = 0; c < 3; c++ ) {
										row = ri + r;
										col = cj + c;

										if ( listValues[ col, row ].IndexOf( tmpStr ) > -1 && listValues[ col, row ].Count > 1 ) {
											listValues[ col, row ].Remove( tmpStr );
											isDelete = true;
										}
									}
								}

							}
						}
					}
				}
            
				countValues = 0;

				for ( i = 0; i < rank; i++ ) {
					for ( j = 0; j < rank; j++ ) {
						if ( listValues[ j, i ].Count == 1 ) {
							countValues ++;
						}
					}
				}
				
            } while ( countValues < 81 );

            for ( i = 0; i < rank; i++ ) {
                for ( j = 0; j < rank; j++ ) {
                    gridTable[ j, i ].Value = listValues[ j, i ][ 0 ];
                }
            }

		}

		private void buttonHelp_Click ( object sender, EventArgs e ) {
			System.Diagnostics.Process.Start( "Help.chm" );
		}

		private void buttonCheck_Click ( object sender, EventArgs e ) {
			isWin( );
		}

	}

}
