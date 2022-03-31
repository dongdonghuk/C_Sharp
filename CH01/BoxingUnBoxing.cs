using System;


namespace CH01
{
    class BoxingUnBoxing
    {
        public static void Main()
        {
            int a = 123;
            object b = (object)a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            int c = (int)b;
            Console.WriteLine(c);


        }
    }
}
