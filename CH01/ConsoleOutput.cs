using System;


namespace CH01
{
    class ConsoleOutput
    {
        public static void Main()
        {
            Console.WriteLine(100);
            Console.WriteLine("hello");
            Console.WriteLine('가');
            Console.WriteLine(3.14);

            Console.WriteLine("{0}, {1}, {2}", 100, 200, 300);
            Console.WriteLine("{0}, {1}, {1}, {2}, {2}", 100, 200, 300);
            Console.WriteLine();

            Console.WriteLine("{0, -10}", 999);
            Console.WriteLine("{0, 10}", 999);
            Console.WriteLine("{0:C}", 123456789);
            Console.WriteLine("{0:N}", 123456789);
            Console.WriteLine("{0:N0}", 123456789);
            Console.WriteLine("{0:X}", 123456789);
            Console.WriteLine();


            Console.WriteLine("{0}", 0);
            Console.WriteLine("{0:#, ###}", 0);
            Console.WriteLine("{0:#, ##0}", 0);
            Console.WriteLine("{0:#, ###}", 123456789);
            Console.WriteLine("{0:#, ##0}", 123456789);
            Console.WriteLine();

            decimal tmp = 20.5M;
            string s = string.Format("온도 {0} 입니다. ", tmp);
            Console.WriteLine(s);


            Console.WriteLine("\\\\server\\share");
            Console.WriteLine(@"\\server\share");

        }
    }
}
