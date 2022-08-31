
using Sudocu.Src.Collections;

namespace Sudocu.Src.Models.Solutions
{
    public static class SolutionCountDeterminant
    {
        public static ESolutionCount Determine ( CandidateArray candidateArray )
        {
            var rowCount = candidateArray.RowCount;
            var colCount = candidateArray.ColCount;
            
            var candidatCount = 0;
            
            int i, j;
            
            for ( i = 0; i < rowCount; i ++ )
            {
                for ( j = 0; j < colCount; j ++ )
                {
                    candidatCount = candidateArray.GetCondidateFlrsCount( i, j );

                    if ( candidatCount > 1 )
                    {
                        return ESolutionCount.Multi;
                    }

                    if ( candidatCount == 0 ) 
                    {
                        return ESolutionCount.None;
                    }
                }
            }
            
            return ESolutionCount.Single;
        }
    }
}
