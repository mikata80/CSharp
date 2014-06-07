using System;

class Eclipse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int wight = (n * 5)-1 ;

        for (int rows = 0; rows < n; rows++)
        {
            for (int col = 0; col < wight; col++)
            {

                if ((rows == 0 || rows == n - 1) && col > 0 && (col < n * 2 - 1 || col > n * 2 + n - 1) && col < wight - 1)
                {
                    Console.Write('*');
                }
                else if ((rows == 0 || rows == n - 1) && col >= n * 2 - 1 && col <= n * 2 + n - 1)
                {
                    Console.Write(' ');
                }
                else if ((rows == 0 || rows == n - 1) && (col == 0 || col == wight-1))
                {
                    Console.Write(' ');
                }
                else if ((rows > 0 || rows < n - 1) && (col == n * 2-1 || col == n * 2 + n - 1 || col == 0 || col == wight -1))
                {

                    Console.Write('*');

                }
                else if ((rows > 0 || rows < n - 1) && rows != n/2  &&  (col >= n * 2 && col < n * 2 + n - 1) )
                {
                    Console.Write(' ');
                }
                else if (rows == n / 2 && col > n * 2 - 1 && col <= n * 2 + n - 1)
                {
                    Console.Write('-');
                }
                else
                {
                    Console.Write('/');
                }



            }
            Console.WriteLine();
        }
    }
}
