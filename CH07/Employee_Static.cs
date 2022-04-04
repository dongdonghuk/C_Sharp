using System;


namespace CH07
{
    class Employee
    {
        private string name;
        private int salary;
        private string comAddr;

        private static int sudang; //정적멤버

        public Employee()   //객체가 생성될 때 마다 실행
        {
            Console.WriteLine("public Employee() called.");
        }

        static Employee()   //객체가 처음 생성될 때 new 하기 전 한번만 실행, 정적 멤버 초기화가 목표
        {
            Console.WriteLine("static Employee() called.");
            sudang = 1000000;
        }

        public Employee(string name, int salary, string comAddr)
        {
            this.name = name;
            this.salary = salary;
            this.comAddr = comAddr;
        }

        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2} ", name,salary==0? salary: salary + sudang, comAddr);
        }

        static public void M_sudang(int _su)
        {
            sudang = _su;
        }
    }



    class Employee_Static
    {
        static void Main(string[] args)
        {
            Employee.M_sudang(300000); // 정적 메서드 호출

            Employee e1 = new Employee();
            e1.showData();

            Employee e2 = new Employee("park", 77777, "seoul");
            e2.showData();

        }
    }
}
