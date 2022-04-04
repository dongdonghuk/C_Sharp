using System;


namespace CH07
{
    class Token
    {
        public virtual void Name()
        {
            Console.WriteLine("Token()");
        }
    }

    class CommandToken : Token
    {
        public override void Name()
        {
            Console.WriteLine("CommandToken.");
        }
    }

    class OnlineCommandToken : CommandToken
    {
        public new void Name()
        {
            Console.WriteLine("OnlineCommandToken.");
        }
    }

    class Virtual_class
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            Token t2 = new CommandToken();
            Token t3 = new OnlineCommandToken();

            t1.Name();
            t2.Name();
            t3.Name();

        }
    }
}
