using System;

class Cinema
{
    static void Main()
    {
        string typepro = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        decimal result = rows * col;

        if (typepro == "Premiere")
        {
            result *= 12.00m;
        }
        else if (typepro == "Normal")
        {
            result *= 7.50m;
        }
        else if (typepro == "Discount")
        {
            result *= 5.00m;
        }

        Console.WriteLine("{0:F2} leva",result);

    }
}
