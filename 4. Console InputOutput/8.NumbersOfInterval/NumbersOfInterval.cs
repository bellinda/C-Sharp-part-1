using System;
    class NumbersOfIntervals
    {
        static void Main()
        {
            Console.Write("Enter the number of the numbers in your interval (n>1): ");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(i); ;
            }
                
        }
    }
