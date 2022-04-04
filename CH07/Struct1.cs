using System;


namespace CH07
{
    struct Employee
    {
        private string name;
        private int salary;
        private DateTime birth;

        //public Employee()
        //{
        //    Console.WriteLine("Employee() called.");
        //}

        public Employee(string _name, int _sal, DateTime _birth)
        {
            name = _name;
            salary = _sal;
            birth = _birth;
        }


        //public Employee(string _name, int _sal)
        //{
        //    name = _name;
        //    salary = _sal;
        //}

        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary, birth);
        }


    }

    class ConsoleApp
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.showData();

            Employee e2 = new Employee("길동이", 270000, DateTime.Parse("2022-04-01"));
            e2.showData();

            //Employee e3 = new Employee("길동이", 270000);
            //e3.showData();

            //Employee e4;
            //e4.showData; 할당되지 않은 구조체 변수

        }
    }
}
