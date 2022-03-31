using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class SimpleType1
    {

        public static void Main()
        {
            sbyte byte1 = 127;
            byte byte2 = 250;
            int int2 = 3500000;
            long longint4 = 27000000000;
            int 나이 = 30;

            Console.WriteLine(byte1);
            Console.WriteLine(byte2);
            Console.WriteLine(int2);
            Console.WriteLine(longint4);
            Console.WriteLine(나이);
            Console.WriteLine();

            float float5 = 1.123F;
            double double6 = 3.14159;
            decimal decimal7 = 123456789.1456M;

            Console.WriteLine(float5);
            Console.WriteLine(double6);
            Console.WriteLine(decimal7);
            Console.WriteLine();


            char char8 = 'a';
            string string9 = "campus";
            bool bool10 = true;

            Console.WriteLine(bool10);
            Console.WriteLine(float5);
            Console.WriteLine(char8);
            Console.WriteLine(string9);
            Console.WriteLine();

            Console.WriteLine("{0}, {1}, {2}", sizeof(bool), sizeof(char), sizeof(decimal));




        }

    }
}
