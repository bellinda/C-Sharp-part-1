using System;
    class FindTheBiggest
    {
        static void Main()
        {
            Console.WriteLine("Enter three integers (on different lines!) ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            if (first > second && first > third)
            {
                Console.WriteLine("The biggest integer of these three is {0}.", first);
            }
            else if (second > first && second > third)
            {
                Console.WriteLine("The biggest integer of these three is {0}.", second);
            }
            else
            {
                Console.WriteLine("The biggest integer of these three is {0}.", third);
            }
        }
    }
