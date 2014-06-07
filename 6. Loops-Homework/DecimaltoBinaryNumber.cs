using System;

class DecimaltoBinaryNumber
{
    static void Main()
    {
        Console.Write("Eneter decimal number: ");
        long dec = long.Parse(Console.ReadLine());

        long ost;
        string result = "";
        while (dec> 0)
        {
            ost = dec % 2;
            dec /= 2;
            result = ost.ToString() + result;
        }
        Console.WriteLine(result);
    }
}
