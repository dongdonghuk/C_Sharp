using System;


namespace CH07
{
    class Employee
    {
        private string name;
        private int salary;
        private string comAddr;

        public Employee()
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

        public void AddSalary(int _sudnag)
        {
            salary += _sudnag;
        }

        public Employee DeepCopy()
        {
            Employee newCopy = new Employee();

            newCopy.name = this.name;
            newCopy.salary = this.salary;
            newCopy.comAddr = this.comAddr;

            return newCopy;
        }

    }

    class Employee_Deepcopy
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee("park", 2700000, "seoul");
            e1.showData();

            Employee tmp;
            tmp = e1;       //참조복사
            tmp.AddSalary(200000);

            tmp.showData();
            e1.showData();

            Employee e2 = new Employee("kim", 2700000, "busan");
            Employee tmp2 = e2.DeepCopy();

            tmp2.AddSalary(200000);

            tmp2.showData();
            e2.showData();
        }
    }
}
