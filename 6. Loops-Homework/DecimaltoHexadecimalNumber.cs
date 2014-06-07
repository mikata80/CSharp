using System;

class DecimaltoHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Eneter decimal number: ");
        long dec = long.Parse(Console.ReadLine());

        long ost;
        string result = "";
        string strost;

        while (dec > 0)
        {
            ost = dec % 16;

            if (ost == 10)
            {
                strost = "A";
            }
            else if (ost == 11)
            {
                strost = "B";
            }
            else if (ost == 12)
            {
                strost = "C";
            }
            else if (ost == 13)
            {
                strost = "D";
            }
            else if (ost == 14)
            {
                strost = "E";
            }
            else if (ost == 15)
            {
                strost = "F";
            }
            else
            {
                strost = ost.ToString();
            }
            dec /= 16;
            result = strost + result;
        }
        Console.WriteLine(result);
    }
}
