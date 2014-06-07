using System;
class RandomNumbersGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write(rnd.Next(min, max) + " ");
        }

        Console.WriteLine();
    }
}
