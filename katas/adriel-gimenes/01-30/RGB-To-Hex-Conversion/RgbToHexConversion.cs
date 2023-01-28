namespace katas.AdrielGimenes;

public class RgbToHexConversion
{
  public static string Rgb(int r, int g, int b) 
  {
    return ToHex(r) + ToHex(g) + ToHex(b);
  }

  private static string ToHex(int value)
  {
    if(value < 0) return "00";
    if(value > 255) return "FF";
    return value.ToString("x2").ToUpper().PadLeft(2, '0');
  }
}
