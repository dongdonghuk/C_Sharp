using System;


namespace CH01
{
    class ConsoleInput
    {
        public static void Main()
        {
            //Console.WriteLine("성명 ? ");
            Console.Write("성명 ? ");
            string name = Console.ReadLine();

            Console.WriteLine("성명은 {0} 입니다. ", name);

            Console.Write("당신의 성은 ? ");
            char name2 = (char)Console.Read();
            Console.WriteLine("당신의 성은 {0} 입니다. ", name2);
            Console.ReadLine();

            Console.Write("나이 ? ");
            string tmp = Console.ReadLine();
            //int age = Int32.Parse(tmp);
            //int age = int.Parse(tmp);
            int age = Convert.ToInt32(tmp);
            

            Console.WriteLine("이름의 나이는 {0} 입니다. ", age);
            Console.WriteLine();

            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now);


            Console.Write("생년월일? ");
            tmp = Console.ReadLine();
            DateTime birth = DateTime.Parse(tmp);

            Console.WriteLine("생일은 {0} 입니다. ", birth);

        }
    }
}
