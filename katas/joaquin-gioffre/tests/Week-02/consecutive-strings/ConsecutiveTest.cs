namespace Week2Test;

using Week2;

public class ConsecutiveTest
{
    [Fact]
    public void ItShouldReturnTheLongestConsecutiveString()
    {
        Assert.Equal("abigailtheta", Consecutive.GetLongestConsecutive(new String[] {"zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"}, 2));
        Assert.Equal("oocccffuucccjjjkkkjyyyeehh", Consecutive.GetLongestConsecutive(new String[] {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"}, 1));
        Assert.Equal("", Consecutive.GetLongestConsecutive(new String[] {}, 3));
        Assert.Equal("wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck", Consecutive.GetLongestConsecutive(new String[] {"itvayloxrp","wkppqsztdkmvcuwvereiupccauycnjutlv","vweqilsfytihvrzlaodfixoyxvyuyvgpck"}, 2));
        Assert.Equal("wlwsasphmxxowiaxujylentrklctozmymu", Consecutive.GetLongestConsecutive(new String[] {"wlwsasphmxx","owiaxujylentrklctozmymu","wpgozvxxiu"}, 2));
        Assert.Equal("", Consecutive.GetLongestConsecutive(new String[] {"zone", "abigail", "theta", "form", "libe", "zas"}, -2));
        Assert.Equal("ixoyx3452zzzzzzzzzzzz", Consecutive.GetLongestConsecutive(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 3));
        Assert.Equal("", Consecutive.GetLongestConsecutive(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 15));
        Assert.Equal("", Consecutive.GetLongestConsecutive(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 0));
    }
}