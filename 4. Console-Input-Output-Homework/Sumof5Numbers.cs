using System;
class Sumof5Numbers
{
    static void Main()
    {
        string all;
        double a;
        double sum = 0;
        int i = 0;

        Console.WriteLine("Enter two no's seperated by space: ");

        all = Console.ReadLine();
        while (i < 5)
        {
            a = Convert.ToDouble(all.Split(' ')[i]);
            sum = sum + a;
            i++;
        }

        Console.WriteLine("sum = {0}",sum);


    }
}


