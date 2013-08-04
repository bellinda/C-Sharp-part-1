using System;
    class Matrix
    {
        static void Main()
        {
            int matrix = 0;

            Console.Write("Enter the size of ypur matrix ( it should be < 20) : ");
            bool size = Int32.TryParse(Console.ReadLine(), out matrix);
            Console.WriteLine();

            if (size)
            {
                for (int rows = 1; rows <= matrix; rows++)
                {
                    Console.WriteLine();

                    for (int colum = rows; colum < rows + matrix; colum++)
                    {
                        Console.Write("{0,3} ", colum);
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
            }
        }
    }
