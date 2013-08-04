using System;
    class NullsAtTheEnd
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int end = 0;
            for (int i = 5; i <= n; i *= 5)
            {
                end += (n / i);
            }
            Console.WriteLine("The trailing nulls of {0} are {1}.", n, end);
        }
    }
