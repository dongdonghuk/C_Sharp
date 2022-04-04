using System;

namespace CH07
{
    class Token
    {
        public void Name()
        {
            Console.WriteLine("Token()");
        }
    }

    class CommandToken : Token
    {
        public void Name()
        {
            base.Name();
            Console.WriteLine("CommandToken.");
        }
    }

    class OnlineCommandToken : CommandToken
    {
        public void Name()
        {
            Console.WriteLine("OnlineCommandToken.");
        }
    }

    class ObjectTypeCast
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            t1.Name();

            CommandToken c1 = new CommandToken();
            c1.Name();

            //파생클래스 객체가 생성되면 기반클래스 오버라이드 된 메서드는 가리워진다
            OnlineCommandToken oc1 = new OnlineCommandToken();
            oc1.Name();
            Console.WriteLine();

            Token t2, t3;
            t2 = new CommandToken();    //upcast
            t3 = new OnlineCommandToken();

            //파생클래스 객체가 기반클래스 객체변수에 대입되면 기반 클래스 메서드가 불리워 진다.
            t2.Name();
            t3.Name();

            if (t2 is CommandToken)
            {
                c1 = (CommandToken)t2;
                c1.Name();
            }

            OnlineCommandToken oc2 = t3 as OnlineCommandToken;
            if (oc2 != null)
                oc2.Name();

        }
    }
}
