using System;
    class NullValues
    {
        static void Main()
        {
            int? b = null;
            int? c = 17;
            double? d = null;
            double? e = 3.14;
            Console.WriteLine(b);                          //null
            Console.WriteLine(b.GetValueOrDefault());      //0
            Console.WriteLine(c);                          //17  
            Console.WriteLine(d);                          //null
            Console.WriteLine(d.GetValueOrDefault());      //0
            Console.WriteLine(e.HasValue);                 //True
            Console.WriteLine(e.GetValueOrDefault());      //3.14
        }
    }
