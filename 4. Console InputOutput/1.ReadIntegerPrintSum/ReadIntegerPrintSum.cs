using System;
    class ReadIntegerPrintSum
    {
        static void Main()
        {
            Console.Write("Enter an integer a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter an integer c = ");
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine("The sum of these three integers is " + sum + ".");
        }
    }
