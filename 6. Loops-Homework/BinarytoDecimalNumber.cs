using System;

class BinarytoDecimalNumber
{
    static void Main()
    {
        Console.Write("Eneter binary number: ");
        string bin = Console.ReadLine();

        string a;
        long dec = 0; 

        for (int i = 1; i <= bin.Length; i++)
        {
            a = bin.Substring(bin.Length-i,1);
            dec = dec + Convert.ToInt64(Convert.ToInt64(a) * Math.Pow(2, (i-1)));
        }

        Console.WriteLine(dec);
    }
}
