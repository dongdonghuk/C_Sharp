using System;


namespace CH07
{

    class Date
    {
        private int yy;
        private int mm;
        private int dd;

        public Date() : this(2022,01,02)
        {
            Console.WriteLine("Date()");
            //yy = DateTime.Now.Year;
            //mm = DateTime.Now.Month;
            //dd = DateTime.Now.Day;
        }

        public Date(int yy, int mm, int dd)
        {
            this.yy = yy;
            this.mm = mm;
            this.dd = dd;
        }
        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", yy, mm, dd);
        }

    }

    class Class_Constructer
    {

        static void Main(string[] args)
        {
            Date d1 = new Date();
            d1.showData();

            Date d2 = new Date(2022, 4, 5);
            d2.showData();

            Date d3 = new Date();
            d3.showData();

        }
    }
}
