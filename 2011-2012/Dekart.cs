using System;

class Dekart
{
    static void Main()
    {
        Console.Write("X = ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Y = ");
        int y = int.Parse(Console.ReadLine());
        int res = 0;

        if (x == 0 && y == 0)
        {
            res = 0;
        }


        if (x > 0 && y > 0 && x != y)
        {
            res = 1;
        }
        else if (x >= 0 && y < 0)
        {
            res = 4;
        }
        else if (x > 0 && y == 0)
        {
            res = 6;
        }
        else if (x == 0 && y > 0)
        {
            res = 5;
        }
        else if (x < 0 && y > 0)
        {
            res = 2;
        }
        else if (x < 0 && y < 0)
        {
            res = 3;
        }
        else if (x == y)
        {
            res = x;
        }

        Console.WriteLine("R = {0}", res);

      
    }
}
