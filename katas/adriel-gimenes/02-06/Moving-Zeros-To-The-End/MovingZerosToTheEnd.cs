namespace katas.AdrielGimenes;

using System.Linq;

public class MovingZerosToTheEnd
{
  public static int[] MoveZeroes(int[] arr)
  {
    return arr.OrderBy(e => e == 0).ToArray();
  }
}
