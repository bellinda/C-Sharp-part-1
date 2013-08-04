using System;
    class IntOddOrEven
    {
        static void Main()
        {
            Console.WriteLine("Enter value of a: ");
            int a = int.Parse(Console.ReadLine());
            int b = a % 2;
            if (b == 0)
            {
                Console.WriteLine("even");
            }
            else
                Console.WriteLine("odd");
        }
    }
