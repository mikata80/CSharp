using System;

class Forest
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int map = 2 * n - 1;

        for (int row = 0; row < map; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row == col)
                {
                    Console.Write('*');
                }
                else if (row == map-col-1)
                {
                    Console.Write('*');
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
