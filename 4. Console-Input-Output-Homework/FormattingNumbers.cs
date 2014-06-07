using System;
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        int a;

        while (true)
        {
            a = Convert.ToInt32(Console.ReadLine());

            if (a < 0 || a > 500)
            {
                Console.WriteLine(" 'a' must be beetwen 0 and 500 ");
                Console.Write("a = ");
            }
            else
            {
                break;
            }
        }

        Console.Write("b = ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("c = ");
        float c = float.Parse(Console.ReadLine());
        
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}
