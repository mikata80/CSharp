using System;

class CirclePerimeterArea
{
    static void Main(string[] args)
    {
        //s = pi*r^2
        //p=2pi*r
        Console.Write("r = ");
        decimal r = decimal.Parse(Console.ReadLine());
        Console.WriteLine("P= {0} \nS = {1}", Math.Round(Convert.ToDecimal(Math.PI) * 2 * r, 2), Math.Round(Convert.ToDecimal(Math.PI) * r * r, 2));
    }
}
