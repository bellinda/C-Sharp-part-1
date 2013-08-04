using System;
    class MinAndMax
    {
        static void Main()
        {
            int i;
            Console.Write("The number of the integers you want to compare = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter the 1 integer: ");
            int myNum = int.Parse(Console.ReadLine());
            int min, max;
            min = max = myNum;
            for (i = 1; i < n; i++)
            {
                Console.Write("Enter the {0} integer: ", i + 1);
                myNum = int.Parse(Console.ReadLine());
                if (max < myNum)
                {
                    max = myNum;
                }
                if (min > myNum)
                {
                    min = myNum;
                }
            }
            Console.WriteLine("The smallest is: " + min);
            Console.WriteLine("The biggest is: " + max);
        }
    }