using System;

class StringsObjects
{
    static void Main()
    {
        string hello = "HELLO";
        string world = "WORLD";
        object mp = hello + " " + world;
        string last = Convert.ToString(mp);
        Console.WriteLine(last);
    }
}
