using System;
    class ExtractAValueOfABit
    {
        static void Main()
        {
            Console.WriteLine("Give me an integer: ");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Tell me which bit do you want to know: ");
            int b = int.Parse(Console.ReadLine());
            int mask = 1 << b;
            Console.WriteLine((i & mask) != 0 ? 1:0);
        }
    }
