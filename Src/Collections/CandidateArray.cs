using Sudocu.Src.Extensions;

using static Sudocu.Src.Utils.Helper;

namespace Sudocu.Src.Collections
{
    public class CandidateArray
    {
        public int[,,] Array { get; set; }
        
        public int FlrCount => Array.GetLength( 0 );
        public int RowCount => Array.GetLength( 1 );
        public int ColCount => Array.GetLength( 2 );

        public int this [ int flr, int row, int col ]
        {
            get => Array[ flr, row, col ];
            set => Array[ flr, row, col ] = value;
        }
        
        public CandidateArray ( int [,,] candidats )
        {
            Array = candidats;
        }
        
        public CandidateArray ( CandidateArray candidateArray )
        {
            Array = ( int [,,] ) candidateArray.Array.Clone();
        }
        
        public int GetCondidateFlrsCount ( int row, int col )
        {
            var condidateCounter = 0;

            for ( var k = 0; k < FlrCount; k ++ )
            {
                if ( IsFilledCell( Array[ k, row, col ] ) )
                {
                    condidateCounter ++;
                }
            }

            return condidateCounter;
        }

        public int FirstFlrNumber ( int row, int col )
        {
            /*var singleFlrIndex    = INDEX_NONE;
            var isFoundFilledCell = false;

            for ( var k = 0; k < FlrCount; k ++ )
            {
                if ( IsFilledCell( Array[ k, row, col ] ) )
                {
                    if ( isFoundFilledCell )
                    {
                        return INDEX_NONE;
                    }

                    isFoundFilledCell = true;
                    singleFlrIndex    = k;
                }
            }
            
            return singleFlrIndex;*/

            int number;

            for ( var k = 0; k < FlrCount; k ++ )
            {
                number = Array[ k, row, col ];

                if ( IsFilledCell( number ) )
                {
                    return number;
                }
            }

            return EMPTY_CELL_VALUE;
        }

        public int LastFlrNumber ( int row, int col )
        {
            var lastFlr = FlrCount - 1;
            int number;

            for ( var k = lastFlr; k >= 0; k-- )
            {
                number = Array[ k, row, col ];

                if ( IsFilledCell( number ) )
                {
                    return number;
                }
            }

            return EMPTY_CELL_VALUE;
        }

        public bool CleanRow ( int flr, int row, int col )
        {
            var isClearedCell = false;

            for ( var j = 0; j < ColCount; j ++ )
            {
                if ( j != col && IsFilledCell( Array[ flr, row, j ] ) )
                {
                    isClearedCell = true;
                }

                Array[ flr, row, j ] = EMPTY_CELL_VALUE;
            }

            return isClearedCell;
        }

        public bool CleanCol ( int flr, int col, int row )
        {
            var isClearedCell = false;

            for ( var i = 0; i < RowCount; i ++ )
            {
                if ( i != row && IsFilledCell( Array[ flr, i, col ] ) )
                {
                    isClearedCell = true;
                }

                Array[ flr, i, col ] = EMPTY_CELL_VALUE;
            }

            return isClearedCell;
        }
        
        public bool CleanFlr ( int row, int col, int flr )
        {
            var isClearedCell = false;

            for ( var k = 0; k < FlrCount; k ++ )
            {
                if ( k != flr && IsFilledCell( Array[ k, row, col ] ) )
                {
                    isClearedCell = true;
                }

                Array[ k, row, col ] = EMPTY_CELL_VALUE;
            }

            return isClearedCell;
        }
        
        public bool CleanArea ( int flr, int row, int col, Area area )
        {
            var areaRowIndex = row / area.RowCount;
            var areaColIndex = col / area.ColCount;
            var firsRowIndex = areaRowIndex * area.RowCount;
            var firsColIndex = areaColIndex * area.ColCount;
            var lastRowIndex = ( areaRowIndex + 1 ) * area.RowCount;
            var lastColIndex = ( areaColIndex + 1 ) * area.ColCount;

            var isClearedCell = false;

            int i, j;
            
            for ( i = firsRowIndex; i < lastRowIndex; i ++ )
            {
                for ( j = firsColIndex; j < lastColIndex; j ++ )
                {
                    if ( i != row && j != col && IsFilledCell( Array[ flr, i, j ] ) )
                    {
                        isClearedCell = true;
                    }

                    Array[ flr, i, j ] = EMPTY_CELL_VALUE;
                }
            }

            return isClearedCell;
        }

        public override string ToString ( )
        {
            return Array.ToText( nameof( CandidateArray ) );
        }
    }
}