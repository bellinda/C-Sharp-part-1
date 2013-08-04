using System;
    class PrimeOrNot
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer number smaller than 100: ");
            int num = int.Parse(Console.ReadLine());
            int i;
            int p = 0;
            for (i = 2; i < num; i++)
            {
                if ((num % i == 0) && (i != num))
                {
                    p = p + 1;
                }
                else
                {
                    p = p + 0;
                }
                }
                if(p==0)
                {
                Console.WriteLine("The number {0} is prime. It can't be divided without reminder expected 1 or {0}." , num);
                }
                else
                {
                Console.WriteLine("The number {0} isn't prime. It can be divided of {1} numbers without reminder (expected 1 or {0}).", num, p);
                }
            }
        }
