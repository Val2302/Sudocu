
namespace Sudocu.Src.Cells
{
    public class CellND<T> : Cell<T>
    {
        public int [ ] Indexes { get; set; }

        public CellND ( ) : base ( )
        {

        }

        public CellND ( T data, params int [ ] indexes ) : base ( data )
        {
            Indexes = indexes;
        }

        private string ToStringIndexes ( )
        {
            var text = Indexes[ 0 ].ToString();

            foreach ( var index in Indexes )
            {
                text += $" | { index }";
            }

            return text;
        }

        public override string ToString ( )
        {
            var textIndexes = ToStringIndexes( );
            return $"CellND [ { textIndexes } ] = { Data }";
        }
    }
}
