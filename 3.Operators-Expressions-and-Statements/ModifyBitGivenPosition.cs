using System;
class ModifyBitGivenPosition
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());
        int bit = ((n >> p) & 1);
        int mask;

        //Console.WriteLine("bin n = {0}", Convert.ToString(n, 2).PadLeft(16, '0'));
        //Console.WriteLine(Convert.ToString(Convert.ToInt16(mask), 2).PadLeft(16, '0'));
        //Console.WriteLine("bin bit = {0}", Convert.ToString(bit, 2).PadLeft(16, '0'));
        //Console.WriteLine("bit = {0}", bit);


        if (bit == 1)
        {
            if (v == 0)
            {
                mask = ~(1 << p);
                //Console.WriteLine("bin mask =  {0}", Convert.ToString(Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                //Console.WriteLine("mask =  {0}", mask);
                Console.WriteLine("result =  {0}", n & mask);
            }
            else if (v == 1)
            {
                mask = ~(0 << p);
                Console.WriteLine("result =  {0}", n & mask);
            }
        }
        else if (bit == 0)
        {
            mask = ~(1 << p);
            Console.WriteLine("result =  {0}", n & mask);

        }





        /*


                if (bit == 1 && v == 0)
                {
                    mask = ~(1 << p);
                    Console.WriteLine("bin mask =  {0}", Convert.ToString(Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                    Console.WriteLine("mask =  {0}", mask);
                    Console.WriteLine("(n & mask) =  {0}", n & mask);
                }
                else if (bit == 1 && v == 1)
                {
                    mask = ~(0 << p);

                    //Console.WriteLine("bin mask =  {0}", Convert.ToString(Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                    //Console.WriteLine("bin n xor mask = {0}", Convert.ToString(Convert.ToInt16(n) ^ Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                    //Console.WriteLine("bin n and mask = {0}", Convert.ToString(Convert.ToInt16(n) & Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                    //Console.WriteLine("mask =  {0}", mask);
                    //Console.WriteLine("(n ^ mask) =  {0}", n ^ mask);
                    Console.WriteLine("result =  {0}", n & mask);
                }
                else if (bit == 0 && v == 0)
                {
                    mask = ~(1 << p);
                    //  Console.WriteLine("bin mask =  {0}", Convert.ToString(Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                    // Console.WriteLine("mask =  {0}", mask);
                    Console.WriteLine("result =  {0}", n & mask);
                }
                else if (bit == 1 && v == 0)
                {
                    mask = ~(1 << p);

                    //Console.WriteLine("bin mask =  {0}", Convert.ToString(Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                    //Console.WriteLine("bin n xor mask = {0}", Convert.ToString(Convert.ToInt16(n) ^ Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                    //Console.WriteLine("bin n and mask = {0}", Convert.ToString(Convert.ToInt16(n) & Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                    //Console.WriteLine("mask =  {0}", mask);
                    Console.WriteLine("result =  {0}", n & mask);
                }

                //Console.WriteLine(Convert.ToString(Convert.ToInt16((v << p)), 2).PadLeft(16, '0'));
                //Console.WriteLine(Convert.ToString(Convert.ToInt16(~(1 << p)), 2).PadLeft(16, '0'));


                //Console.WriteLine(v << p);



                //Console.WriteLine(Convert.ToString(Convert.ToInt16(mask), 2).PadLeft(16, '0'));
                //onsole.WriteLine(Convert.ToString(n & mask, 2).PadLeft(16, '0'));



                //Console.WriteLine(n & ~(v << p));
                //Console.WriteLine(v);

                //Console.WriteLine("result = {0}", bit == 1? (n & (~(v << p))) : (n ^ (v << p)) );

                //int mask = ~(1 << p);
                //int res = ((n >> p));

                //Console.WriteLine(Convert.ToString(n,2).PadLeft(16, '0'));

                //Console.WriteLine(Convert.ToString(n & mask, 2).PadLeft(16, '0'));
                //Console.WriteLine("result = {0}",res);
                //Console.WriteLine(n & mask);

        */

    }
}
