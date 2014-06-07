
using System;

class MissCat
{
    static void Main()
    {
        Console.Write("Enter juri = ");
        int juri = int.Parse(Console.ReadLine());
        int[] cat = new int[11];

        int bestcat = 0;
        int bestvote = 0;

        for (int i = 1; i <= juri; i++)
        {
            
            mp:
            Console.Write("Person number {0}, enter the best cat's number = ",i);
            byte vote = byte.Parse(Console.ReadLine());
            if (vote <= cat.Length-1)
            {
               cat[vote]++;
            }
            else
            {
                Console.WriteLine("Please reenter cat's number, there is no cat's number = {0}", vote);
                goto mp;
            }
           
        }

        for (int i = 1; i <= cat.Length-1; i++)
        {
            if (cat[i] > bestvote)
            {
                bestcat = i;
                bestvote = cat[i];
            }

        }

        Console.WriteLine("Best cat: {0}", bestcat);
        Console.WriteLine("Votes: {0}", bestvote);

    }
}
