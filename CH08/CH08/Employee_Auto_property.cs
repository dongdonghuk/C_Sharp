using System;
namespace CH08
{
    class Employee
    {
        //private string name;
        private int salary;
        //private string comAddr;

        public string name
        {
            get;
            set;
        }

        public string address
        {
            get;
            set;
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


        public Employee() : this("홍길동", 3500000, "서울시 종로구 혜화동")
        {

        }

        public Employee(string name, int salary, string address)
        {
            this.name = name;
            this.salary = salary;
            this.address = address;
        }


        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2} ", name, salary, address);
        }
    }

    public class Employee_Auto_property
    {
        static void Main(string[] args)
        {

        }
    }
}
