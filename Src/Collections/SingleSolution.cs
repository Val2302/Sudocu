using Sudocu.Src.Extensions;

namespace Sudocu.Src.Collections
{
    public class SingleSolution : Array2D<int>
    {
        public SingleSolution ( int[ , ] singleSolutionArray ) : base( singleSolutionArray )
        {
        }

        public string ToText ( ) => Array.ToText( );

        public override string ToString ( )
        {
            return Array.ToText( nameof( Array ) );
        }
    }
}
