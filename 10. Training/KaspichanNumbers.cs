using System;

class KaspichanNumbers
{
    static void Main()
    {
        ulong nn = ulong.Parse(Console.ReadLine());
        string kas = "";

        while (nn!=0)
        {
            ulong n = nn % 256;
            nn = nn / 256;
            //Console.WriteLine(n);
            for (ulong i = 0; i <= n; i++)
            {
                //Console.WriteLine("{0} , {1}",i,n);

                if (i <= 25 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString()) + kas;//Console.WriteLine((Convert.ToChar(i + 65)));
                }
                else if (i > 25 && i <= 51 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString()) + kas;// Console.WriteLine("a"+ (Convert.ToChar((i-26)+65)));    

                }
                else if (i > 52 && i <= 77 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString())+ kas;//Console.WriteLine("b" + (Convert.ToChar((i - 52) + 65)));

                }
                else if (i > 78 && i <= 103 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString()) + kas;//Console.WriteLine("c" + (Convert.ToChar((i - 78) + 65)));

                }
                else if (i > 104 && i <= 129 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString()) + kas;//Console.WriteLine("d" + (Convert.ToChar((i - 104) + 65)));

                }
                else if (i > 130 && i <= 155 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString()) + kas;//Console.WriteLine("e" + (Convert.ToChar((i - 130) + 65)));

                }
                else if (i > 156 && i <= 181 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString()) + kas;//Console.WriteLine("f" + (Convert.ToChar((i - 157) + 65)));

                }
                else if (i > 182 && i <= 208 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString()) + kas;//Console.WriteLine("g" + (Convert.ToChar((i - 183) + 65)));

                }
                else if (i > 209 && i <= 233 && i == n)
                {
                    kas = (Convert.ToChar(i + 65).ToString()) + kas;//Console.WriteLine("g" + (Convert.ToChar((i - 209) + 65)));

                }
                else if (i > 233 && i <= 255 && i == n)
                {
                    kas =  (Convert.ToChar(i + 65).ToString()) + kas;//Console.WriteLine("i" + (Convert.ToChar((i - 233) + 65)));

                }


            }

        }


      
        Console.WriteLine(kas);

        //Console.WriteLine((Convert.ToChar(91)));
        //Console.WriteLine((Convert.ToChar(92)));
        //Console.WriteLine((Convert.ToChar(93)));
        //Console.WriteLine((Convert.ToChar(94)));
        //Console.WriteLine((Convert.ToChar(95)));
        //Console.WriteLine((Convert.ToChar(95)));
    }


}
