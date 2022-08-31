namespace Sudocu.Src.Utils
{
    public static class Helper
    {
        public const int ONE_CANDIDATE    = 1;
        public const int EMPTY_CELL_VALUE = 0;
        public const int INDEX_NONE       = -1;

        public static bool IsEmptyCell ( int number ) => number < 1;
        
        public static bool IsFilledCell ( int number ) => number > 0;
        
        public static bool IsExistIndex  ( int index ) => index >= 0;
    }
}