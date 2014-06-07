using System;

class Rectangles
{
    static void Main()
    {
        //S = a.b
        //P = 2.(a + b)
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("S = {0}", a * b);
        Console.WriteLine("P = {0}", 2 * (a + b));
    }
}
