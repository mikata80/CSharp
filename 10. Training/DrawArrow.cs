using System;

class DrawArrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int size = n * 2 - 1;

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {

                if (row == 0 && col >= n / 2 && col < size - n / 2)
                {
                    Console.Write('#');
                }
                else if ((row > 0 && row <= (size / 2)) && (col == n / 2 || col == (size - n / 2) - 1))
                {
                    Console.Write('#');
                }
                else if (row == n - 1 && (col <= n / 2 || col >= (size - n / 2) - 1))
                {
                    Console.Write('#');
                }
                else if (row > size / 2 && col == (row - size / 2))
                {
                    Console.Write('#');
                }
                else if (row > size / 2 && col == (size + n / 2 - row) + n / 2 - 1)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write('.');
                }

            }

            Console.WriteLine();
        }
    }
}
