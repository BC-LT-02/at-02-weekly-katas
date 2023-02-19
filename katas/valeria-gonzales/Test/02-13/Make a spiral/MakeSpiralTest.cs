namespace MakeSpiral;
using NUnit.Framework;

[TestFixture]
public class MakeSpiralTest
{
    [Test]
    public void Test05()
    {
        int input = 5;
        int[,] expected = new int[,]
        {
            { 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 1 },
            { 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1 }
        };

        int[,] actual = Spiralizor.Spiralize(input);
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test08()
    {
        int input = 8;
        int[,] expected = new int[,]
        {
            { 1, 1, 1, 1, 1, 1, 1, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 0, 0, 1, 0, 1 },
            { 1, 0, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1 },
        };

        int[,] actual = Spiralizor.Spiralize(input);
        Assert.AreEqual(expected, actual);
    }
}
