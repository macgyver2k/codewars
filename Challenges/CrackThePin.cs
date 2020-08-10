using System;
using System.Linq;
using System.Security.Cryptography;

public class CrackThePin
{
    public static String crack( String hash )
    {
        var md5 = MD5.Create();

        for( var index = 0; index < 100000; index++ )
        {
            var pin = index.ToString( "00000" );
            var bytes = System.Text.Encoding.UTF8.GetBytes( pin );
            var pinHashBytes = md5.ComputeHash( bytes );
            var pinHash = String.Join( "", pinHashBytes.Select( a => a.ToString( "x2" ) ) );

            if( pinHash == hash )
            {
                return pin;
            }
        }

        return "";
    }
}