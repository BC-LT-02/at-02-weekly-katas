namespace katas.AdrielGimenes.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

public class ConvertingStringToCamelCaseTest
{
    [Fact]
    public void VerifyMethodReturnsExpectedValues()
    {
        var input = "the_stealth_warrior";
        var expected = "theStealthWarrior";
        Assert.Equal(expected, ConvertingStringToCamelCase.ToCamelCase(input));

        input = "The-Stealth-Warrior";
        expected = "TheStealthWarrior";
        Assert.Equal(expected, ConvertingStringToCamelCase.ToCamelCase(input));

        input = "The_Stealth_Warrior";
        expected = "TheStealthWarrior";
        Assert.Equal(expected, ConvertingStringToCamelCase.ToCamelCase(input));
    }
}
