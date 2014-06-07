using System;

class DifferenceBetDates
{
    static void Main()
    {
        Console.Write("Enter first date (dd.mm.yyyy): ");
        DateTime fdate = new DateTime();
        //fdate = DateTime.Parse(Console.ReadLine());
        fdate = DateTime.ParseExact(Console.ReadLine(),"dd.mm.yyyy", null);
        Console.Write("Enter second date (dd.mm.yyyy): ");
        DateTime sdate = new DateTime();
        //sdate = DateTime.Parse(Console.ReadLine());
        sdate = DateTime.ParseExact(Console.ReadLine(), "dd.mm.yyyy", null);
        //DateTime fdate = new DateTime();
        //fdate = DateTime.Now;
        //DateTime sdate = new DateTime();
        //sdate = DateTime.Now;
        //sdate = sdate.AddDays(44);
        //Console.WriteLine((fdate.Day-sdate.Day));

        Console.WriteLine(fdate <= sdate ? Math.Abs((fdate - sdate).Days).ToString() : (sdate - fdate).Days.ToString());
    }
}
