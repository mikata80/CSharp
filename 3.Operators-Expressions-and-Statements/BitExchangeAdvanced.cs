using System;
class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());

        Console.Write("p =  ");
        int pp = int.Parse(Console.ReadLine());

        Console.Write("q =  ");
        int qq = int.Parse(Console.ReadLine());

        Console.Write("k =  ");
        int k = int.Parse(Console.ReadLine());
        int q = 0;

        int r;
        if (pp > qq)
        {
            r = pp - qq;
        }
        else
        {
            r = qq - pp;
        }

        uint pbit;
        uint qbit;
        uint pmask;
        uint qmask;
        uint mask;
        int flag = 0;

        Console.WriteLine("Before exchanges bits");
        Console.WriteLine("n = {0} =  {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine("--------------------------");

        for (int p = pp; p <= (pp + (k - 1)); p++)
        {

            int maxp = pp + (k - 1);


            if (pp > qq)
            {
                q = p - r;
            }
            else
            {
                q = p + r;
            }

            if (maxp == q)
            {
                ++flag;
                break;
            }

            pbit = (n >> p) & 1;
            qbit = (n >> q) & 1;

            //Console.WriteLine("p = {0}, q= {1}, pbit({0}) = {2}, qbit({1}) = {3}", p, q, pbit, qbit);
            // /* 
            if ((pbit == 0 && qbit == 0) || (pbit == 1 && qbit == 1))
            {
                ; ;
            }
            else
            {

                if (pbit == 1)
                {
                    n = n & ~(1u << p);
                    pmask = (pbit << q);
                }
                else
                {
                    pmask = ~(qbit << q);
                }

                if (qbit == 1)
                {
                    n = n & ~(1u << q);
                    qmask = (qbit << p);
                }
                else
                {
                    qmask = ~(pbit << p);
                }

                mask = pmask & qmask;

                //Console.WriteLine("pmask =  {0}", Convert.ToString(pmask, 2).PadLeft(32, '0'));
                // Console.WriteLine("qmask =  {0}", Convert.ToString(qmask, 2).PadLeft(32, '0'));
                // Console.WriteLine("mask =  {0}", Convert.ToString(mask, 2).PadLeft(32, '0'));
                // Console.WriteLine("n({0}) =  {1}", n, Convert.ToString(n | mask, 2).PadLeft(32, '0'));
                //Console.WriteLine("n({0}) =  {1}", n, Convert.ToString(n | jmask, 2).PadLeft(32, '0'));
                n = n | mask;
                //Console.WriteLine(n);
                //Console.WriteLine("-------------------------"); 
            } // */
            //Console.WriteLine("n(new) =  {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

        }

        if (flag < 1)
        {
            Console.WriteLine("After exchanges bits");
            Console.WriteLine("n = {0} =  {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));
        }
        else
        {
            Console.WriteLine("overlapping");
        }

    }
}

