using System;
namespace CH08
{
    class StringList
    {
        string[] list = new string[10];

        public string this[int index]
        {
            set { list[index] = value; }

            get { return list[index]; }
        }

        public int length()
        {
            return list.Length;
        }



    }

    public class Indexer_intro
    {
        static void Main(string[] args)
        {
            StringList myList = new StringList();

            myList[0] = "one";
            myList[1] = "two";
            myList[2] = "hello world!";

            Console.WriteLine("myList.length() : ", myList.length());

            for(int i=-0;i<myList.length();i++)
            {
                if (myList[i] != null)
                    Console.WriteLine(myList[i]);
            }


        }
    }
}
