using System;

class BitSifting
{
    static void Main()
    {
        ulong initial = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;

        if (n > 0)
        {
            ulong[] sieves = new ulong[n];

            for (int i = 0; i < n; i++)
            {
                sieves[i] = ulong.Parse(Console.ReadLine());
            }


            ulong[] res = new ulong[sieves.Length];

            for (int i = 0; i < sieves.Length; i++)
            {
                res[i] = (initial ^ sieves[i]) & initial;
            }


            if (n == 1)
            {
                ulong result = res[0];
                char[] strinitial = ToBin(result).ToCharArray();

                for (int i = 0; i < strinitial.Length; i++)
                {
                    if (strinitial[i] == '1')
                    {
                        cnt++;
                    }
                }
            }
            else
            {
                ulong a = res[0];
                for (int i = 1; i < res.Length; i++)
                {
                    ulong result = a & res[i];
                    a = result;

                }

                char[] strinitial = ToBin(a).ToCharArray();

                for (int i = 0; i < strinitial.Length; i++)
                {
                    if (strinitial[i] == '1')
                    {
                        cnt++;
                    }
                }

            }
        }
        else
        {
            char[] zeron = ToBin(initial).ToCharArray();
            for (int i = 0; i < zeron.Length; i++)
            {
                if (zeron[i] == '1')
                {
                    cnt++;
                }
            }
        }

        Console.WriteLine(cnt);
    }


    private static string ToBin(ulong n)
    {

        ulong ost;
        string result = "";
        while (n > 0)
        {
            ost = n % 2;
            n /= 2;
            result = ost.ToString() + result;
        }

        return result.PadLeft(8, '0');

    }


}
