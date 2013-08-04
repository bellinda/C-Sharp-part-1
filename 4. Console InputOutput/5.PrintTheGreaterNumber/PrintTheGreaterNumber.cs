using System;
    class PrintTheGreaterNumber
    {
        static void Main()
        {
            Console.Write("First number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1>num2?"{0} > {1}":"{1} > {0}", num1, num2);
        }
    }

