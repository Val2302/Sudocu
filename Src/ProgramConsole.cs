using Sudocu.Src.Models.Creators;
using Sudocu.Src.Models.Solutions;

using static System.Console;

namespace Sudocu.Src
{
    class ProgramConsoles
    {
        public static void Main ( string [] args )
        {
            var gameContition = GameConditionCreator.Create();
            var solver = new Solver ( gameContition );

            solver.Solve();
            WriteLine( solver.Solution );

            SetCursorPosition( 0, 0 );
            ReadKey();
        }
    }
}