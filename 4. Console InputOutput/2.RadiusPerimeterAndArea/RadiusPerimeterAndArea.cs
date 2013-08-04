using System;
    class RadiusPerimeterAndArea
    {
        static void Main()
        {
            Console.Write("Enter the radius r of the circle: ");
            int r = int.Parse(Console.ReadLine());
            double PI = 3.14;
            double P = 2 * PI * r;
            double S = PI * r * r;
            Console.WriteLine("The perimeter of the circle is P = {0} and its area is S = {1}.", P, S);
        }
    }
