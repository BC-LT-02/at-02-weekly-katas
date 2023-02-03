namespace katas.AdrielGimenes.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

public class CategorizeNewMembersTest
{
    [Fact]
    public void VerifyMethodReturnsExpectedValues()
    {
        var input = new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } };
        var expected = new[] { "Open", "Senior", "Open", "Senior" };
        Assert.Equal(expected, CategorizeNewMembers.OpenOrSenior(input));

        input = new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } };
        expected = new[] { "Open", "Open", "Open", "Open" };
        Assert.Equal(expected, CategorizeNewMembers.OpenOrSenior(input));

        input = new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } };
        expected = new[] { "Senior", "Open", "Open", "Open" };
        Assert.Equal(expected, CategorizeNewMembers.OpenOrSenior(input));
    }
}
