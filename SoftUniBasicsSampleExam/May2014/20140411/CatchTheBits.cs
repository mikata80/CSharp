using System;

class CatchTheBits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        long[] arr = new long[n];
        string big = "";

        for (int i = 0; i < n; i++)
        {
            arr[i] = long.Parse(Console.ReadLine());
            big = big + ToBin(arr[i]);
        }
        string newbig = big.TrimStart();
        char[] arrbits = newbig.ToCharArray();

        string newseq = arrbits[1].ToString();

        int a = 1;
        while (a <= arrbits.Length)
        {
            a = a + step;
            //Console.WriteLine(a);
            if (a >= arrbits.Length)
            {
                break;
            }
            else
            {
                newseq = newseq + arrbits[a];

            }

        }


        string resseq = "";
        if (newseq.Length < 8)
        {
            resseq = newseq.PadRight(8, '0');
        }
        else if (newseq.Length < newseq.Length + newseq.Length % 8)
        {
            resseq = newseq.PadRight((newseq.Length + newseq.Length % 8), '0');
        }
        else
        {
            resseq = newseq;
        }

        string todec = "";
        if (resseq.Length > 8)
        {
            char[] lastres = resseq.ToCharArray();


            int cnt = 0;

            for (int i = 0; i < lastres.Length; i++)
            {

                if (cnt < 8)
                {
                    todec = todec + lastres[i];
                    cnt++;
                }
                else
                {
                    cnt = 0;
                    Console.WriteLine(ToDec(todec.TrimStart()));
                    todec = "";
                    todec = todec + lastres[i];
                    cnt++;
                }

            }

        }
        else
        {
            todec = resseq;
        }


        Console.WriteLine(ToDec(todec.TrimStart()));


    }


    private static string ToBin(long n)
    {

        long ost;
        string result = "";
        while (n > 0)
        {
            ost = n % 2;
            n /= 2;
            result = ost.ToString() + result;
        }

        return result.PadLeft(8, '0');

    }

    private static long ToDec(string item)
    {
        string a;
        long dec = 0;

        for (int i = 1; i <= item.Length; i++)
        {
            a = item.Substring(item.Length - i, 1);
            dec = dec + Convert.ToInt64(Convert.ToInt64(a) * Math.Pow(2, (i - 1)));
        }

        return (dec);
    }

}
