
/* * * * * * * * * * * * * * * * * *
 * Added methods for collections : *
 * 1. Array[]                      *
 * 2. Array[][]                    *
 * 3. Array[][][]                  *
 * 4. Array[,]                     *
 * 5. Array[,,]                    *
 * 6. Dictionary                   *
 * * * * * * * * * * * * * * * * * */
 
using System;
using System.Collections.Generic;

namespace Sudocu.Src.Extensions
{
    public static class CollectionConverToTextExtension
    {
        private static string GenerateTitle( string collection, string name, int begIndent, string endItem, params int[] counts )
        {
            var newName         = name is null ? string.Empty : $"\"{ name.ToFirstUpper() }\" ";
            var countsText      = ItemsToText( counts, null, 0, "[", "]", null, "|" );
            var begSpacesIndent = new string(' ', begIndent);
            
            return $"{begSpacesIndent}{ collection } { newName }{ countsText } :{endItem}";
        }

        private static string ItemsToText<T>( IEnumerable<T> items, Func<T, string> convert, int begIndent, string begArray, string endArray, string endFirstItem, string begItem, string endItem = null )
        {
            var begSpacesIndent = new string(' ', begIndent);
            var text = begSpacesIndent + begArray;
            
            if( items != null )
            {
                var enumerator = items.GetEnumerator();
                enumerator.MoveNext();

                if( convert is null )
                {   
                    text += enumerator.Current + endFirstItem;
                    
                    while( enumerator.MoveNext() )
                    {
                        text += begItem + enumerator.Current + endItem;
                    }
                }
                else
                {
                    text += convert( enumerator.Current ) + endFirstItem;

                    while( enumerator.MoveNext() )
                    {
                        text += begItem + convert( enumerator.Current ) + endItem;
                    }
                }
            }

            return text + begSpacesIndent + endArray;
        }
        
        private static string ItemsToText<T>( T[,] array, Func<T, string> convert, int begIndent )
        {
            var begSpacesIndent = new string(' ', begIndent);
            var text = $"{begSpacesIndent}{{\n";

            if( array != null )
            {
                int i, j;
                var rowCount = array.GetLength( 0 );
                var colCount = array.GetLength( 1 );

                if( convert is null )
                {
                    for( i = 0; i < rowCount; i++ )
                    {
                        text += $"{begSpacesIndent} ";
                        
                        for( j = 0; j < colCount; j++ )
                        {
                            text += $"|{ array[ i, j ] }";
                        }

                        text += "|\n";
                    }
                }
                else
                {   
                    for( i = 0; i < rowCount; i++ )
                    {
                        text += $"{begSpacesIndent} ";

                        for( j = 0; j < colCount; j++ )
                        {
                            text += $"|{ convert( array[ i, j ] ) }";
                        }

                        text += "|\n";
                    }
                }
            }
            
            return $"{begSpacesIndent}{ text }}}";
        }

        private static string ItemsToText<T>( T[,,] array, Func<T, string> convert, int begIndent )
        {
            var begSpacesIndent = new string(' ', begIndent);
            var text = $"{begSpacesIndent}{{\n";

            if( array != null )
            {
                int k, i, j;
                
                var flrCount = array.GetLength( 0 );
                var rowCount = array.GetLength( 1 );
                var colCount = array.GetLength( 2 );

                if( convert is null )
                {
                    for( i = 0; i < rowCount; i++ )
                    {
                        text += $"{begSpacesIndent} ";

                        for( j = 0; j < colCount; j++ )
                        {
                            text += $"|{ array[ 0, i, j ] }";
                        }

                        text += "|\n";
                    }

                    for( k = 1; k < flrCount; k++ )
                    {
                        text += "\n";

                        for( i = 0; i < rowCount; i++ )
                        {
                            text += $"{begSpacesIndent} ";

                            for( j = 0; j < colCount; j++ )
                            {
                                text += $"|{ array[ k, i, j ] }";
                            }

                            text += "|\n";
                        }
                    }
                }
                else
                {
                    for( i = 0; i < rowCount; i++ )
                    {
                        text += $"{begSpacesIndent} ";

                        for( j = 0; j < colCount; j++ )
                        {
                            text += $"|{ convert( array[ 0, i, j ] ) }";
                        }

                        text += "|\n";
                    }

                    for( k = 1; k < flrCount; k++ )
                    {
                        text += "\n";

                        for( i = 0; i < rowCount; i++ )
                        {
                            text += $"{begSpacesIndent} ";

                            for( j = 0; j < colCount; j++ )
                            {
                                text += $"|{ convert( array[ k, i, j ] ) }";
                            }

                            text += "|\n";
                        }
                    }
                }
            }

            return $"{begSpacesIndent}{ text }}}";
        }

