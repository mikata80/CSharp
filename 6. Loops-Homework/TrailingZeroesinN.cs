using System;
class TrailingZeroesinN
{
    static void Main()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        int cnt = 0;
        long a = 1;

        for (int i = 1; i <= n; i++)
        {
             a = a * i;
        }
        long nfak = a;

        while (a > 0)
        {
            if ((a % 10) == 0)
            {
                cnt++;
            }
            else if (((a % 10) != 0))
            {
                break;
            }
            a = a / 10;
        }

        Console.WriteLine("trailing zeroes of {0}! = {1}",n,cnt);
        Console.WriteLine("{0}! = {1}", n, nfak);
    }
}
