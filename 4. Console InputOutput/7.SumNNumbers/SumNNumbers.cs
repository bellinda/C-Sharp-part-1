using System;
    class SumNNumbers
    {
        static void Main()
        {
            Console.Write("Give me a number of the numbers you want to sum: n = ");
            int n = int.Parse(Console.ReadLine());
            int i;
            double sum = 0;
            Console.WriteLine("Give me a new number ");
            for (i=0;i<n;i++)
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum of these numbers is = {0}.", sum);
        }
    }
