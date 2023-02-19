namespace MakeSpiral;

public class Spiralizor
{
    public static int[,] Spiralize(int size)
    {

        int[,] result = new int[size, size];
        int x = 0,
            y = 0,
            direction = 1,
            horizontal = 1,
            limit_x = 0,
            limit_y = 0,
            turns = 0;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                result[i, j] = 0;
            }
        }

        while (turns < size)
        {
            result[y, x] = 1;
            if (y == 0 + limit_y && horizontal == 0 && direction == -1)
            {
                horizontal = 1;
                direction *= -1;
                turns++;
            }
            else if (y == size - limit_y - 1 && horizontal == 0 && direction == 1)
            {
                horizontal = 1;
                limit_y += 2;
                direction *= -1;
                turns++;
            }
            else if (x == size - limit_x - 1 && horizontal == 1 && direction == 1)
            {
                horizontal = 0;
                turns++;
            }
            else if (y != 0 && x == 0 + limit_x && horizontal == 1 && direction == -1)
            {
                horizontal = 0;
                limit_x += 2;
                turns++;
            }
            if (horizontal == 1)
            {
                x += direction;
            }
            else
            {
                y += direction;
            }
        }

        return result;
    }
}

