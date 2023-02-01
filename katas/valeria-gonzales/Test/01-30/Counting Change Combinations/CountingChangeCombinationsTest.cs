using Katas.CountingChangeCombinations;
namespace Test.CountingClassCombinations;

public class CountingChangeCombinationsTest
{
    CountingChangeCombinations kata = new CountingChangeCombinations();

    [Fact]
    public void SimpleCase()
    {
        Assert.Equal(3, kata.CountCombinations(4, new[] { 1, 2 }));
    }

    [Fact]
    public void AnotherSimpleCase()
    {
        Assert.Equal(4, kata.CountCombinations(10, new[] { 5, 2, 3 }));
    }

    [Fact]
    public void NoChange()
    {
        Assert.Equal(0, kata.CountCombinations(11, new[] { 5, 7 }));
    }
}
