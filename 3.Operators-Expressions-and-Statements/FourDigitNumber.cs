using System;

class FourDigitNumber
{
    static void Main()
    {
       
        Console.Write("n = ");
        int n;

        while (true)
        {
            n = Convert.ToInt32(Console.ReadLine());

            if (((n / 1000) % 10) == 0)
            {
                Console.WriteLine("Try again. Cannot start with 0 !");
                Console.Write("n = ");
            }
            else
            {
                break;
            }
        }

    
        int a = (n / 1000) % 10;
        int b = (n / 100) % 10;
        int c = (n / 10) % 10;
        int d = n % 10;

        
        Console.WriteLine("sum(abcd)= {0}", a+b+c+d);
        Console.WriteLine("dcba - > {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("dabc - > {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("acbd - > {0}{1}{2}{3}", a, c, b, d);


    }



}
