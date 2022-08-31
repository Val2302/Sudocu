
namespace Sudocu.Src.Collections
{
    public class GameCondition
    {
        public readonly Area Area;
        public readonly int CandidatCount;

        public ConditionTable ConditionTable { get; set; }

        public GameCondition( ConditionTable conditionTable, Area area )
        {
            Area           = area;
            ConditionTable = conditionTable;
            CandidatCount  = area.RowCount * area.ColCount;
        }
    }
}
