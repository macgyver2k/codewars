using System;
using System.Linq;

public class Persist
{
    public static Int32 Persistence( Int64 n )
    {
        var product = n;
        var digits = getDigits( product );

        var i = 0;

        for( ; digits.Length > 1; i++ )
        {
            product = digits.Aggregate( ( d, p ) => d * p );
            digits = getDigits( product );
        }

        return i;
    }

    private static Int32[] getDigits( Int64 product )
    {
        return product.ToString().Select( c => new String( c, 1 ) ).Select( c => Int32.Parse( c ) ).ToArray();
    }
}