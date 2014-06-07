using System;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Int64 nfak = 1;
        Int64 n2fak = 1;
        Int64 otherfak = 1;

        for (int i = 1; i <= 2 * n; i++)
        {
            n2fak = n2fak * i;
            if (i <= n)
            {
                nfak = nfak * i;
                otherfak = otherfak * (i + 1);
            }
        }
        Int64 res = n2fak / (otherfak * nfak);
        Console.WriteLine(res);
    }
}
