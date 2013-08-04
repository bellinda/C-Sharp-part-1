using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7.Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numberN;
            long firstMember = 0;
            long secondMember = 1;
            long sumMember;
            long sum = 0;

            Console.Write("Enter number N=");
            bool validInput = uint.TryParse(Console.ReadLine(), out numberN);

            for (int i = 1; i <= (numberN - 2); i++)
            {
                sumMember = firstMember + secondMember;
                firstMember = secondMember;
                secondMember = sumMember;
                sum += sumMember;
            }
            Console.WriteLine("The sum of the first {0} numbers of Fibonacci sequence is {1}", numberN, (1 + sum));
        }
    }
}
