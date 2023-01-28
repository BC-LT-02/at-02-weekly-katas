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
        Assert.Equal("FFFFFF", RgbToHexConversion.Rgb(255,255,255));

        Assert.Equal("FFFFFF", RgbToHexConversion.Rgb(255,255,300));

        Assert.Equal("000000", RgbToHexConversion.Rgb(0,0,0));

        Assert.Equal("9400D3", RgbToHexConversion.Rgb(148,0,211));

        Assert.Equal("9400D3", RgbToHexConversion.Rgb(148,-20,211));

        Assert.Equal("90C3D4", RgbToHexConversion.Rgb(144,195,212));

        Assert.Equal("D4350C", RgbToHexConversion.Rgb(212,53,12));
    }
}
