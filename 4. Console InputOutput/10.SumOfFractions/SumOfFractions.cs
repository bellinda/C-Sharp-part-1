using System;
    class Program
    {
        static void Main()
        {
            double sum = 1.0f;
            double i;
            for (i = 2; i<= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + 1 / i;
                }
                else
                {
                    sum = sum - 1 / i;
                }
            }
            Console.WriteLine("{0:0.000}", sum);  

        }
    }

