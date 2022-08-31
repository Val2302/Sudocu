using Sudocu.Src.Collections;
using Sudocu.Src.Models.Solutions;

namespace Sudocu.Src.Models.Creators
{
    public static class SolutionCreator
    {
        private static SingleSolution GetSingleSolution ( CandidateArray candidateArray )
        {
            var rowCount = candidateArray.RowCount;
            var colCount = candidateArray.ColCount;
            
            var singleSolution = new int [ rowCount, colCount ];
            
            int i, j;
            
            for ( i = 0; i < rowCount; i ++ )
            {
                for ( j = 0; j < colCount; j ++ )
                {
                    singleSolution[ i, j ] = candidateArray.LastFlrNumber( i, j );
                }
            }
            
            return new SingleSolution( singleSolution );
        }
        
        public static Solution Create ( CandidateArray candidateArray, ESolutionCount solutionCount )
        {
            var singleSolution = GetSingleSolution( candidateArray );
            var multiSolution  = candidateArray.Array;
            
            return new Solution ( solutionCount, singleSolution, multiSolution );
        }
    }
}