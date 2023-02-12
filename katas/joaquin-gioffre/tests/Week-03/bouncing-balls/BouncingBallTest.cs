namespace Week3Test;

using Week3;

public class BouncingBallTest
{
    [Fact]
    public void ItShouldGetTheViewsOfTheBouncingBall()
    {
        Assert.Equal(3, BouncingBall.GetBouncingBallViews(3, 0.66, 1.5));
        Assert.Equal(15, BouncingBall.GetBouncingBallViews(30.0, 0.66, 1.5));
        Assert.Equal(5, BouncingBall.GetBouncingBallViews(2, 0.75, 1));
        Assert.Equal(-1, BouncingBall.GetBouncingBallViews(0, 0.66, 1.5));
        Assert.Equal(-1, BouncingBall.GetBouncingBallViews(3, 0, 1.5));
        Assert.Equal(-1, BouncingBall.GetBouncingBallViews(3, 1, 1.5));
        Assert.Equal(-1, BouncingBall.GetBouncingBallViews(3, 0.66, 3));
    }
}