using System;

namespace CH10
{
    class Test
    {
        static int DataInput(string[] names, int[] salary, string[] comAddr)
        {
            int i;
            for( i=0; i<names.Length;i++)
            {
                Console.Write("이름: ");
                names[i] =Console.ReadLine();
                if (string.Compare(names[i], "end", true) == 0)
                    return i;
                Console.Write("연봉: ");
                salary[i] = Int32.Parse(Console.ReadLine());
                Console.Write("주소: ");
                comAddr[i] = Console.ReadLine();

            }
            return i;        
        }

        static void Main(string[] args)
        {
            string[] names = new string[5];
            int[] salary = new int[5];
            string[] comAddr = new string[5];

            int size, salTot = 0;

            size = DataInput(names, salary, comAddr);

            Console.WriteLine();
            for(int i = 0;i<size;i++)
            {
                Console.WriteLine("{0}, {1:N0}, {2}", names[i], salary[i], comAddr[i]);
                salTot += salary[i];
            }
            Console.WriteLine("연봉의 합 :  {0}", salTot );
        }
    }
}
