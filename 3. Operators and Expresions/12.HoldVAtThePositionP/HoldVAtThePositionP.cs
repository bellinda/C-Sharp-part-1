using System;
    class HoldVAtThePositionP
    {
        static void Main()
        {
            Console.WriteLine("Write me an integer: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a position: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a value (1 or 0) you want to save on the definite position: ");
            int v = int.Parse(Console.ReadLine());
            int mask = 1 << p;
            if (v == 1)
            {
                Console.WriteLine(mask | n);
            }
            else
            {
                Console.WriteLine(mask ^ n);
            }

        }
    }
