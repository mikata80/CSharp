using System;
class PrintASCIITable
{
    static void Main()
    {
        

        Console.WriteLine("No.  ASCII");
        for (int i = 0; i < 256; i++)
        {
            Console.WriteLine(@"{0}    {1}", i, (Convert.ToChar(i)));
        }
    }
}
