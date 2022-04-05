using System;
namespace CH08
{
    class Person
    {
        private readonly DateTime birth;

        public Person(DateTime _birth)
        {
            birth = _birth;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - birth.Year;
            }

        }
    }

    public class Property_읽기전용
    {
        static void Main(string[] args)
        {
            Console.Write("생년월일 ?");
            string tmp = Console.ReadLine();

            DateTime birthday = DateTime.Parse(tmp);

            Person p1 = new Person(birthday);

            Console.WriteLine("나이 : {0}", p1.Age);
        }
    }
}
