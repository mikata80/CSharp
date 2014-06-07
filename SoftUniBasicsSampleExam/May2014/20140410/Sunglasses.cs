using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());



        for (int rows = 0; rows < n; rows++)
        {
            for (int col = 0; col < n * 5; col++)
            {

                if ((rows == 0 || rows == n - 1) && (col <= (n * 2) - 1 || col > n * 2 + n))
                {
                    Console.Write('*');
                }
                else if (((rows == 0 || rows == n - 1)) && (col > n * 2) && (col <= n * 2 + n))
                {
                    Console.Write(' ');
                }
                else if (rows >= 1 && rows < n - 1 && (col <= (n * 2) - 1 || col > n * 2 + n))
                {
                    if (col == 0 || col == (n * 2) - 1 || col == n * 2 + n + 1)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('/');
                    }

                }
                else if (rows == n / 2 && (col > n * 2) && (col <= n * 2 + n))
                {
                    Console.Write('|');
                }
                else if ((rows >= 1 && rows < n - 1) && (col > n * 2) && (col <= n * 2 + n))
                {
                    Console.Write(' ');
                }


            }

            Console.WriteLine('*');
        }
    }
}
