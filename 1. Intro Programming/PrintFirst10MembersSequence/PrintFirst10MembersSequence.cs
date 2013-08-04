using System;
    class PrintFirst10MembersSequence
    {
        static void Main()
        {
            Console.WriteLine(2);
            Console.WriteLine(-3);
            Console.WriteLine(4);
            Console.WriteLine(-5);
            Console.WriteLine(6);
            Console.WriteLine(-7);
            Console.WriteLine(8);
            Console.WriteLine(-9);
            Console.WriteLine(10);
            Console.WriteLine(-11);

            //or:

            Console.WriteLine("Second version: ");

            int k = 2;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(k);
                k = k * (-1);
                if (k < 0)
                {
                    k--;
                }
                else
                {
                    k++;
                }
            }

        }
    }
