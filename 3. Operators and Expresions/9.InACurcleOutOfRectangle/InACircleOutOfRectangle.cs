using System;
    class InACircleOutOfRectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter the first coordinate of the point - x: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second coordinate of the point - y: ");
            double y = double.Parse(Console.ReadLine());
            if (((x * x + y * y) >= 2) && ((x * x + y * y) <= 25) && ((x < -1) && (x > -5)) && ((y < 5) && (y > 1)) && ((y < -1) && (y > -5)))
            {
                Console.WriteLine("The point is in the circle K ((1,1),5) and out of the rectangle R(top = 1, left = -1, width = 6 and hight = 2.");
            }
            else
            {
                if (((x * x + y * y) >= 2) && ((x * x + y * y) <= 25) && (((x >= -1) || (x <= -5)) && ((y >= 5) || (y <= 1)) && ((y >= -1) || (y <= -5))))
            {
                Console.WriteLine("The point is in the circle K ((1,1),5) and in the rectangle R(top = 1, left = -1, width = 6 and hight = 2.");
            }
                else if(((x * x + y * y) <= 2) || ((x * x + y * y) >= 25) && ((x < -1) && (x > -5)) && ((y < 5) && (y > 1)) && ((y < -1) && (y > -5))) 
            {
                Console.WriteLine("The point is out of the circle K ((1,1),5) and out of the rectangle R(top = 1, left = -1, width = 6 and hight = 2.");
            }
            else
            {
                Console.WriteLine("The point is out of the circle K ((1,1),5) and in the rectangle R(top = 1, left = -1, width = 6 and hight = 2");
            }
            }
        }
    }

