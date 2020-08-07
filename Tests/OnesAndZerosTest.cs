using NUnit.Framework;

using System;

[TestFixture]
public class OnesAndZerosTests
{
    private readonly Int32[] Test1 = new Int32[] { 0, 0, 0, 0 };
    private readonly Int32[] Test2 = new Int32[] { 1, 1, 1, 1 };
    private readonly Int32[] Test3 = new Int32[] { 0, 1, 1, 0 };
    private readonly Int32[] Test4 = new Int32[] { 0, 1, 0, 1 };
    [Test]
    public void BasicTesting()
    {
        Assert.AreEqual( 0, OnesAndZeros.binaryArrayToNumber( this.Test1 ) );
        Assert.AreEqual( 15, OnesAndZeros.binaryArrayToNumber( this.Test2 ) );
        Assert.AreEqual( 6, OnesAndZeros.binaryArrayToNumber( this.Test3 ) );
        Assert.AreEqual( 5, OnesAndZeros.binaryArrayToNumber( this.Test4 ) );
    }
}