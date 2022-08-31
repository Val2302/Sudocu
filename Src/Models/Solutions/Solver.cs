using Sudocu.Src.Collections;
using Sudocu.Src.Models.Creators;

namespace Sudocu.Src.Models.Solutions
{
    public class Solver
    {
        private CandidateArray  _candidateArray;
        private GameCondition   _gameCondition;
        private CandidateFilter _candidateFilter;
        
        public Solution Solution { get; private set; }
        
        public Solver ( GameCondition gameCondition )
        {
            _gameCondition   = gameCondition;
            _candidateArray  = CreateCandidateArray( );
            _candidateFilter = new CandidateFilter( _gameCondition, _candidateArray );
        }
        
        private CandidateArray CreateCandidateArray ( )
        {
            var candidateCount = _gameCondition.CandidatCount;
            var rowCount       = _gameCondition.ConditionTable.RowCount;
            var colCount       = _gameCondition.ConditionTable.ColCount;
            
            return CandidateArrayCreator.Create( candidateCount, rowCount, colCount );
        }

        public Solution Solve ( )
        {
            _candidateFilter.FilterByCondition( );

            while ( _candidateFilter.FilterSigleCandidats() );

            var canditionCount = SolutionCountDeterminant.Determine( _candidateArray );

            if ( canditionCount == ESolutionCount.Multi )
            {
                _candidateFilter.CandidateArray = new CandidateArray( _candidateArray );
                _candidateFilter.FilterMultiCandidats();
            }

            return Solution = SolutionCreator.Create( _candidateFilter.CandidateArray, canditionCount );
        }
    }
}