using System;

class SumOfElements
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] arr = input.Split(' ');


        int sum = 0;
        int max = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int a = Convert.ToInt32(arr[i]);

            if (a > max)
            {
                max = a;
            }
            sum = sum + Convert.ToInt32(arr[i]);
        }

        int diff = sum - max;

        if (max - diff == 0)
        {
            Console.WriteLine("Yes, sum={0}",max);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(max - diff));
        }

    }
}
