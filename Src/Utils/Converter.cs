namespace Sudocu.Src.Utils
{
    public static class Converter
    {
        public static int ConvertNumberToIndex ( int number ) => number - 1;
        public static int ConvertIndexToNumber ( int index  ) => index  + 1;
    }
}