namespace katas.AdrielGimenes;

public class Xbonacci
{
  public static double[] Tribonacci(double[] signature, int n)
  {
    List<double> trib = signature.ToList();
    for(int i = 3; i < n; i++)
    {
      trib.Add(trib[i-1] + trib[i-2] + trib[i-3]);
    }
    return trib.Skip(0).Take(n).ToArray();
  }
}
