
namespace Sudocu.Src.Cells
{
    public class Cell2D<T> : Cell1D<T>
    {
        public int Col { get; set; }

        public Cell2D ( ) : base()
        {

        }

        public Cell2D ( int row, int col, T data ) : base ( row, data )
        {
            Col = col;
        }

        public override string ToString ( )
        {
            return $"Cell2D [ { Row } | { Col } ] = { Data }";
        }
    }
}
