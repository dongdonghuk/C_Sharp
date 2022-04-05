using System;

namespace CH08
{
    interface IToken    //인터페이스 선, 구현은 없고 선언만 있다
    {
        void Name();
    }

    class Token : IToken
    {
        public void Name()
        {
            Console.WriteLine("Name() 메서드");
        }
    }

    class CommnadToken : IToken
    {
        public void Name()
        {
            Console.WriteLine("CommnadToken Name() method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //}IToken T1 = new IToken();

            Token t2 = new Token();

            t2.Name();
        }

    }
}
