using System;
    class SumEquals0
    {
        static void Main()
        {
            Console.WriteLine("Give me five integers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            if ((a + b + c + d == 0) || (a + b + c + e == 0) || (a + b + d + e == 0) || (a + c + d + e == 0) || (b + c + d + e == 0) || (a + b + c == 0) || (a + b + d == 0) || (a + b + e == 0) || (b + c + d == 0) || (b + d + e == 0) || (c + d + e == 0) || (a + b == 0) || (a + c == 0) || (a + d == 0) || (a + e == 0) || (b + c == 0) || (b + d == 0) || (b + e == 0) || (c + d == 0) || (c + e == 0) || (d + e == 0))
            {
                Console.WriteLine("The sum of some subset of these five integers is 0.");
            }
            else
            {
                Console.WriteLine("The sum of non subsets of these five integers is 0.");
            }
        }
    }

