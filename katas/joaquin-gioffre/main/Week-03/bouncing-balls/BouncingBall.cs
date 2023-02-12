namespace Week3;

public static class BouncingBall
{
    public static int GetBouncingBallViews(double h, double bounce, double window)
    {
        if (h <= 0 || bounce <= 0 || bounce >= 1 || window >= h) 
        {
            return -1;
        }

        int count = 1;
        double bounceHeight = h * bounce;

        while (bounceHeight > window) 
        {   
            count += 2;
            bounceHeight *= bounce;
        }

        return count;
    }
}