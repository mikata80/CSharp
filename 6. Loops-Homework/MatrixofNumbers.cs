using System;
class MatrixofNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        if (n > 20)
        {
            Console.WriteLine("n must be <= 20. Try again!");
        }
        else
        {
            Console.WriteLine("matrix");
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < (i + n); j++)
                {

                    if (Convert.ToString(j).Length < 2)
                    {
                        Console.Write("  " + j );
                    }
                    else
                    {
                        Console.Write(" " + j );
                    }

                }

                Console.WriteLine();
            }
        }

    }
}
