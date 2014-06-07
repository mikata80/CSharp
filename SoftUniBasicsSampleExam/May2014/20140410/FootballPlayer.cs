using System;
class FootballPlayer
{
    static void Main()
    {
        //input
        string isleap = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());//hollydays
        int h = int.Parse(Console.ReadLine());//weekends in home town

        decimal normalplays = (52 - h) * 2 / 3;
        decimal hdplays = p / 2;

        //logic

        int leap = 0;
        if (isleap == "t")
        {
            leap = 3;
        }

        decimal result = normalplays + hdplays + leap + h;

        //output
        Console.WriteLine("{0:F0}", result);

    }
}
