using System;
namespace CH08
{
    interface IA
    {
        void fool();
    }

    interface IB
    {

    }

    interface IC
    {

    }

    class ABC : IC
    {
        public void foo1()
        {
            Console.WriteLine("foo1() ");
        }

        public void foo2()
        {
            Console.WriteLine("foo2() ");
        }

        public void foo3()
        {
            Console.WriteLine("foo3() ");
        }
    }

    public class interface_상속
    {
        public interface_상속()
        {
        }
    }
}
