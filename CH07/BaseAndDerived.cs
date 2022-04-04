using System;


namespace CH07
{
    class Base
    {
        protected string name;

        public void BaseMethod()
        {
            name = "Base";
            Console.WriteLine("BaseMethod() : {0}", this.name);
        }
    }

    class Derived : Base //상속
    {

        public void DerivedMethod()
        {
            name = "Derived";
            Console.WriteLine("DerivedMethod() : {0}", this.name);

        }
    }

        class BaseAndDerived
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.BaseMethod();

            Derived d1 = new Derived();
            d1.BaseMethod();
            d1.DerivedMethod();
            d1.BaseMethod();


        }
    }
}
