using System;
class Circle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        double cpoint = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2);
        double d = 1.5 * 1.5;

        if( (cpoint <= d)  &&( (x >=-1) && (x<= 5)) && ( (y >= -1) && (y<=1)))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
            
    }
}
