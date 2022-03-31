using System;


namespace CH01
{
    class Nullable
    {
        public static void Main()
        {
            //null 을 저장할 수 있는 변수
            int? a = null;
            int b = 0;

            Console.WriteLine(a.HasValue);  //값을 가지고 있으면 참
            Console.WriteLine(a != null);
            Console.WriteLine(a);
            Console.WriteLine(b);

            a = 100;
            Console.WriteLine(a.HasValue);  //값을 가지고 있으면 참
            Console.WriteLine(a != null);
            Console.WriteLine(a);
            Console.WriteLine();

            int num = 100;
            Console.WriteLine("{0},{1}", num, num.GetType());

            //var type 변수는 값이 저장될 때 자료형이 결정된다
            var Tmp = 200;
            Console.WriteLine("{0},{1}", Tmp, Tmp.GetType());

            var Tmp2 = 3.4;
            Console.WriteLine("{0},{1}", Tmp2, Tmp2.GetType());

            var Tmp3 = "campus";
            Console.WriteLine("{0},{1}", Tmp3, Tmp3.GetType());

        }
    }
}
