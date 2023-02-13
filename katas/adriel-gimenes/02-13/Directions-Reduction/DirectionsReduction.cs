namespace katas.AdrielGimenes;

using System.Text.RegularExpressions;

public class DirectionsReduction
{

    public static string[] DirReduc(String[] arr)
    {
        Regex regex = new Regex(@"((SOUTH\s+NORTH)|(NORTH\s+SOUTH)|(WEST\s+EAST)|(EAST\s+WEST))");
        string str = String.Join(" ", arr);
        while (regex.IsMatch(str))
        {
            str = regex.Replace(str, "");
        }
        return str.Split(" ").Where(e => !String.IsNullOrEmpty(e)).ToArray();
        ;
    }
}
