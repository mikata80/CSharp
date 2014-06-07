using System;
class CheckBitGivenPosition
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        int res = ((n >> p) & 1);

        Console.WriteLine(Convert.ToString(n, 2).PadLeft(16, '0'));
        //Console.WriteLine(Convert.ToString(p, 2).PadLeft(16, '0'));
        Console.WriteLine(Convert.ToString(((n >> p) & 1), 2).PadLeft(16, '0'));
        Console.WriteLine(Convert.ToString(res, 2).PadLeft(16, '0'));

        Console.WriteLine(res == 1 ? true : false);
    }
}
