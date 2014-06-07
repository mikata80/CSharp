using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("n = ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("n = {0} -> {1}", n, (n / 100 % 10 == 7));

        /* auto check*/
        /* int[] n = new int[6] { 5, 701, 9703, 877, 777877, 9999799 };

        for (int i = 0; i < 6; i++)
        {

            Console.WriteLine("n = {0} -> {1}", n[i], (n[i] / 100 % 10 == 7));
        }
        */


    }
}
