namespace katas.AdrielGimenes.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

public class RgbToHexConversionTest
{
    [Fact]
    public void VerifyMethodReturnsExpectedValues()
    {
        Assert.Equal("FFFFFF", RgbToHexConversion.Rgb(255, 255, 255));

        Assert.Equal("FFFFFF", RgbToHexConversion.Rgb(255, 255, 300));

        Assert.Equal("000000", RgbToHexConversion.Rgb(0, 0, 0));

        Assert.Equal("9400D3", RgbToHexConversion.Rgb(148, 0, 211));
    }
}
