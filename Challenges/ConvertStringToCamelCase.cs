using System;
using System.Linq;

public class ConvertStringToCamelCase
{
    public static String ToCamelCase( String str )
    {

        return str
            .Split( '-', '_' )
            .Select( ( word, index ) => word.Select( ( c, i ) => index > 0 ? i == 0 ? new String( c, 1 ).ToUpper()[ 0 ] : c : c ).ToArray() )
            .Aggregate( "", ( a, b ) => a + new String( b ) );
    }
}