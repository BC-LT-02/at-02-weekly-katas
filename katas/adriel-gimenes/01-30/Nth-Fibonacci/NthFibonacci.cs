using System.Collections.Generic;

public class NthFibonacci
{
  public static int NthFib(int n)
  {
    List<int> list = new List<int>() { 0, 1 };
    for(int i = 2; i < n; i++)
    {
      list.Add(list[i-1] + list[i-2]);
    }
    return list[n - 1];
  }
}
