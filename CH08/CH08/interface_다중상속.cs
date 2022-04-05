using System;
namespace CH08
{
    interface IToken1
    {
        void Name();
    }

    interface IToken2
    {
        void Name();
        void Accept();
    }

    class Token : IToken1, IToken2
    {
        void IToken1.Name()
        {
            Console.WriteLine("IToken1.Name() method");
        }

        void IToken2.Name()
        {
            Console.WriteLine("IToken2.Name() method");
        }

        public void Accept()
        {
            Console.WriteLine("Accept() method");
        }
    }

    public class interface_다중상
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            t1.Accept();

            IToken1 t2 = t1;
            t2.Name();

            IToken2 t3 = t1;
            t3.Name();  
            t3.Accept();

        }
    }
}
