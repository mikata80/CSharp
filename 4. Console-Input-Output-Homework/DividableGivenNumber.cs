using System;

class DividableGivenNumber
{
    static void Main()
    {
        Console.Write("start = ");
        int start;
        while (true)
        {
            start = int.Parse(Console.ReadLine());
            if (start < 0)
            {
                Console.WriteLine("Plaese enter start > 0");
                Console.Write("start = ");
            }
            else
            {
                break;
            }

        }
        Console.Write("end = ");
        int end;
        while (true)
        {
            end = int.Parse(Console.ReadLine()); ;
            if (end < 0)
            {
                Console.WriteLine("Plaese enter end > 0");
                Console.Write("end = ");
            }
            else
            {
                break;
            }

        }

        int p = 0;
        for (int i = start; i < end+1; i++)
        {
            if( (i % 5) == 0)
            {
                Console.Write("{0} ",i );
                p++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("p = {0}",p);

    }
}
