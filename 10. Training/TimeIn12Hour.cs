using System;


class TimeIn12Hour
{
    static void Main()
    {

        int hour = int.Parse(Console.ReadLine());

        while ( hour <0 || hour > 12)
        {
            Console.WriteLine("enste hour again ");
            hour = int.Parse(Console.ReadLine());
        }


        int min = int.Parse(Console.ReadLine());
        while (min < 0 || min > 59)
        {
            Console.WriteLine("enste min again ");
            min = int.Parse(Console.ReadLine());
        }

        string meridiam = Console.ReadLine();

        while (meridiam != "AM" && meridiam != "PM")
        {
            Console.WriteLine("enste meridiam ");
            meridiam = Console.ReadLine();
        }

        int addhour = int.Parse(Console.ReadLine());
        while (addhour < 0 || addhour > 23)
        {
            Console.WriteLine("enste addhour again ");
            addhour = int.Parse(Console.ReadLine());
        }

        int addmin = int.Parse(Console.ReadLine());


        while (addmin < 0 || addmin > 59)
        {
            Console.WriteLine("enste addmin again ");
            addmin = int.Parse(Console.ReadLine());
        }




        string time = "01.01.2014 " + Convert.ToString(hour) + ":" + Convert.ToString(min) + " " + meridiam;
        DateTime newtime = new DateTime();
        newtime = Convert.ToDateTime(time);
        newtime = newtime.AddHours(addhour).AddMinutes(addmin);
        if (newtime.Hour > 12)
        {
            meridiam = "PM";
        }
        else
        {
            meridiam = "AM";
        }

        //Console.WriteLine(String.Format("{0:hh:mm}:{1}", newtime, meridiam));
        Console.WriteLine(String.Format("{0:hh:mm:tt}", newtime));

    }
}
