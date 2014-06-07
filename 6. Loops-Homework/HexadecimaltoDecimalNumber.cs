using System;

class HexadecimaltoDecimalNumber
{
    static void Main()
    {
        Console.Write("Eneter hex number: ");
        string hex = Console.ReadLine();

        string a;
        long dec = 0;

        for (int i = 1; i <= hex.Length; i++)
        {
            a = hex.Substring(hex.Length - i, 1);
            if (a == "A")
            {
                dec = dec + Convert.ToInt64(Convert.ToInt64(10) * Math.Pow(16, (i - 1)));
            }
            else if (a == "B")
            {
                dec = dec + Convert.ToInt64(Convert.ToInt64(11) * Math.Pow(16, (i - 1)));
            }
            else if (a == "C")
            {
                dec = dec + Convert.ToInt64(Convert.ToInt64(12) * Math.Pow(16, (i - 1)));
            }
            else if (a == "D")
            {
                dec = dec + Convert.ToInt64(Convert.ToInt64(13) * Math.Pow(16, (i - 1)));
            }
            else if (a == "E")
            {
                dec = dec + Convert.ToInt64(Convert.ToInt64(14) * Math.Pow(16, (i - 1)));
            }
            else if (a == "F")
            {
                dec = dec + Convert.ToInt64(Convert.ToInt64(15) * Math.Pow(16, (i - 1)));
            }
            else
            {
                dec = dec + Convert.ToInt64(Convert.ToInt64(a) * Math.Pow(16, (i - 1)));
            }

        }

        Console.WriteLine(dec);
    }
}
