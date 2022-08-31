
using Sudocu.Src.Collections;

namespace Sudocu.Src.Models.Creators
{
    public static class ConditionTableCreator
    {
        private static int[,] ConditionArrayCreate ( )
        {
            // 0 - is empty cell value
            return new int[,]
            {
                { 4, 0, 7,   0, 6, 0,  0, 3, 0 },
                { 0, 0, 8,   1, 0, 2,  0, 0, 0 },
                { 0, 0, 0,   0, 0, 0,  5, 8, 1 },

                { 8, 0, 5,   4, 0, 7,  1, 0, 0 },
                { 0, 4, 0,   0, 3, 8,  2, 0, 5 },
                { 7, 0, 3,   0, 1, 0,  0, 6, 0 },

                { 1, 0, 9,   3, 0, 4,  0, 0, 6 },
                { 0, 0, 0,   0, 0, 0,  4, 0, 0 },
                { 0, 7, 0,   2, 8, 1,  0, 5, 0 },
            };
        }
        
        public static ConditionTable Create ( )
        {
            var conditionArray = ConditionArrayCreate( );

            return new ConditionTable( conditionArray );
        }
    }
}