namespace katas.JorgeChavez.Test;

[TestFixture]
public class ROT13Test
{
    [Test, Description("test")]
    public void testTest()
    {
        Assert.AreEqual(
            "grfg",
            ROT13.Rot13("test"),
            String.Format(
                "Input: test, Expected Output: grfg, Actual Output: {0}",
                ROT13.Rot13("test")
            )
        );
    }

    [Test, Description("Test")]
    public void TestTest()
    {
        Assert.AreEqual(
            "Grfg",
            ROT13.Rot13("Test"),
            String.Format(
                "Input: Test, Expected Output: Grfg, Actual Output: {0}",
                ROT13.Rot13("Test")
            )
        );
    }
}
