using System;
    class CheckTheThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine())/100;
            Console.WriteLine(num % 10 == 7);
            
        }
    }
