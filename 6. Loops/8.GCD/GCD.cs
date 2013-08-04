using System;
    class GCD
    {
        static void Main()
        {

            Console.WriteLine("Enter two positive numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
                while (a > b || b > a)
                {
                    while ((a - b) > 0)
                    {
                        a = a - b;

                    }
                    while ((b - a) > 0)
                    {
                        b = b - a;
                    }
                }
                Console.WriteLine("GCD = {0}", a);
        }
    }
