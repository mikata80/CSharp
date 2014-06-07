using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());
        int nosub = 1;

        if (a == 0 && b == 0 && c == 0 && d == 0 && e == 0)
        {
            Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0 ");
            nosub = 0;
        }
        else if (true)
        {
            if ((a + b) == 0)
            {
                Console.WriteLine("(a+b) {0} + {1} = {2}", a, b, (a + b));
                nosub = 0;
            }
            if ((a + c) == 0)
            {
                Console.WriteLine("(a+c) {0} +  {1} = {2}", a, c, (a + c));
                nosub = 0;
            }
            if ((a + d) == 0)
            {
                Console.WriteLine("(a+d) {0} + {1} = {2}", a, d, (a + d));
                nosub = 0;
            }
            if ((a + e) == 0)
            {
                Console.WriteLine("(a+e) {0} + {1} = {2}", a, e, (a + e));
                nosub = 0;
            }
            if ((a + b + c) == 0)
            {
                Console.WriteLine("(a+b+c) {0} + {1} + {2}  = {3}", a, b, c, (a + b + c));
                nosub = 0;
            }
            if ((a + b + d) == 0)
            {
                Console.WriteLine("(a+b+d) {0} + {1} + {2}  = {3}", a, b, d, (a + b + d));
                nosub = 0;
            }
            if ((a + b + e) == 0)
            {
                Console.WriteLine("(a+b+e) {0} + {1} + {2}  = {3}", a, b, e, (a + b + e));
                nosub = 0;
            }
            if ((a + c + d) == 0)
            {
                Console.WriteLine("(a+c+d) {0} + {1} + {2}  = {3}", a, c, d, (a + c + d));
                nosub = 0;
            }
            if ((a + c + e) == 0)
            {
                Console.WriteLine("(a+c+e) {0} + {1} + {2}  = {3}", a, c, e, (a + c + e));
                nosub = 0;
            }
            if ((a + d + e) == 0)
            {
                Console.WriteLine("(a+d+e) {0} + {1} + {2}  = {3}", a, d, e, (a + d + e));
                nosub = 0;
            }
            if ((a + b + c + d) == 0)
            {
                Console.WriteLine("(a + b + c + d) {0} + {1} + {2} + {3}  = {4}", a, b, c, d, (a + b + c + d));
                nosub = 0;
            }
            if ((a + b + c + e) == 0)
            {
                Console.WriteLine("(a + b + c + e) {0} + {1} + {2} + {3}  = {4}", a, b, c, e, (a + b + c + e));
                nosub = 0;
            }
            if ((a + c + d + e) == 0)
            {
                Console.WriteLine("(a + c + d + e) {0} + {1} + {2} + {3}  = {4}", a, c, d, e, (a + c + d + e));
                nosub = 0;
            }
            if ((a + b + c + d + e) == 0)
            {
                Console.WriteLine("(a + c + d + e) {0} + {1} + {2} + {3} + {4}  = {5}", a, b, c, d, e, (a + b + c + d + e));
                nosub = 0;
            }
            //////b
            if ((b + c) == 0)
            {
                Console.WriteLine("(b+c) {0} + {1} = {2}", b, c, (b + c));
                nosub = 0;
            }
            if ((b + d) == 0)
            {
                Console.WriteLine("(b+d) {0} + {1} = {2}", b, d, (b + d));
                nosub = 0;
            }
            if ((b + e) == 0)
            {
                Console.WriteLine("(b+e) {0} + {1} = {2}", b, e, (b + e));
                nosub = 0;
            }
            if ((b + c + d) == 0)
            {
                Console.WriteLine("(b+c+d) {0} + {1} + {2} = {3}", b, c, d, (b + c + d));
                nosub = 0;
            }
            if ((b + c + e) == 0)
            {
                Console.WriteLine("(b+c+e) {0} + {1} + {2} = {3}", b, c, e, (b + c + e));
                nosub = 0;
            }
            if ((b + d + e) == 0)
            {
                Console.WriteLine("(b+d+e) {0} + {1} + {2} = {3}", b, d, e, (b + d + e));
                nosub = 0;
            }
            if ((b + c + d + e) == 0)
            {
                Console.WriteLine("(b+c+d+e) {0} + {1} + {2} + {3} = {4}", b, c, d, e, (b + c + d + e));
                nosub = 0;
            }
            /////c
            if ((c + d) == 0)
            {
                Console.WriteLine("(c+d) {0} + {1} = {2}", c, d, (c + d));
                nosub = 0;
            }
            if ((c + e) == 0)
            {
                Console.WriteLine("(c+e) {0} + {1} = {2}", c, e, (c + e));
                nosub = 0;
            }
            if ((c + d + e) == 0)
            {
                Console.WriteLine("(c+d+e) {0} + {1} + {2} = {3}", c, d, e, (c + d + e));
                nosub = 0;
            }
            /////d
            if ((d + e) == 0)
            {
                Console.WriteLine("(d+e) {0} + {1} = {2}", d, e, (d + e));
                nosub = 0;
            }
        }

        if (nosub == 1)
        {
            Console.WriteLine("no zero subset");
        }

    }
}
