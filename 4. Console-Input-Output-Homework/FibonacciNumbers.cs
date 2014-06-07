using System;
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int nn = int.Parse(Console.ReadLine()); ;
        int a;
        int b;
        int mp = 0;

        for (int i = 0; i < nn; i++)
        {
            a = 0;
            b = 1;
            for (int j = 1; j < i + 1; j++)
            {
                int c = a;
                a = b;
                b = c + b;
            }
            mp = a;
            Console.Write(mp + " ");
        }
        Console.WriteLine();
    }
}
