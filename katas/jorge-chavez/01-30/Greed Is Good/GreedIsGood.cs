namespace katas.JorgeChavez;

public static class Kata
{
    public static int Score(int[] dice)
    {
        string stringDice = string.Join("", dice);

        int one = Regex.Replace(stringDice, @"[^1]", "").Length;
        int two = Regex.Replace(stringDice, @"[^2]", "").Length;
        int three = Regex.Replace(stringDice, @"[^3]", "").Length;
        int four = Regex.Replace(stringDice, @"[^4]", "").Length;
        int five = Regex.Replace(stringDice, @"[^5]", "").Length;
        int six = Regex.Replace(stringDice, @"[^6]", "").Length;

        int totOne = one >= 3 ? 1000 + (one - 3) * 100 : one * 100;
        int tottwo = two >= 3 ? 200 : 0;
        int totthree = three >= 3 ? 300 : 0;
        int totfour = four >= 3 ? 400 : 0;
        int totfive = five >= 3 ? 500 + (five - 3) * 50 : five * 50;
        int totsix = six >= 3 ? 600 : 0;

        int sum = totOne + tottwo + totthree + totfour + totfive + totsix;

        return sum;
    }
}
