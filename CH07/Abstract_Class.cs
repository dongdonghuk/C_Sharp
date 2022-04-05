using System;
namespace CH07
{
    abstract class Token
    {
        public void Hi()
        {
            Console.WriteLine("Hi.");
        }

        public virtual void Name()
        {
            Console.WriteLine("Token");
        }

        public abstract void Length();
       
    }

    class CommandToken : Token
    {

        public override void Name()
        {
            Console.WriteLine("CommandToken");
        }

        public override void Length()
        {
            Console.WriteLine("Length");
        }
    }



    public class Abstract_Class
    {
        static void Main(string[] args)
        {


        }
    }
}
