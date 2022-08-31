
using Sudocu.Src.Collections;

namespace Sudocu.Src.Models.Creators
{
    public static class GameConditionCreator
    {
        public static Area AreaCreator ( )
        {
            var rowCount = 3;
            var colCount = 3;

            return new Area( rowCount, colCount );
        }

        public static GameCondition Create ( )
        {
            var area           = AreaCreator();
            var conditionTable = ConditionTableCreator.Create();

            return new GameCondition( conditionTable, area );
        }
    }
}
