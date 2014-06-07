using System;

class SubsetSums
{
    static void Main()
    {
        //input
        long snum = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        while (n == 0)
        {
            Console.WriteLine("Enter n > 0 ");
            n = int.Parse(Console.ReadLine());
        }

        long[] arr = new long[n];// {-2,-1,1,2,3};

        //logic

        for (int i = 0; i < n; i++)
        {
            long num = long.Parse(Console.ReadLine());
            arr[i] = num;
        }

        int cnt = 0;
        if (n == 1)
        {
            cnt = 1;
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (((arr[i] + arr[j]) == snum))
                {
                    cnt++;
                }

            }

        }
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 1; j < n; j++)
        //    {
        //        if (((arr[i] + arr[j] + arr[n - (n - j)]) == snum))
        //        {
        //            cnt++;
        //        }

        //    }

        //}

        //output
        Console.WriteLine(cnt);
        
    }
}
