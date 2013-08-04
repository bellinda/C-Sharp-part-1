using System;
    class ReminderDivisionBy5
    {
        static void Main()
        {
            Console.Write("First positive integer: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Second positive integer: ");
            int second = int.Parse(Console.ReadLine());
            int p = 0;
            int i;
            for (i = first; i < second; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                }
            }
            Console.WriteLine(p);
        }
    }

