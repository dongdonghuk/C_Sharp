using System;
namespace CH08
{

    interface ISendable
    {
        void Send(string msg1, string msg2, string msg3 = "");
    }

    class Email : ISendable
    {
        public void Send(string s1, string s2, string s3 = "")
        {
            Console.WriteLine("Email {0} to {1} ", s1, s2);
        }

    }

    class SMS : ISendable
    {
        public void Send(string s1, string s2, string s3 = "")
        {
            Console.WriteLine("phone {0} to {1}, {2} ", s1, s2, s3);

        }
    }


    public class Sendable_interface
    {

        static void Main(string[] args)
        {
            Email e1 = new Email();
            e1.Send("길동님", "hong@naver.com");

            SMS s1 = new SMS();
            s1.Send("나리님", "010-1111-2222", "배송완료~");       


        }
    }
}
