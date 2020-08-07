using System;
using System.Linq;

public class YourOrder
{
    public static String Order( String words )
    {
        return words.Length == 0
            ? String.Empty
            : words
            .Split( ' ' )
            .OrderBy( word => word.First( c => c >= '1' && c <= '9' ) )
            .Aggregate( ( a, b ) => a + " " + b );
    }

}