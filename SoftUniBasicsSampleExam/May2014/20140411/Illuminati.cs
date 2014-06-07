using System;

class Illuminati
{
    static void Main()
    {
        string input = Console.ReadLine();
        int vowelscnt = 0;
        int vowelssum = 0;
        string newinput = input.ToLower();


        char[] arr = newinput.ToCharArray();

        foreach (var let in arr)
        {
            if (let == 'a')
            {
                vowelssum = vowelssum + 65;
                vowelscnt++;
            }
            else if (let == 'e')
            {
                vowelssum = vowelssum + 69;
                vowelscnt++;
            }
            else if (let == 'i')
            {
                vowelssum = vowelssum + 73;
                vowelscnt++;
            }
            else if (let == 'o')
            {
                vowelssum = vowelssum + 79;
                vowelscnt++;
            }
            else if (let == 'u')
            {
                vowelssum = vowelssum + 85;
                vowelscnt++;
            }

        }

        Console.WriteLine(vowelscnt);
        Console.WriteLine(vowelssum);

    }
}
