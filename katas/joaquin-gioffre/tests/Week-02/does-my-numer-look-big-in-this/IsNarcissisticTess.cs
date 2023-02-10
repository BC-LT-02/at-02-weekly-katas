namespace DoesMyNumberLookBigInThisTest;

using Week2;

public class IsNarcissisticTest
{
    [Fact]
    public void ItShouldValidateIfNumberIsNarcissisticOrNot()
    {
        Assert.True(DoesMyNumberLookBigInThis.IsNarcissistic(1));
        Assert.True(DoesMyNumberLookBigInThis.IsNarcissistic(371));
        Assert.True(DoesMyNumberLookBigInThis.IsNarcissistic(153));
        Assert.False(DoesMyNumberLookBigInThis.IsNarcissistic(1652));
    }
}