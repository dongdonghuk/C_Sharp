using System;
namespace CH06
{
    public class OptionalParameter
    {
        static void PrintProfile(string name, string phone="", int salary=0)
        {
            Console.WriteLine("name :{0}, phone: {1}, salary: {2}", name, phone, salary);

        }

        static void Main(string[] args)
        {

            PrintProfile("홍길동");
            PrintProfile("홍길동", "010-001-1234");
            PrintProfile("홍길동", "010-001-1234", 3400000);

            PrintProfile(salary: 10000, name: "박동혁");
        }
    }
}
