namespace JustifyText;
using NUnit.Framework;
using System;

[TestFixture]
public class SolutionTest
{
    [Test]
    public void MyTest()
    {
        Assert.AreEqual("123  45\n6", JustifyTextClass.Justify("123 45 6", 7));
    }
}
