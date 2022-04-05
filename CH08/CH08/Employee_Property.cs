using System;
namespace CH08
{
    class Employee
    {
        private string name;
        private int salary;
        private string comAddr;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0 && value <= 70000000)
                    salary = value;
                else
                {
                    Console.WriteLine("월급은 0~7000000을 입력 !!");
                    salary = 0;
                }
            }
        }

        public string Address
        {
            get { return comAddr; }
            set { comAddr = value; }
        }
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


    public class Employee_Property
    {
        static void Main(string[] args)
        {
            Employee emp3 = new Employee();

            emp3.Name = "park";
            emp3.Salary = 77777;
            emp3.Address = "seoul";

            Console.WriteLine("{0}, {1}, {2}", emp3.Name, emp3.Salary, emp3.Address);

        }
    }
}
