using System;


namespace CH07
{
    class Employee
    {
        private string name;
        private int salary;
        private string comAddr;

        public Employee() : this("홍길동", 3500000, "서울시 종로구 혜화동")
        {

        }

        public Employee(string name, int salary, string comAddr)
        {
            this.name = name;
            this.salary = salary;
            this.comAddr = comAddr;
        }

        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2} ", name, salary, comAddr);
        }
    }

    class Employee_PrivateMember
    {

        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.showData();

            Employee emp2 = new Employee("졸려유", 370000, "서울시 구로구");
            emp2.showData();


        }
    }
}
