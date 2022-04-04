using System;
using System.IO;


namespace CH07
{
    class SourceFile
    {
        private FileStream src;

        public SourceFile(string name)
        {
            src = File.Open(name, FileMode.Open);
            Console.WriteLine("{0} 를 엽니다.", name);
        }

        ~SourceFile()
        {
            Console.WriteLine("소멸자 호출");
            src.Close();
        }

    }
    class CLass_Destructor
    {
        static void Main(string[] args)
        {
            SourceFile src = new SourceFile("D:\\C_Sharp\\CH07\\CLass_Destructor.cs");




        }
    }
}


