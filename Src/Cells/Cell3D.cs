
namespace Sudocu.Src.Cells
{
    public class Cell3D<T> : Cell2D<T>
    {
        public int Flr { get; set; }
        
        public Cell3D ( ) : base( )
        {

        }

        public Cell3D ( int flr, int row, int col, T data ) : base ( row, col, data )
        {
            Flr = flr;
        }

        public override string ToString ( )
        {
            return $"Cell3D [ { Flr } | { Row } | { Col } ] = { Data }";
        }
    }
}
