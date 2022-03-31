using System;
using GreetingWorld;


namespace HelloWorld
{
    partial class Program2
    {
        public static void Main()
        {
            Console.WriteLine("namespace, class, method 구분");

            GoodMorning();
            Program3.GoodBye();
            Greeting1.GreetingShow1();
            GoodNight();

            //GreetingWorld.Greeting2.GreetingShow2();
            Greeting2.GreetingShow2();
        }

        public static void GoodMorning()
        {
            Console.WriteLine("안녕하세요~");
        }
    }

    class Program3
    {
        public static void GoodBye()
        {
            Console.WriteLine("안녕히 가세요~");
        }
    }
}
