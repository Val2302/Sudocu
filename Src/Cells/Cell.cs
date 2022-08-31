
namespace Sudocu.Src.Cells
{
    public class Cell<T>
    {
        public T Data { get; set; }

        public Cell ( )
        {

        }

        public Cell ( T data )
        {
            Data = data;
        }

        public override string ToString ( )
        {
            return $"Data = {{ { Data } }}";
        }
    }
}
