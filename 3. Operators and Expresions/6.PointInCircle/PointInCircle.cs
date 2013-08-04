using System;
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first coordinate of the point: ");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point: ");
            int c2 = int.Parse(Console.ReadLine());
            if ((c1>=0) && (c1<=5) && (c2>=0) && (c2<=5))
            {
                Console.WriteLine("The point is the the circle K(0,5).");
            }
            else
            {
                Console.WriteLine("The point isn't in the circle K(0,5).");
            }

        }
    }
