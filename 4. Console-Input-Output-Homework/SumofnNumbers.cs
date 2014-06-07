using System;
class SumofnNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());;
        double a;
        double sum = 0;

        Console.WriteLine("Enter {0} numbers: ",n);
        for (int i = 1; i < n + 1; i++)
        {
            a = double.Parse(Console.ReadLine());
            sum = a + sum;
        }

        Console.WriteLine("sum = {0}",sum);
    }
}
