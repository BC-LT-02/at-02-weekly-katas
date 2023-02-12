namespace Week3Test;

using Week3;

public class PersistTest
{
    [Fact]
    public void ItShouldReturnSingleDigitOfPersistenceNumber()
    {
        Assert.Equal(0, Persist.Persistence(5));
        Assert.Equal(2, Persist.Persistence(25));
        Assert.Equal(3, Persist.Persistence(39));
        Assert.Equal(4, Persist.Persistence(999));
    }
}