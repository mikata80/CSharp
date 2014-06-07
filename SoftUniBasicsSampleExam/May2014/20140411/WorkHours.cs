using System;

class WorkHours
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double result = 0d;

        double efworkhours = (d - d * 0.1) * 12;
        int productivity = (int)((efworkhours * p) / 100);
        result = h - productivity;
        if (result > 0)
        {
            result = result * -1;
            Console.WriteLine("No");
            Console.WriteLine(result);
        }
        else
        {
            result = result * -1;
            Console.WriteLine("Yes");
            Console.WriteLine(result);
        }

    }
}
