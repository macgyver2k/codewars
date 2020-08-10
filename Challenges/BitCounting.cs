using System;
using System.Linq;

public class BitCounting
{
    public static Int32 CountBits( Int32 n )
    {
        var binaryString = Convert.ToString( n, 2 );
        return binaryString.Aggregate( 0, ( a, b ) => a + ( b == '1' ? 1 : 0 ) );
    }
}