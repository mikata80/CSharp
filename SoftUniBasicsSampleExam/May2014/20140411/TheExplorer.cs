using System;
class TheExplorer
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int rows = 0; rows < n; rows++)
        {
            for (int col = 0; col < n; col++)
            {

                if ((rows == 0 || rows == n - 1) && col == n / 2)
                {
                    Console.Write('*');
                }
                else if ((rows > 0 && rows < n / 2) && (col == (n / 2) - rows || col == (n / 2) + rows))
                {
                    Console.Write('*');
                }
                else if ((rows > n / 2 && rows < n - 1) && col == rows - n / 2)
                {
                    Console.Write('*');
                }
                else if ((rows > n / 2 && rows < n - 1) && col == n - rows - 1 + n / 2)
                {
                    Console.Write('*');
                }
                else if ((rows == n / 2) && (col == 0 || col == n - 1))
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('-');
                }

            }

            Console.WriteLine();
        }
    }
}
