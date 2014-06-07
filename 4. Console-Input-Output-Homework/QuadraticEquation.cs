using System;
class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;
        double x1;
        double x2;

        if (d < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (d == 0)
        {
            x1 = x2 = (b * (-1) )/( 2 * a);
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else
        {
            x1 = ((b * (-1) - (Math.Sqrt(b * b - 4 * a * c))) / (2 * a));
            x2 = ((b * (-1) + (Math.Sqrt(b * b - 4 * a * c))) / (2 * a));
            Console.WriteLine("x1 = {0} , x2 = {1}", x1, x2);
        }


        //Console.WriteLine("a= {0}, b = {1}, c= {2}, d = {3}",a,b,c,d);

    }
}
