namespace katas.AdrielGimenes.Test;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

public class NthFibonacciTest
{
    [Fact]
    public void VerifyMethodReturnsExpectedValues()
    {
        Assert.Equal(0, NthFibonacci.NthFib(1));

        Assert.Equal(3, NthFibonacci.NthFib(5));

        Assert.Equal(34, NthFibonacci.NthFib(10));

        Assert.Equal(4181, NthFibonacci.NthFib(20));
    }
}
