using System;

namespace CH10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열");

            int[] x = new int[5];

            int[] y;
            y = new int[5];

            x[0] = 10;
            x[1] = 20;
            x[3] = 30;
            for (int i = 0; i < x.Length; i++)
                Console.Write("{0}, ", x[i]);
            Console.WriteLine();

            int[] z;
            z = x;
            for (int i = 0; i < z.Length; i++)
                Console.Write("{0}, ", z[i]);
            Console.WriteLine();


        }
    }
}
