using Sudocu.Src.Collections;
using Sudocu.Src.Extensions;

using System.Linq;

namespace Sudocu.Src.Models.Solutions
{
    public class Solution
    {
        private int [ , , ] _multiVariant;

        public readonly ESolutionCount SolutionCount;
        
        public readonly SingleSolution SingleVariant;

        public Solution ( ESolutionCount solutionCount, SingleSolution singleVariant, int [,,] multiVariant )
        {
            SolutionCount = solutionCount;
            SingleVariant = singleVariant;
            _multiVariant = multiVariant;
        }
        
        private bool CheckSolution ( )
        {
            const int ITEM_NUMBER_SUM = 45;

            var rowCount = SingleVariant.RowCount;
            var colCount = SingleVariant.ColCount;

            var rowSums = new int [ rowCount ];
            var colSums = new int [ colCount ];

            int number;
            int i, j;

            for ( i = 0; i < rowCount; i ++ )
            {
                for ( j = 0; j < colCount; j ++ )
                {
                    number = SingleVariant[ i, j ];

                    rowSums[ i ] += number;
                    colSums[ j ] += number;
                }
            }

            var sumRows = rowSums.Sum();
            var sumCols = colSums.Sum();

            return ( sumRows == ITEM_NUMBER_SUM * rowCount ) && ( sumCols == ITEM_NUMBER_SUM * colCount );
        }

        public override string ToString ( )
        {
            var checkedSolition = CheckSolution() ? "OK" : "NO";

            return
                $" Solution :\n\n" +
                $"Check = {checkedSolition}\n\n" +
                $"Count = {SolutionCount}\n\n"  +
                $"{SingleVariant.ToText()}\n\n"  +
                $"{_multiVariant.ToText()}\n\n";
        }
    }
}