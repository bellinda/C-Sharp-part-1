using System;
    class SortInDescendingOrder
    {
        static void Main()
        {
            Console.WriteLine("Enter three real values: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && b > c)
            {
                Console.WriteLine("In descending order the values are sortet as {0}, {1}, {2}.", a, b, c);
            }
            else if (a < b && c > b)
            {
                Console.WriteLine("In descending order the values are sortet so: {0}, {1}, {2}.", c, b, a);
            }
            else if (a > c && c > b)
            {
                Console.WriteLine("In descending order the values are sortet so: {0}, {1}, {2}.", a, c, b);
            }
            else if (b > a && a > c)
            {
                Console.WriteLine("In descending order the values are sortet so: {0}, {1}, {2}.", b, a, c);
            }
            else if (b > c && c > a)
            {
                Console.WriteLine("In descending order the values are sortet so: {0}, {1}, {2}.", b, c, a);
            }
            else if (c > a && a > b)
            {
                Console.WriteLine("In descending order the values are sortet so: {0}, {1}, {2}.", c, a, b);
            }

        }
    }

