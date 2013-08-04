using System;
    class Factorial
    {
        static void Main()
        {
            Console.Write("Enter values for N and K, please - N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            decimal nFactorial = 1;
            decimal kFactorial = 1;

                while (n >= 1)
                {
                    nFactorial *= n;
                    n--;
                }
                while (k >= 1)
                {
                    kFactorial *= k;
                    k--;
                }
            Console.WriteLine("N!/K! = {0}", nFactorial/kFactorial);
        }
    }
