using System;
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.WriteLine("Enter two integer numbers (on different lines):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c;
            if (a > b)
            {
                c = a;
                a = b;
                b = c;
                Console.WriteLine("The values of the variables are exchanged and now they are: a = {0} and b = {1}.", a, b);
            }
            else
            {
                Console.WriteLine("The first number is smaller than the second.");
            }
        }
    }
