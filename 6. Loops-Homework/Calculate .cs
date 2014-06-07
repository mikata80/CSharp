using System;

class Calculate
{
    static void Main()
    {
        // Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        // 1 + 1!/X + 2!/X^2 + … + N!/X^N
        int fak = 1;
        double calc = 1;
        for (int i = 1; i <= n; i++)
        {
          fak = fak * i;
          calc = calc + (fak / Math.Pow(x, i));
        }

        Console.WriteLine("s = {0:F5}", calc);
    }
}
