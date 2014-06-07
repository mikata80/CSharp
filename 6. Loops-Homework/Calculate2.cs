using System;
class Calculate2
{
    static void Main()
    {
        //Problem 6.	Calculate N! / K!

        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("k = ");
        long k = long.Parse(Console.ReadLine());

        long nfak = 1;
        long kfak = 1;

        for (int i = 1; i <= n; i++)
        {
            nfak = nfak * i;

            if ((1 < k) && (k < n) && (n < 100) && (i <= k))
            {
                kfak = kfak * i;
            }
        }
        Console.WriteLine("{0}!/{1}! = {2}", n, k, nfak / kfak);
    }
}
