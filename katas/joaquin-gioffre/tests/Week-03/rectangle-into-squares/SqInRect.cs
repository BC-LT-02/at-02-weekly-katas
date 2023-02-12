namespace Week3Test;

using Week3;

public class SqInRectTest
{
    [Fact]
    public void ItShouldGetTheSquaresSizesInRectangle()
    {
        Assert.Equal(new List<int>{3, 2, 1, 1}, SqInRect.GetSquaresSizesInRectangle(5,3));
        Assert.Equal(new List<int>{3, 2, 1, 1}, SqInRect.GetSquaresSizesInRectangle(3,5));
        Assert.Null(SqInRect.GetSquaresSizesInRectangle(4,4));
        Assert.Equal(new List<int>{3, 2, 1, 1}, SqInRect.GetSquaresSizesInRectangle(3,5));
        Assert.Equal(new List<int>{4, 4}, SqInRect.GetSquaresSizesInRectangle(8,4));
        Assert.Equal(new List<int>{1, 1, 1}, SqInRect.GetSquaresSizesInRectangle(3,1));
        Assert.Equal(new List<int>{3, 3}, SqInRect.GetSquaresSizesInRectangle(3,6));
        Assert.Equal(new List<int>{4, 4}, SqInRect.GetSquaresSizesInRectangle(4,8));
    }
}