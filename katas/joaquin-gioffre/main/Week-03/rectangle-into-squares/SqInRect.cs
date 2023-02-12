namespace Week3;

public class SqInRect
{
    public static List<int> GetSquaresSizesInRectangle(int lng, int wdth) {

    if (lng == wdth) 
    {
      return null!;
    }
    
    List<int> sizes = new List<int>();
    
    while (lng > 0 && wdth > 0) 
    {
      sizes.Add(Math.Min(lng, wdth));
      if (lng > wdth) 
      {
        lng -= wdth;
      } else 
      {
        wdth -= lng;
      }
    }
    
    return sizes;
	}
}