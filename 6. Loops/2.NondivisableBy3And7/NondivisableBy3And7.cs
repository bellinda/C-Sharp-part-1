using System;
    class NondivisableBy3And7
    {
        static void Main()
        {
            Console.Write("N=");
            int n = int.Parse(Console.ReadLine());
            int i;
            for (i = 1; i <= n; i++)
            {
                if ((i % 7 != 0) || (i % 3 != 0))
                {
                        Console.WriteLine(i);
                }
            }
        }
    }

