public class Kata
{
    public static string CreatePhoneNumber(int[] numbers)
    {
        var str = string.Concat(numbers);
        return string.Format(
            "({0}) {1}-{2}",
            str.Substring(0, 3),
            str.Substring(3, 3),
            str.Substring(6, 4)
        );
    }
}
