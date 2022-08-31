using Sudocu.Src.Collections;
using Sudocu.Src.Extensions;

namespace Sudocu.Src.Collections
{
    public class ConditionTable : Array2D<int>
    {   
        public ConditionTable ( int [,] conditionArray ) : base( conditionArray )
        {
        }
        
        public override string ToString ( )
        {
            return Array.ToText( nameof( Array ) );
        }
    }
}