namespace LikeSystemTest;

using LikeSystem;

public class LikeSystemTest
{
    [Fact]
    public void ItShouldReturnAStringSpecifyingWhoLikesIt()
    {
        LikeSystem system = new LikeSystem();
        Assert.Equal("no one likes this", system.WhoLikesIt(new string[0]));
        Assert.Equal("Peter likes this", system.WhoLikesIt(new string[] {"Peter"}));
        Assert.Equal("Jacob and Alex like this", system.WhoLikesIt(new string[] {"Jacob", "Alex"}));
        Assert.Equal("Max, John and Mark like this", system.WhoLikesIt(new string[] {"Max", "John", "Mark"}));
        Assert.Equal("Alex, Jacob and 2 others like this", system.WhoLikesIt(new string[] {"Alex", "Jacob", "Mark", "Max"})); 
        Assert.Equal("Alex, Jacob and 3 others like this", system.WhoLikesIt(new string[] {"Alex", "Jacob", "Mark", "Max", "George"})); 
        Assert.Equal("Alex, Jacob and 4 others like this", system.WhoLikesIt(new string[] {"Alex", "Jacob", "Mark", "Max", "George", "Malcolm"})); 
        Assert.Equal("Alex, Jacob and 5 others like this", system.WhoLikesIt(new string[] {"Alex", "Jacob", "Mark", "Max", "George", "Malcolm", "Linda"})); 
    }
}