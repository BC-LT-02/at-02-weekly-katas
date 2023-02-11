namespace katas.JorgeChavez.Test;

[TestFixture]
public class ArrayDiffTest
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(
            new int[] { 2 },
            ArrayDiffKata.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 })
        );
        Assert.AreEqual(
            new int[] { 2, 2 },
            ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 })
        );
        Assert.AreEqual(
            new int[] { 1 },
            ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 })
        );
        Assert.AreEqual(
            new int[] { 1, 2, 2 },
            ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { })
        );
        Assert.AreEqual(new int[] { }, ArrayDiffKata.ArrayDiff(new int[] { }, new int[] { 1, 2 }));
        Assert.AreEqual(
            new int[] { 3 },
            ArrayDiffKata.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 })
        );
    }
}
