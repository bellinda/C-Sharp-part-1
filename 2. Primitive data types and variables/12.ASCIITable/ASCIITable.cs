using System;
    class ASCIITable
    {
        static void Main()
        {
            for(int a= 1; a<=255; a ++)
            {
                char ascii = (char)a;
                Console.WriteLine(ascii);
            }
        }
    }
