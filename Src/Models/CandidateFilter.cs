using Sudocu.Src.Cells;
using Sudocu.Src.Collections;
using Sudocu.Src.Utils;

using static Sudocu.Src.Utils.Helper;
using static System.Console;

namespace Sudocu.Src.Models
{
    public class CandidateFilter
    {
        private ConditionTable _conditionTable;

        private int _rowCount;
        private int _colCount;
        private int _flrCount;

        private Area _area;

        public CandidateArray CandidateArray { get; set; }

        public CandidateFilter ( GameCondition gameCondition, CandidateArray candidateArray )
        {
            CandidateArray = candidateArray;
            _conditionTable = gameCondition.ConditionTable;

            _rowCount = CandidateArray.RowCount;
            _colCount = CandidateArray.ColCount;
            _flrCount = CandidateArray.FlrCount;

            _area = gameCondition.Area;
        }

        private bool Filter ( Cell3D<int> cell3D )
        {
            var isFilteredCandidats = false;

            var flr  = cell3D.Flr;
            var row  = cell3D.Row;
            var col  = cell3D.Col;
            var data = cell3D.Data;

            isFilteredCandidats |= CandidateArray.CleanRow ( flr, row, col );
            isFilteredCandidats |= CandidateArray.CleanCol ( flr, col, row );
            isFilteredCandidats |= CandidateArray.CleanFlr ( row, col, flr );
            isFilteredCandidats |= CandidateArray.CleanArea( flr, row, col, _area );

            CandidateArray[ flr, row, col ] = data;

            return isFilteredCandidats;
        }

        public bool FilterByCondition ( )
        {
            var isFilteredCandidats = false;

            Cell3D<int> cell3D = null;

            int number;
            int i, j, flr;
            
            for ( i = 0; i < _conditionTable.RowCount; i ++ )
            {
                for ( j = 0; j < _conditionTable.ColCount; j ++ )
                {
                    number = _conditionTable[ i, j ];
                    flr    = Converter.ConvertNumberToIndex( number );

                    if ( IsExistIndex( flr ) )
                    {
                        cell3D = new Cell3D<int> ( flr, i, j, number );
                        isFilteredCandidats |= Filter( cell3D );
                    }
                }
            }
            
            return isFilteredCandidats;
        }
        
        public bool FilterSigleCandidats ( )
        {
            var isFilteredCandidats = false;

            Cell3D<int> cell3D = null;

            int number;
            int i, j, flr;
            
            for ( i = 0; i < CandidateArray.RowCount; i ++ )
            {
                for ( j = 0; j < CandidateArray.ColCount; j ++ )
                {
                    if ( CandidateArray.GetCondidateFlrsCount( i, j ) > ONE_CANDIDATE )
                    {
                        continue;
                    }

                    number = CandidateArray.FirstFlrNumber( i, j );
                    flr    = Converter.ConvertNumberToIndex( number );

                    if ( IsExistIndex( flr ) )
                    {
                        cell3D = new Cell3D<int>( flr, i, j, number );
                        isFilteredCandidats |= Filter( cell3D );
                    }
                }
            }

            return isFilteredCandidats;
        }

        public bool FilterMultiCandidats ( )
        {
            var isFilteredCandidats = false;

            int number;
            int i, j, flr;
            
            for ( i = 0; i < CandidateArray.RowCount; i ++ )
            {
                for ( j = 0; j < CandidateArray.ColCount; j ++ )
                {
                    if ( CandidateArray.GetCondidateFlrsCount( i, j ) <= ONE_CANDIDATE )
                    {
                        continue;
                    }

                    number = CandidateArray.FirstFlrNumber( i, j );
                    flr    = Converter.ConvertNumberToIndex( number );

                    if ( IsExistIndex( flr ) )
                    {
                        isFilteredCandidats |= CandidateArray.CleanFlr( i, j, flr );
                        isFilteredCandidats |= CandidateArray.CleanArea( flr, i, j, _area );

                        CandidateArray[ flr, i, j ] = number;
                    }
                }
            }

            return isFilteredCandidats;
        }
    }
}