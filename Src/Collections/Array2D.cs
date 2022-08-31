
namespace Sudocu.Src.Collections
{
    public class Array2D<T>
    {
        public T [ , ] Array { get; set; }

        public int RowCount => Array.GetLength( 0 );
        public int ColCount => Array.GetLength( 1 );

        public T this[ int row, int col ]
        {
            get => Array[ row, col ];
            set => Array[ row, col ] = value;
        }

        public Array2D ( T[ , ] conditionArray )
        {
            Array = conditionArray;
        }
    }
}
