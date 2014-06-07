using System;

class Numbersfrom1toN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n+1; i++)
        {
            Console.Write("{0} ",i);   
        }

        Console.WriteLine();
    }
}
