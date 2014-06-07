using System;
using System.Collections.Generic;
class JoinLists
{
    static void Main()
    {
        Console.Write("Number of integers for first list: ");
        string line1 = Console.ReadLine();

        Console.Write("Number of integers for second list: ");
        string line2 = Console.ReadLine();

        string[] line1nums = line1.Split(new char[] { ' ', ',' });
        string[] line2nums = line1.Split(new char[] { ' ', ',' });

        int[] line1ints;
        int[] line2ints;




        //int n = int.Parse(Console.ReadLine());
        //List<int> firstlist = new List<int>();
        //List<int> secondlist = new List<int>();

        ////List<int> firstlist = new List<int>() { 20, 40, 10, 10, 30, 80 };
        ////List<int> secondlist = new List<int>() { 25, 20, 40, 30, 10 };

        ////List<int> firstlist = new List<int>() { 5, 4, 3, 2, 1 };
        ////List<int> secondlist = new List<int>() { 6, 3, 2 };

        ////List<int> firstlist = new List<int>() { 1};
        ////List<int> secondlist = new List<int>() { 1};

        //Console.WriteLine("Enter {0} integers for first list:", n);

        //for (int i = 0; i < n; i++)
        //{
        //    firstlist.Add(int.Parse(Console.ReadLine()));
        //}

        //Console.Write("Number of integers for second list: ");
        //n = int.Parse(Console.ReadLine());
        //Console.WriteLine("Enter {0} integers for second list:", n);
        //for (int i = 0; i < n; i++)
        //{
        //    secondlist.Add(int.Parse(Console.ReadLine()));
        //}

        //foreach (var integers in secondlist)
        //{
        //    do
        //    {
        //        firstlist.Remove(integers);
        //    } while (firstlist.Contains(integers));

        //    if (!firstlist.Contains(integers))
        //    {
        //        firstlist.Add(integers);
        //    }
        //}

        //firstlist.Sort();

        //Console.WriteLine();

        //foreach (var item in firstlist)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
