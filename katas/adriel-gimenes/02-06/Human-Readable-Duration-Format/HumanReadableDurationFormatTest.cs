namespace katas.AdrielGimenes.Test;

using Xunit;

public class HumanReadableDurationFormatTest
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("now", HumanTimeFormat.FormatDuration(0));
        Assert.Equal("1 second", HumanTimeFormat.FormatDuration(1));
        Assert.Equal("1 minute and 2 seconds", HumanTimeFormat.FormatDuration(62));
        Assert.Equal("2 minutes", HumanTimeFormat.FormatDuration(120));
    }

    [Fact]
    public void Test2()
    {
        Assert.Equal("1 hour, 1 minute and 2 seconds", HumanTimeFormat.FormatDuration(3662));
        Assert.Equal("182 days, 1 hour, 44 minutes and 40 seconds", HumanTimeFormat.FormatDuration(15731080));
    }

    [Fact]
    public void Test3()
    {
        Assert.Equal("1 year, 19 days, 18 hours, 19 minutes and 46 seconds", HumanTimeFormat.FormatDuration(33243586));
        Assert.Equal("3 years, 85 days, 1 hour, 9 minutes and 26 seconds", HumanTimeFormat.FormatDuration(101956166));
        Assert.Equal("4 years, 68 days, 3 hours and 4 minutes", HumanTimeFormat.FormatDuration(132030240));
        Assert.Equal("6 years, 192 days, 13 hours, 3 minutes and 54 seconds", HumanTimeFormat.FormatDuration(205851834));
        Assert.Equal("7 years, 246 days, 15 hours, 32 minutes and 54 seconds", HumanTimeFormat.FormatDuration(242062374));
        Assert.Equal("8 years, 12 days, 13 hours, 41 minutes and 1 second", HumanTimeFormat.FormatDuration(253374061));
    }
}
