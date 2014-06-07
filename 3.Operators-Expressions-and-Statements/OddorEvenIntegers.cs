using System;
class OddorEvenIntegers
{
    static void Main()
    {
        int n = 3;
        int a = (n % 2);

        Console.WriteLine(a != 0);
        n = 2;
        a = (n % 2);
        Console.WriteLine(a != 0);
        n = -2;
        a = (n % 2);
        Console.WriteLine(a != 0);
        n = -1;
        a = (n % 2);
        Console.WriteLine(a != 0);
        n = 0;
        a = (n % 2);
        Console.WriteLine(a != 0);

    }
}
