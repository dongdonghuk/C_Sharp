using System;


namespace CH07
{
    class FirstClass
    {
        private string name;

        public FirstClass()
        {
            name = "noName";
        }

        public void showData()
        {
            Console.WriteLine("name: {0}", name);
        }
        public void reName(string _name)
        {
            SecondClass rName = new SecondClass();
            rName.SetName(ref name, _name);
        }

        class SecondClass //클래스 중첩
        {
            public void SetName(ref string _refname, string _name)
            {
                _refname = _name;
            }
        }

    }


    class Nested_Class
    {
        static void Main(string[] args)
        {
            FirstClass my = new FirstClass();
            my.showData();

            my.reName("park");
            my.showData();


        }
    }
}
