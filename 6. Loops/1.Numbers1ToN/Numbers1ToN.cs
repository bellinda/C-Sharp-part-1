using System;
    class Numbers1ToN
    {
        static void Main()
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            int num;
            for (num = 1; num <= n; num++)
            {
                Console.WriteLine(num);
            }
        }
    }
