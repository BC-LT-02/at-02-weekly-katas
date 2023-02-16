namespace katas.JorgeChavez.Test;

[TestFixture]
public class Tests
{
    [TestCase(new int[] { 1, 1 }, new int[] { 1, 1 }, 0)]
    [TestCase(new int[] { 5, 4 }, new int[] { 3, 2 }, 4)]
    [TestCase(new int[] { 1, 1 }, new int[] { 0, 3 }, 3)]
    [TestCase(new int[] { 1, 1 }, new int[] { 1, 1 }, 0)]
    [TestCase(new int[] { 5, 4 }, new int[] { 3, 2 }, 4)]
    [TestCase(new int[] { 1, 1 }, new int[] { 0, 3 }, 3)]
    [TestCase(new int[] { 10, 10 }, new int[] { -5, -5 }, 30)]
    [TestCase(new int[] { 0, 0 }, new int[] { 100, 100 }, 200)]
    [TestCase(new int[] { 2, 5 }, new int[] { 7, 1 }, 9)]
    [TestCase(new int[] { -3, -3 }, new int[] { -3, -3 }, 0)]
    [TestCase(new int[] { 0, 0 }, new int[] { 0, 10 }, 10)]
    [TestCase(new int[] { 100, 100 }, new int[] { 200, 300 }, 300)]
    public void Test(int[] pointA, int[] pointB, int expectedDistance)
    {
        int actualDistance = Manhattan.Distance(pointA, pointB);
        Assert.AreEqual(expectedDistance, actualDistance);
    }
}
