using System;
    class FibunacciSequence
    {
        static void Main()
        {
            ulong first = 0;
            ulong second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);
            int i;
            ulong sum;
            for (i = 0; i <= 100; i++)
            {
                sum = first + second;
                first = second;
                second = sum;
                Console.WriteLine(sum);
            }
        }
    }
