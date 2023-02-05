namespace HighestScoringWordTest;

using Week1;

public class HighestScoringWordTest
{
    [Fact]
    public void ItShouldReturnTheScoreOfTheWord()
    {
        Alphabet newAlphabet = new Alphabet();
        HighestScoringWord score = new HighestScoringWord();
        Assert.Equal(8, score.GetWordScore("abad", newAlphabet.alphabet));
        Assert.Equal(4, score.GetWordScore("aaaa", newAlphabet.alphabet));
        Assert.Equal(100, score.GetWordScore("yyyy", newAlphabet.alphabet));
        Assert.Equal(351, score.GetWordScore("abcdefghijklmnopqrstuvwxyz", newAlphabet.alphabet));
        Assert.Equal(0, score.GetWordScore("!@#$%ˆ  &*()_+  {}|[]", newAlphabet.alphabet));
    }

    [Fact]
    public void ItShouldReturnTheWordWithTheHighestScore()
    {
        Alphabet newAlphabet = new Alphabet();
        HighestScoringWord score = new HighestScoringWord();
        Assert.Equal("taxi", score.GetHighestScoringWord("man i need a taxi up to ubud", newAlphabet.alphabet));
        Assert.Equal("volcano", score.GetHighestScoringWord("what time are we climbing up the volcano", newAlphabet.alphabet));
        Assert.Equal("semynak", score.GetHighestScoringWord("take me to semynak", newAlphabet.alphabet));
        Assert.Equal("aa", score.GetHighestScoringWord("aa b", newAlphabet.alphabet));
        Assert.Equal("b", score.GetHighestScoringWord("b aa", newAlphabet.alphabet));
        Assert.Equal("bb", score.GetHighestScoringWord("bb d", newAlphabet.alphabet));
        Assert.Equal("d", score.GetHighestScoringWord("d bb", newAlphabet.alphabet));
        Assert.Equal("aaa", score.GetHighestScoringWord("aaa b", newAlphabet.alphabet));
    }

}