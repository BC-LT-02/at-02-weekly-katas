namespace katas.JorgeChavez.Test;

[TestFixture]
public class HammingTests
{
    [TestCase("hello world", "hello world", 0)]
    [TestCase("I like turtles", "I like turkeys", 3)]
    [TestCase("hello world", "hello tokyo", 4)]
    [TestCase("a man a plan a canal", "a man a plan sobanal", 3)]
    [TestCase("hamming and cheese", "Hamming and Cheese", 2)]
    [TestCase("espresso", "Expresso", 2)]
    [TestCase("old father, old artificer", "of my soul the uncreated ", 24)]
    public void StaticTests(string a, string b, int expected)
    {
        Assert.AreEqual(
            expected,
            Hamming.Distance(a, b),
            string.Format("Expected hamming distance of '{0}' and '{1}' to be {2}", a, b, expected)
        );
    }
}
