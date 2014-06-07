using System;
class Calculate3
{
    static void Main()
    {
        //Problem 7.	Calculate N! / (K! * (N-K)!)

        Console.Write("n = ");
        long n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        long k = int.Parse(Console.ReadLine());

        long nfak = 1;
        long kfak = 1;
        long nkfak = 1;

        for (int i = 1; i <= n; i++)
        {
            nfak = nfak * i;

            if ((1 < k) && (k < n) && (n < 100) && (i <= k))
            {
                kfak = kfak * i;
            }

            if (i <= (n - k))
            {
                nkfak = nkfak * i; 
            }
        }

        Console.WriteLine("{0}! / ( {1}!*({0}-{1})! ) = {2}", n, k, (nfak / (kfak * nkfak)));
    }
}
