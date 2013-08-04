using System;
    class ExchangingValues
    {
        static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0} and b = {1}", a, b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Now a is = {0} and b = {1}", a, b);
            //Another way:
            //int a = 5;
            //int b = 10;
            //a = a + b;
            //b = a - b;
            //a = a - b;
            //Console.WriteLine(a);
            //Console.WriteLine(b);

        }
    }

