namespace Week2Test;

using Week2;

public class ValidBracesTest
{
    [Fact]
    public void ItShouldValidateIfBracesAreValidsOrNot()
    {
        Assert.True(ValidBraces.AreValidBraces("()"));
        Assert.True(ValidBraces.AreValidBraces("([{}])"));
        Assert.True(ValidBraces.AreValidBraces("(){}[]"));
        Assert.False(ValidBraces.AreValidBraces("[[())]]"));
        Assert.False(ValidBraces.AreValidBraces("][]"));
        Assert.False(ValidBraces.AreValidBraces("[(])"));
        Assert.False(ValidBraces.AreValidBraces("[({})](]"));
    }
}