namespace katas.AdrielGimenes;

using System;
using System.Collections.Generic;
using System.Linq;

public class CategorizeNewMembers
{
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        return data.ToList().Select(data => data[0] >= 55 && data[1] > 7 ? "Senior" : "Open");
    }
}
