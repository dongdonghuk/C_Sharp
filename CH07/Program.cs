using System;

namespace CH07
{
    class Point
    {
        public double x;
        public double y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point c1 = new Point();
            Point c2 = new Point();
            Point c3;

            c1.x = 1.0;
            c1.y = 1.5;
            c2.x = 2.0;
            c2.y = 2.5;

            Console.WriteLine("c1 {0}, {1}", c1.x, c1.y);
            Console.WriteLine("c2 {0}, {1}", c2.x, c2.y);

            c3 = c1;

            if (c1 == c2)
                Console.WriteLine("Equal.");
            else
                Console.WriteLine("Not equal");

            if (c1 == c3)
                Console.WriteLine("Equal.");
            else
                Console.WriteLine("Not equal");

            c3.x = 3.0;
            c3.y = 3.5;
            Console.WriteLine("c1 : {0}, {1}", c1.x, c1.y);

            c1 = null;  //객체를 참조하는 reference count를 감소하여 0이 되면 GC가 더 빠른 해제를 유도한다.
            c2 = null;
            //c3 = null;
            Console.WriteLine("c3 : {0}, {1}", c3.x, c3.y);

        }
    }
}
