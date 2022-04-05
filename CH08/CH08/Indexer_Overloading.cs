using System;
using System.Collections;

namespace CH08
{
    class NickName
    {
        public Hashtable name = new Hashtable();

        public string this[int index]
        {
            get { return (string)name[index]; }
            set { name[index] = value; }
        }

        public string this[string index]
        {
            get { return (string)name[index]; }
            set { name[index] = value; }
        }

        public string this[char index]
        {
            get { return (string)name[index]; }
            set { name[index] = value; }
        }
    }

    public class Indexer_Overloading
    {
        static void Main(string[] args)
        {
            NickName Name = new NickName();

            Name[0] = "kim";
            Name[1] = "park";

            Name["첫번째"] = "yang";
            Name["두번째"] = "lee";

            Name['A'] = "11";
            Name['B'] = "22";

            Console.WriteLine(Name[0]);
            Console.WriteLine(Name["첫번째"]);
            Console.WriteLine(Name['A']);

            foreach (DictionaryEntry item in Name.name)
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
        }
    }
}
