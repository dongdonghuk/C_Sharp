using System;


namespace CH01
{
    class Test1
    {
        public static void Main()
        {
            string name, tmp;
            int birthYear, salary;


            Console.Write("성명 ? ");
            name = Console.ReadLine();

            Console.Write("출생년도 ? ");
            tmp = Console.ReadLine();
            birthYear = Int32.Parse(tmp);

            Console.Write("월급 ? ");
            tmp = Console.ReadLine();
            salary = Int32.Parse(tmp);

            Console.WriteLine("당신의 이름은 {0}입니다. ", name);
            Console.WriteLine("당신의 나이는 : {0}세입니다. ", DateTime.Now.Year - birthYear);
            Console.WriteLine(@"당신의 연봉은 : {0:C} 입니다. ", salary * 12);


        }
    }
}
