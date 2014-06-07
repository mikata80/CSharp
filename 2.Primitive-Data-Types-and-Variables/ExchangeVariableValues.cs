using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c;
        Console.WriteLine("Before exchange: a = {0}, b = {1}", a, b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("Alter exchange: a = {0}, b = {1}", a, b);
    }
}
