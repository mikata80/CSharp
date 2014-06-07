using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        int aa = a;
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int bb = b;
        int gcd = 0;

        while (b != 0)
        {
            gcd = b;
            b = a % b;
            a = gcd;
        }

        Console.WriteLine("GCD({0}, {1}) = {2}",aa,bb,gcd);
    }
}
