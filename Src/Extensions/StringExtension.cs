
namespace Sudocu.Src.Extensions
{
    public static class StringExtension
    {
        public static string ToFirstUpper( this string text )
        {
            return char.ToUpper( text[ 0 ] ) + text.Substring( 1 );
        }

        public static string Repeat( string text, int count )
        {
            var result = string.Empty;

            for ( var i = 0; i < count; i++ )
            {
                result += text;
            }

            return result;
        }
    }
}
