using System;
class Trapezoids
{
    static void Main()
    {
        Console.Write("a =  ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b =  ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("h =  ");
        double h = Convert.ToDouble(Console.ReadLine());
        double s = ((a + b) / 2) * h;

        Console.WriteLine("S(area) = {0}", s);
    }
}
