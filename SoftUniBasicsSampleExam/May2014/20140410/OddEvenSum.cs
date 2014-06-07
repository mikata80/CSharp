using System;

class OddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int size = n * 2;
        //double[] arr = new double[8] { 3, 4, -1, -1, 2, 1, 1, 1 };
        double[] arr = new double[size];

        for (int i = 0; i < size; i++)
        {
            arr[i] = double.Parse(Console.ReadLine());
        }


        double oddsum = 0d;
        double evensum = 0d;

        for (int i = 0; i < size; i++)
        {
            if( (i%2) == 0)
            {
                oddsum = oddsum + arr[i];
            }
            else
            {
                evensum = evensum + arr[i];
            }
        }


        if (oddsum == evensum)
        {
            Console.WriteLine("Yes, sum=" + oddsum);
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(oddsum-evensum));    
        }
        
    }
}
