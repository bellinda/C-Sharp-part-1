using System;
    class CalculateTheExpression
    {
        static void Main()
        {
            Console.Write("Enter values for N and K, please - N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            decimal nFactorial = 1;
            decimal kFactorial = 1;
            decimal nkFactorial =1;
            if (1 < n && 1 < k && n < k)
            {
                for (int i = n; i >= 1; i--)
                {
                    nFactorial *= i;

                }
                for (int i = k; i >= 1; i--)
                {
                    kFactorial *= i;

                }
                for (int i = (k - n); i >= 1; i--)
                {
                    nkFactorial *= i;
                }
                decimal result = (nFactorial * kFactorial) / nkFactorial;
                Console.WriteLine("N!:{0}, K!:{1} calculation of N!*K! / (K-N)! is: {2}", nFactorial, kFactorial, result);
            }
            else
            {
                Console.WriteLine("Please enter two numbers greater than one and N < K");
            }
        }
    }
