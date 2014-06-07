using System;
class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        //nt n = 2369124121;

        uint ibit;
        uint jbit;
        uint imask;
        uint jmask;
        uint mask;

        Console.WriteLine("Before exchanges bits 3, 4 and 5 with bits 24, 25 and 26");
        Console.WriteLine("n = {0} =  {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));

        Console.WriteLine("--------------------------");
        for (int i = 3; i <= 5; i++)
        {
            int j = i + 21;
            ibit = (n >> i) & 1;
            jbit = (n >> j) & 1;

            //Console.WriteLine("i = {0}, j= {1}, ibit({0}) = {2}, jbit({1}) = {3}", i, j, ibit, jbit);


            if ((ibit == 0 && jbit == 0) || (ibit == 1 && jbit == 1))
            {
                Console.WriteLine();
            }
            else
            {

                if (ibit == 1)
                {
                    n = n & ~(1u << i);
                    imask = (ibit << j);
                }
                else
                {
                    imask = ~(jbit << j);
                }

                if (jbit == 1)
                {
                    n = n & ~(1u << j);
                    jmask = (jbit << i);
                }
                else
                {
                    jmask = ~(ibit << i);
                }

                mask = imask & jmask;

                /*Console.WriteLine("imask =  {0}", Convert.ToString(imask, 2).PadLeft(32, '0'));
                Console.WriteLine("jmask =  {0}", Convert.ToString(jmask, 2).PadLeft(32, '0'));
                Console.WriteLine("mask =  {0}", Convert.ToString(mask, 2).PadLeft(32, '0'));
                Console.WriteLine("n({0}) =  {1}", n, Convert.ToString(n | mask, 2).PadLeft(32, '0'));*/
                //Console.WriteLine("n({0}) =  {1}", n, Convert.ToString(n | jmask, 2).PadLeft(32, '0'));
                n = n | mask;
                //Console.WriteLine(n);
                //Console.WriteLine("-------------------------"); 
            }
            //Console.WriteLine("n(new) =  {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

        }

        Console.WriteLine("After exchanges bits 3, 4 and 5 with bits 24, 25 and 26");
        Console.WriteLine("n = {0} =  {1}", n, Convert.ToString(n, 2).PadLeft(32, '0'));



    }
}

