using System;

class CrossingSequences
{
    static void Main()
    {
        long tribostart1 = long.Parse(Console.ReadLine());
        long tribostart2 = long.Parse(Console.ReadLine());
        long tribostart3 = long.Parse(Console.ReadLine());
        long[] triboseq = new long[100000];
        triboseq[0] = tribostart1;
        triboseq[1] = tribostart2;
        triboseq[2] = tribostart3;
        bool res = false;


        long spiralstart = long.Parse(Console.ReadLine());
        long spiralstep = long.Parse(Console.ReadLine());
        long[] spitalseq = new long[100000];

        for (int i = 0; i < spitalseq.Length; i++)
        {
            if (i == 0)
            {
                spitalseq[i] = spiralstart;
            }
            else
            {
                spitalseq[i] = spitalseq[i - 1] + spiralstep;
            }

            if (i < 2 && (spitalseq[i] == triboseq[i]))
            {
                res = true;
            }


            if (i > 2)
            {
                long tribxum = triboseq[i - 1] + triboseq[i - 2] + triboseq[i - 3];
                triboseq[i] = tribxum;
            }


            for (int j = 0; j < i; j++)
            {
                if (spitalseq[i] == triboseq[j])
                {

                    res = true;

                }

            }

            if (res == true)
            {
                Console.WriteLine(spitalseq[i]);
                break;
            }

        }
        if (res != true)
        {
            Console.WriteLine("No");
        }



    }
}
