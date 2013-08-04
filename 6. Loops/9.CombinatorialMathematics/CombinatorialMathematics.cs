using System;
    class CombinatorialMathematics
    {
        static void Main()
        {
            Console.Write("[n>=0] n = ");
            int n = int.Parse(Console.ReadLine());
            decimal nFactorial=1;
            decimal doubleNFactorial = 1;
            int q = n;
            int i = 2 * n;
            while (q >= 1)
            {
                nFactorial *= q;
                q--;
            }
            while (i>=1)
            {
                doubleNFactorial *= i;
                i--;
            }
            decimal result = doubleNFactorial/((n+1)*nFactorial*nFactorial); 
            Console.WriteLine("Cn = (2n)!/(n+1)!*n! = {0}",result);
        }
    }
