using System;
using System.Text.RegularExpressions;
using Katas.BinaryMultipleOfThree;

namespace Test.BinaryMultipleOfThree;

public class BinaryMultipleOfThreeTest
{
    [Fact]
    public void CheckType()
    {
        Assert.Equal(typeof(Regex), BinaryRegex.MultipleOf3().GetType());
        Assert.Equal(typeof(Match), BinaryRegex.MultipleOf3().Match("").GetType());
    }

    [Fact]
    public void InvalidCharacters()
    {
        Assert.DoesNotMatch(BinaryRegex.MultipleOf3(), " 0");
        Assert.DoesNotMatch(BinaryRegex.MultipleOf3(), "abc");
        Assert.DoesNotMatch(BinaryRegex.MultipleOf3(), "011 110");
    }

    [Fact]
    public void SmallNumbers()
    {
        Assert.Matches(BinaryRegex.MultipleOf3(), "000");
        Assert.DoesNotMatch(BinaryRegex.MultipleOf3(), "001");
        Assert.DoesNotMatch(BinaryRegex.MultipleOf3(), "010");
        Assert.Matches(BinaryRegex.MultipleOf3(), "011");
        Assert.Matches(BinaryRegex.MultipleOf3(), "110");
        Assert.DoesNotMatch(BinaryRegex.MultipleOf3(), "111");
    }

    [Fact]
    public void LargeNumbers()
    {
        Assert.Matches(BinaryRegex.MultipleOf3(), Convert.ToString(12345678, 2));
        Assert.DoesNotMatch(BinaryRegex.MultipleOf3(), Convert.ToString(12345679, 2));
    }
}