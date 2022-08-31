
namespace Sudocu.Src.Cells
{
    public class Cell1D<T> : Cell<T>
    {
        public int Row { get; set; }

        public Cell1D ( )
        {

        }

        public Cell1D ( int row, T data ) : base ( data )
        {
            Row = row;
        }

        public override string ToString ( )
        {
            return $"Cell1D [ { Row } ] = { Data }";
        }
    }
}
