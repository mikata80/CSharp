using System;
class PlayIntDoubleString
{
    static void Main()
    {
        Console.Write("Please choose a type: \n 1 --> int \n 2 --> double \n 3 --> string \n");
        int type = int.Parse(Console.ReadLine());

        if (type <= 2)
        {
            Console.Write("Please enter a {0}:", type == 1 ? "int" : "doube");
            if (type == 1)
            {
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
            }
            else
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
            }
        }
        else
        {
            Console.Write("Please enter a string: ");
            string a = Console.ReadLine();
            Console.WriteLine(a + "*");
        }
    }
}
