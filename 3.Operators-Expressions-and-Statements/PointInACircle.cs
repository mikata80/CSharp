using System;

class PointInACircle
{
    static void Main()
    {
        //x² + y² < R²
        Console.Write("x = ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("y = ");
        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine((Math.Pow(x, 2) + Math.Pow(y, 2)) < 4);
    }
}
