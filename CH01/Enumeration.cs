using System;


namespace CH01
{
    class Enumeration
    {
        enum Color
        {
            Red =100,
            Green,
            Blue
        }

        class ConsoleApp
        {
            public static void Main()
            {
                const float PI = 3.14159F;

                Console.WriteLine("PI : {0} ", PI);

                Color color1 = Color.Red;
                Console.WriteLine("color1 : {0} ", color1);
                Console.WriteLine("color1 : {0} ", (int)color1);

                Color color2 = Color.Green;
                Color color3 = (Color)2;
                Console.WriteLine("color2 : {0} ", color2);
                Console.WriteLine("color3 : {0} ", color3);


            }
        }
    }
}
