using System;
    class BooleanExpression
    {
        static void Main()
        {
            Console.Write("Enter an integer value of a: ");
            int a = int.Parse(Console.ReadLine());
            if ((a%7==0) && (a%5==0))
            {
                Console.WriteLine("The integer can be divided (without reminder) by 7 and 5 in the same time.");
            }
            else
            {
                Console.WriteLine("The integer has a reminder by devision by 5 or 7.");
            }
            
        }
    }
