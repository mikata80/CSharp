using System;
class Numbersfrom1ton
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n+1; i++)
        {
            Console.WriteLine(i); 
        }
    }
}
