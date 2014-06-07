using System;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal s = 0m;
        decimal d = 0m;

        for (int i = 0; i < n * 2; i++)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            if (i >= n)
            {
                d = d + num;
            }
            else
            {
                s = s + num;
            }
        }

        Console.WriteLine(s == d ? "Yes, sum=" + s : "No, diff=" + Math.Abs(s - d));
    }
}
