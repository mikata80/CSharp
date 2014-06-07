using System;
class PrintDeckof52Cards
{
    static void Main()
    {
        for (int i = 2; i < 30; i++)
        {
            if (i < 11)
            {

                for (int j = 3; j < 7; j++)
                {
                    Console.Write("{0}{1} ", i, (char)j);
                }

                Console.WriteLine();
            }
            else
            {

                switch (i)
                {
                    case 11: Console.Write("J{0} ", (char)3); break;
                    case 12: Console.Write("J{0} ", (char)4); break;
                    case 13: Console.Write("J{0} ", (char)5); break;
                    case 14: Console.Write("J{0} ", (char)6); break;

                    case 15: Console.WriteLine(); break;

                    case 16: Console.Write("Q{0} ", (char)3); break;
                    case 17: Console.Write("Q{0} ", (char)4); break;
                    case 18: Console.Write("Q{0} ", (char)5); break;
                    case 19: Console.Write("Q{0} ", (char)6); break;

                    case 20: Console.WriteLine(); break;

                    case 21: Console.Write("K{0} ", (char)3); break;
                    case 22: Console.Write("K{0} ", (char)4); break;
                    case 23: Console.Write("K{0} ", (char)5); break;
                    case 24: Console.Write("K{0} ", (char)6); break;

                    case 25: Console.WriteLine(); break;

                    case 26: Console.Write("A{0} ", (char)3); break;
                    case 27: Console.Write("A{0} ", (char)4); break;
                    case 28: Console.Write("A{0} ", (char)5); break;
                    case 29: Console.Write("A{0} ", (char)6); break;
                }
            }
        }
        Console.WriteLine();
    }
}
