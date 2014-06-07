using System;
class NumberComparer
{
    static void Main()
    {
        Console.Write("a = ");
        decimal a = decimal.Parse(Console.ReadLine());
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("greater = {0}", a);
        }
        else
        {
            Console.WriteLine("greater = {0}", b);
        }

    }
}
