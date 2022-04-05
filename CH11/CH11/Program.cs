using System;

namespace CH11
{
    class intClass
    {
        private int value;

        public intClass(int _value)
        {
            value = _value;
        }

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }

        }
    }

    class GenericClass<T>
    {
        private T value;

        public GenericClass(T _value)
        {
            value = _value;
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            intClass num = new intClass(100);
            Console.WriteLine("num : {0}", num);

            num.Value = 200;
            Console.WriteLine("num : {0}", num);
            Console.WriteLine("==================");

            GenericClass<int> GInt = new GenericClass<int>(200);
            Console.WriteLine("num : {0}", GInt.Value);
            GInt.Value = 300;
            Console.WriteLine("num : {0}", GInt.Value);




        }
    }
}
