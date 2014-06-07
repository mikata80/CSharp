using System;

class BitsInverter
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine()); ;
        int step = int.Parse(Console.ReadLine());
        string nums = "";

        for (int i = n; i > 0; i--)
        {
            long dig = long.Parse(Console.ReadLine());
            nums = nums + ToBin(dig);

        }
        nums = nums.TrimStart();
        char[] newnums = nums.ToCharArray();

        //Console.WriteLine("nums = " + nums);
        if (newnums[0] == '0')
        {
            newnums[0] = '1';
        }
        else
        {
            newnums[0] = '0';
        }
        int a = 0;

        while (a <= newnums.Length)
        {
            a = a + step;
            //Console.WriteLine(a);
            if (a > newnums.Length)
            {
                break;
            }
            else
            {
                // Console.WriteLine("a = " + a);
                if (newnums[a] == '0')
                {
                    newnums[a] = '1';
                }
                else
                {
                    newnums[a] = '0';
                }
            }

        }


        string[] resnums = new string[n];

        int count = 0;
        int ind = 0;
        string nrestr = "";
        for (int i = 0; i < newnums.Length; i++)
        {
            nrestr = nrestr + newnums[i].ToString();
            count++;
            if (count == (newnums.Length/n))
            {
                resnums[ind] = nrestr;
                nrestr = "";
                ind ++;
                count = 0;
            }
        }

        foreach (var item in resnums)
        {
            Console.WriteLine(ToDec(item));
        }


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
