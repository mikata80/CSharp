using System;

class RandomizetheNumbers1N
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers;
        numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] =(i+1);
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        Random rnd = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            var rndMember = numbers[rnd.Next(numbers.Length)];
            Console.Write(rndMember + " ");
        }

        Console.WriteLine();
    }
}
