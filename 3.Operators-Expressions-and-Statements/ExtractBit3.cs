using System;
class ExtractBit3
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine((n >> 3) & 1);

    }
}