        public static string ToTextRow<T>( this ICollection<T> array, Func<T, string> convert, int begIndent = 0 )
        {
            return ToTextRow<T>( array, null, convert, begIndent );
        }

        public static string ToTextRow<T>( this ICollection<T> array, string title = null, Func<T, string> convert = null, int begIndent = 0 )
        {
            return GenerateTitle( "Array", title, begIndent, " ", array.Count ) + ItemsToText( array, convert, 0, "{ ", " }\n", null, "|" );
        }

        public static string ToTextCol<T>( this ICollection<T> array, Func<T, string> convert, int begIndent = 0 )
        {
            return ToTextCol<T>( array, null, convert, begIndent );
        }

        public static string ToTextCol<T>( this ICollection<T> array, string title = null, Func<T, string> convert = null, int begIndent = 0 )
        {
            return GenerateTitle( "Array", title, begIndent, "\n", array.Count) + ItemsToText( array, convert, begIndent, "{\n ", "}\n", "\n", " ", "\n" );
        }

        public static string ToText2<T>( this T[][] array, Func<T, string> convert, int begIndent = 0 )
        {
            return ToText2( array, null, convert, begIndent );
        }

        public static string ToText2<T>( this T[][] array, string title = null, Func<T, string> convert = null, int begIndent = 0 )
        {
            return array.ToTextCol
            (
                title,
                ( x ) => ItemsToText( x, convert, begIndent, "{", "}\n", null, "|" ) 
            );
        }

        public static string ToText3<T>( this T[][][] array, Func<T, string> convert, int begIndent = 0 )
        {
            return ToText3( array, null, convert, begIndent );
        }

        public static string ToText3<T>( this T[][][] array, string title = null, Func<T, string> convert = null, int begIndent = 0 )
        {
            return array.ToTextCol(
                ( x ) => x.ToTextCol(
                    ( y ) => ItemsToText( y, convert, begIndent, "{", "}\n", null, "|" ),
                    begIndent
                )
            );
        }

        public static string ToText<T>( this T[,] array, Func<T, string> convert, int begIndent = 0 )
        {
            return ToText( array, null, convert, begIndent );
        }

        public static string ToText<T>( this T[,] array, string title = null, Func<T, string> convert = null, int begIndent = 0 )
        {
            if( array is null )
            {
                throw new ArgumentNullException( nameof( array ) );
            }

            var rowCount = array.GetLength( 0 );
            var colCount = array.GetLength( 1 );

            return GenerateTitle( "Array", title, begIndent, "\n", rowCount, colCount ) + ItemsToText( array, convert, begIndent );
        }

        public static string ToText<T>( this T[,,] array, Func<T, string> convert, int begIndent = 0 )
        {
            return ToText( array, null, convert, begIndent );
        }
        
        public static string ToText<T>( this T[,,] array, string title = null, Func<T, string> convert = null, int begIndent = 0 )
        {
            if( array is null )
            {
                throw new ArgumentNullException( $"{nameof( array ).ToFirstUpper()}" );
            }

            var flrCount = array.GetLength( 0 );
            var rowCount = array.GetLength( 1 );
            var colCount = array.GetLength( 2 );

            return GenerateTitle( "Array", title, begIndent, "\n", flrCount, rowCount, colCount ) + ItemsToText( array, convert, begIndent );
        }

        public static string ToText<TKey, TValue>( this Dictionary<TKey, TValue> dictionary, Func<KeyValuePair<TKey, TValue>, string> convert, int begIndent = 0 )
        {
            return ToText( dictionary, null, convert, begIndent );
        }

        public static string ToText<TKey, TValue>( this Dictionary<TKey, TValue> dictionary, string title = null, Func<KeyValuePair<TKey, TValue>, string> convert = null, int begIndent = 0 )
        {
            if( dictionary is null )
            {
                throw new ArgumentNullException( $"{nameof( dictionary ).ToFirstUpper()}" );
            }

            var count = dictionary.Count;
            return GenerateTitle( "Dictionary", title, begIndent, "\n", count ) + ItemsToText( dictionary, convert, begIndent, "{\n ", "}\n", "\n", " ", "\n" );
        }
    }
}
