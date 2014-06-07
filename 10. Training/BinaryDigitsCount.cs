using System;
class BinaryDigitsCount
{
    static void Main()
    {
        int b = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int cnt = 0;

        while (n == 0)
        {
            Console.WriteLine("Enter n > 0 ");
            n = int.Parse(Console.ReadLine());
        }
            

        for (int i = 0; i < n; i++)
        {
            long num = long.Parse(Console.ReadLine());

            while (num > 0)
            {
                if (num % 2 == b)
                {
                    cnt++;
                }
                num /= 2;
            }

            Console.WriteLine(cnt);
            cnt = 0;
        }

        Console.WriteLine();
    }
}
