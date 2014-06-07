using System;
class MinMaxSumAvgNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        decimal n = decimal.Parse(Console.ReadLine());
        int a = 0;
        int b = 0;
        int min = 0 ;
        int max = 0;
        decimal sum = 0m;
        decimal avg = 0.0m;

        do
        {
            if (a < n)
            {
                Console.Write("");
                b = int.Parse(Console.ReadLine());
                sum = sum + b;
                if (b > max)
                {
                   max = b;
                }
                else
                {
                  min = b;      
                }
                a++;
            }
        } while (a<n);

        avg = Convert.ToDecimal(sum / n);
        Console.WriteLine("min = {0}",min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}",avg);

        for (int i = 0; i < 255; i++)
        {
            Console.WriteLine(" {0} = {1}",i,(char)i);
        }
    }
}
