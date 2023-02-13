namespace TheObservedPIN;
public class ObservedPIN
{
    static int[][] adjacent = new int[][] {
        new int[] {0, 8},
        new int[] {1, 2, 4},
        new int[] {1, 2, 3, 5},
        new int[] {2, 3, 6},
        new int[] {1, 4, 5, 7},
        new int[] {2, 4, 5, 6, 8},
        new int[] {3, 5, 6, 9},
        new int[] {4, 7, 8},
        new int[] {5, 7, 8, 9, 0},
        new int[] {6, 8, 9}
    };

    public static List<string> GetPINs(string observed)
    {
        List<string> result = new List<string>();
        result.Add("");

        foreach (char c in observed)
        {
            int number = c - '0';
            List<string> combos = new List<string>();
            foreach (int adjacentNumber in adjacent[number])
            {
                foreach (string pin in result)
                {
                    combos.Add(pin + adjacentNumber.ToString());
                }
            }
            result = combos;
        }

        return result;
    }
}
