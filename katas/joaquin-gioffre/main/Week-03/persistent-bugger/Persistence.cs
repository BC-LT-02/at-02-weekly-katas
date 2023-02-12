namespace Week3;

public static class Persist
{
	public static int Persistence(long num) 
	{
        int count = 0;
    
        while (num > 9)
        {
            long product = 1;
            while (num > 0)
            {
                product *= num % 10;
                num /= 10;
            }
                num = product;
            count++;
        }
    
        return count;
	}
}