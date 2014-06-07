using System;
class NumberasWords
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());

        int units = a % 10;
        int tens = a % 100;
        int hundreds = a / 100;

        string unitsdesc = "";
        string tensdesc = "";
        string hundredsdesc = "";

        if (a < 10)
        {
            tens = 0;
            hundreds = 0;
        }

        //Console.WriteLine("{0} {1} {2}", hundreds, tens, units);

        if (hundreds > 0)
        {
            switch (hundreds)
            {
                case 1: hundredsdesc = "one hundred"; break;
                case 2: hundredsdesc = "two hundred "; break;
                case 3: hundredsdesc = "three hundred "; break;
                case 4: hundredsdesc = "four hundred"; break;
                case 5: hundredsdesc = "five hundred"; break;
                case 6: hundredsdesc = "six hundred"; break;
                case 7: hundredsdesc = "seven hundred"; break;
                case 8: hundredsdesc = "eight hundred"; break;
                case 9: hundredsdesc = "nine hundred"; break;
            }
        }
        ///////////////////////////////////////////////////////////////////////////////////////
        if (tens > 0)
        {
            if (tens > 19)
            {
                switch (tens / 10)
                {
                    case 2: tensdesc = "and twenty"; break;
                    case 3: tensdesc = "and thirty"; break;
                    case 4: tensdesc = "and forty"; break;
                    case 5: tensdesc = "and fifty"; break;
                    case 6: tensdesc = "and sixty"; break;
                    case 7: tensdesc = "and seventy"; break;
                    case 8: tensdesc = "and eighty"; break;
                    case 9: tensdesc = "and ninety"; break;
                }
            }
            else
            {
                switch (tens)
                {
                    case 10: tensdesc = "and ten"; break;
                    case 11: tensdesc = "and eleven"; break;
                    case 12: tensdesc = "and twelve"; break;
                    case 13: tensdesc = "and thirteen"; break;
                    case 14: tensdesc = "and fourteen"; break;
                    case 15: tensdesc = "and fifteen"; break;
                    case 16: tensdesc = "and sixteen"; break;
                    case 17: tensdesc = "and seventeen"; break;
                    case 18: tensdesc = "and eighteen"; break;
                    case 19: tensdesc = "and nineteen"; break;
                    default: tensdesc = "and"; break;
                }
            }

        }

        if (tens == 0 || tens > 19)
        {
            switch (units)
            {
                case 0: unitsdesc = "zero"; break;
                case 1: unitsdesc = "one"; break;
                case 2: unitsdesc = "two"; break;
                case 3: unitsdesc = "three"; break;
                case 4: unitsdesc = "four"; break;
                case 5: unitsdesc = "five"; break;
                case 6: unitsdesc = "six"; break;
                case 7: unitsdesc = "seven"; break;
                case 8: unitsdesc = "eight"; break;
                case 9: unitsdesc = "nine"; break;
            }

        }

        if (hundreds > 0 && tens == 0)
        {
            unitsdesc = "";
        }

        if (hundreds > 0)
        {
            Console.WriteLine("{0} {1} {2}", hundredsdesc, tensdesc, unitsdesc);
        }
        else if (tens > 0)
        {
            tensdesc = tensdesc.Replace("and ", "");
            Console.WriteLine(tensdesc);
        }
        else
        {
            Console.WriteLine(unitsdesc);
        }
    }
}
