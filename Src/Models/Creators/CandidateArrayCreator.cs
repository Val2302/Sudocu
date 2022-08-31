using Sudocu.Src.Collections;
using Sudocu.Src.Utils;

namespace Sudocu.Src.Models.Creators
{
    public static class CandidateArrayCreator
    {
        private static int[,,] CreateCandidateArray ( int flrCount, int rowCount, int colCount )
        {
            var candidates = new int [ flrCount, rowCount, colCount ];
            
            int i, j, k;
            int number;
            
            for ( i = 0; i < rowCount; i ++ )
            {
                for ( j = 0; j < colCount; j ++ )
                {
                    for ( k = 0; k < flrCount; k ++ )
                    {
                        number = Converter.ConvertIndexToNumber( k );
                        candidates[ k, i, j ] = number;
                    }
                }
            }
            
            return candidates;
        }
        
        public static CandidateArray Create ( int flrCount, int rowCount, int colCount )
        {
            var candidateArray = CreateCandidateArray( flrCount, rowCount, colCount );
            
            return new CandidateArray( candidateArray );
        }
    }
}