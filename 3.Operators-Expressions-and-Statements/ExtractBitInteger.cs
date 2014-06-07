using System;

class ExtractBitInteger
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        Console.WriteLine(Convert.ToString(p, 2).PadLeft(16, '0'));
        Console.WriteLine(Convert.ToString(((n >> p) & 1), 2).PadLeft(16, '0'));

        Console.WriteLine((n >> p) & 1);


    }
}
