﻿using System;
class NumbersNotDivisibleby3and7
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i < n + 1; i++)
        {
            if ((i % 3) != 0 && (i % 7) != 0)
            {
                Console.Write("{0} ", i);
            }
        }

        Console.WriteLine();
    }
}
