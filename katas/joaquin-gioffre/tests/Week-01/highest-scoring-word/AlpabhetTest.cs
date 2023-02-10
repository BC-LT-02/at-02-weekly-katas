namespace HighestScoringWordTest;

using Week1;

public class AlphabetTest
{
    [Fact]
    public void ItShouldHave26Letters()
    {
        Alphabet newAlphabet = new Alphabet();
        Assert.Equal(26, newAlphabet.alphabet.Count());
    }

    [Fact]
    public void ItShouldReturnTheCorrectValueOfTheLetter()
    {
        Alphabet newAlphabet = new Alphabet();
        Assert.Equal(1, newAlphabet.alphabet["a"]);
        Assert.Equal(2, newAlphabet.alphabet["b"]);
        Assert.Equal(3, newAlphabet.alphabet["c"]);
        Assert.Equal(4, newAlphabet.alphabet["d"]);
        Assert.Equal(5, newAlphabet.alphabet["e"]);
        Assert.Equal(6, newAlphabet.alphabet["f"]);
        Assert.Equal(7, newAlphabet.alphabet["g"]);
        Assert.Equal(8, newAlphabet.alphabet["h"]);
        Assert.Equal(9, newAlphabet.alphabet["i"]);
        Assert.Equal(10, newAlphabet.alphabet["j"]);
        Assert.Equal(11, newAlphabet.alphabet["k"]);
        Assert.Equal(12, newAlphabet.alphabet["l"]);
        Assert.Equal(13, newAlphabet.alphabet["m"]);
        Assert.Equal(14, newAlphabet.alphabet["n"]);
        Assert.Equal(15, newAlphabet.alphabet["o"]);
        Assert.Equal(16, newAlphabet.alphabet["p"]);
        Assert.Equal(17, newAlphabet.alphabet["q"]);
        Assert.Equal(18, newAlphabet.alphabet["r"]);
        Assert.Equal(19, newAlphabet.alphabet["s"]);
        Assert.Equal(20, newAlphabet.alphabet["t"]);
        Assert.Equal(21, newAlphabet.alphabet["u"]);
        Assert.Equal(22, newAlphabet.alphabet["v"]);
        Assert.Equal(23, newAlphabet.alphabet["w"]);
        Assert.Equal(24, newAlphabet.alphabet["x"]);
        Assert.Equal(25, newAlphabet.alphabet["y"]);
        Assert.Equal(26, newAlphabet.alphabet["z"]);
    }
}