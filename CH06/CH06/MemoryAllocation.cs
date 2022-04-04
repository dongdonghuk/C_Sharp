using System;

namespace CH06
{
    class Program
    {
        static int salary = 3500000;

        static void funcA()
        {
            int age = 30;
            Console.WriteLine("funcA() salary : {0}, age {1}", salary, age);
            salary += 10000;
        }

        static void Main(string[] args)
        {
            int age = 27;

            Console.WriteLine("Main() salary: {0}, age: {1}", salary, age);
            funcA();
            Console.WriteLine("Main() salary: {0}, age: {1}", salary, age);

            char[] str = new char[5] { 'A', 'B', 'C', 'D', 'E' };
            Console.WriteLine(str[0]);
            Console.WriteLine(str);

            string str2 = "kingdom";
            str2 = "hello world";

            Console.WriteLine(str2[0]);
            Console.WriteLine(str2);
        }
    }
}
