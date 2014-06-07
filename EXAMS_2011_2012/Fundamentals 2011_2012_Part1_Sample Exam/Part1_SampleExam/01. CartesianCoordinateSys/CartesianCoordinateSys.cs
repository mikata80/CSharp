using System;
class CartesianCoordinateSys
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());

        int result = 0;

        

        // logic
        if (x > 0 && y > 0)
        {
            result = 1;
        }
        else if (x < 0 && y > 0)
        {
            result = 2;
        }
        else if (x <0 && y <0)
        {
            result = 3;
        }
        else if (x>0 && y<0)
        {
            result = 4;
        }
        else if (x != 0 && y == 0)
        {
            result = 6;
        }
        else if (y != 0 && x == 0)
        {
            result = 5;
        }
        else if (x == 0 && y ==0)
        {
            result = 0;
        }
        

        //output
        Console.WriteLine(result);


    }
}
