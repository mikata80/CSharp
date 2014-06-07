using System;

class OddandEvenProduct
{
    static void Main()
    {

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        string all;
        Console.WriteLine("Entred {0} numbers separated with space:", n);
        all = Console.ReadLine();

        int i = 0;
        int a = 0;
        int oddprod = 1;
        int evenprod = 1;

        while (i < n)
        {
            a = Convert.ToInt32(all.Split(' ')[i]);

            if ((i % 2) == 0)
            {
                oddprod = oddprod * a;
            }
            else
            {
                evenprod = evenprod * a;
            }

            i++;
        }

        if (oddprod == evenprod)
        {
            Console.WriteLine("yes \nproduct = {0}", oddprod);
        }
        else
        {
            Console.WriteLine("no \nodd_product = {0} \neven_product = {1}  ", oddprod, evenprod);
        }

    }
}