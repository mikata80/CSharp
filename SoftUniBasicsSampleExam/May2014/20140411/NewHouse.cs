using System;
class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int size = n + n / 2 + 1;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < n; col++)
            {

                if (row == 0 && col == n / 2)
                {
                    Console.Write('*');
                }
                else if (row > 0 && row < n / 2 && (col >= n / 2 - row && col <= n / 2 + row)) // left
                {
                    Console.Write('*');
                }
                else if (row == n / 2) // 
                {
                    Console.Write('*');
                }
                else if (row > n / 2 && (col == 0 || col == n - 1)) // 
                {
                    Console.Write('|');
                }
                else if (row > n / 2 && (col != 0 || col != n - 1)) // 
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
