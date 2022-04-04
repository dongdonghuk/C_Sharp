using System;


namespace CH07
{
    class Car
    {
        private readonly int count = 5; // 생성자에서 readonly 필드 수정 가능
        private const int speed = 10;

        public Car()
        {
        }
        public Car(int _count)
        {
            count = _count;
        }

        public void showData()
        {
            Console.WriteLine("count : {0}", count);
            Console.WriteLine("speed : {0}", speed);
        }
    
    }


    class Class1_ReadOnly
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.showData();

            Car c2 = new Car(10);
            c2.showData();
        }
    }
}
