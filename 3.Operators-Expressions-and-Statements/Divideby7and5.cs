using System;

class Divideby7and5
{
    static void Main()
    {
        Console.Write("a = ");
        int a = Convert.ToInt32(Console.ReadLine());

        if (a == 0)
        {
            a++;
        }
        Console.WriteLine("{0} - {1}", a, Convert.ToString((a % 5) == 0 && (a % 7) == 0));
        /*  for (int i = 1; i < 1000; i++)
          {

              if ( ( (i % 5) == 0 && (i % 7) == 0) )
              {
                  Console.WriteLine("{0}. - {1}", i, Convert.ToString((i % 5) == 0 && (i % 7) == 0));        
              }
            
          }*/

    }
}
