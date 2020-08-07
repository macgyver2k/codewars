using System;
using System.Linq;

public class OnesAndZeros
{
    public static Int32 binaryArrayToNumber( Int32[] BinaryArray )
    {
        return BinaryArray.Reverse().Select( ( bit, index ) => (bit, index) ).Aggregate( 0, ( a, b ) => a | ( b.bit << b.index ) );
    }
}