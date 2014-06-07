using System;

class ComparingFloats
{
    static void Main()
    {
        decimal eps = 0.000001m;
        Console.Write("Enter a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("Enter b = ");
        decimal b = decimal.Parse(Console.ReadLine());
        decimal c = (a - b);

        if (Math.Abs(c) > eps)
        {
            Console.WriteLine("The difference of {0:f8} is too big > eps --> {1})", Math.Abs(c), eps);
        }
        else if (Math.Abs(c) < eps)
        {
            Console.WriteLine("The difference {0:f8} < eps --> {1}", Math.Abs(c), eps);
        }
        else
        {
            Console.WriteLine("Border case. The difference {0} == eps --> {1}. We consider the numbers are different.", Math.Abs(c), eps);
        }
    }

}
