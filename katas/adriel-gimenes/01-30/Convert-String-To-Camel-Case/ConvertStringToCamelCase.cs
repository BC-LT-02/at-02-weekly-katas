namespace katas.AdrielGimenes;

using System;
using System.Linq;
using System.Text.RegularExpressions;

public class ConvertingStringToCamelCase
{
  public static string ToCamelCase(string str)
  {
    return String.Concat(str.Split('-','_')
                         .Select((word, index) => index > 0 ? Char.ToUpper(word[0]) + word.Substring(1) : word));
  }
}
