using System;

/*
[Rectangle] Position = (5, 5), size = (30 40)
[Circle] Position = (150, 30), Radius= (40)
*/

namespace AbstractShape
{
    abstract class Point  //추상 클래스
    {
        protected double xpos;
        protected double ypos;

        public Point()
        {
            xpos = ypos = 0;
        }

        public Point(double _x, double _y)
        {
            xpos = _x;
            ypos = _y;
        }

        public abstract void Draw();  //추상메서드
    }

    class Rectangle : Point
    {
        private double width;
        private double height;

        public Rectangle()
        {
            width = height = 100.0;
        }

        public Rectangle(double _x, double _y, double _w, double _h) : base(_x, _y)
        {
            width = _w;
            height = _h;
        }

        public override void Draw()
        {
            Console.WriteLine("[Rectangle] Position = ({0},{1}), size = ({2} {3})", xpos, ypos, width, height);
        }
    }

    class Circle : Point
    {
        private double radius;

        public Circle()
        {
            radius = 100.0;
        }

        public Circle(double _x, double _y, double _r) : base(_x, _y)
        {
            radius = _r;
        }


        public override void Draw()
        {
            Console.WriteLine("[Circle] Position = ({0}, {1}), Radius= ({2})", xpos, ypos, radius);
        }
    }

    class ConsoleApplication
    {
        static void Main(string[] args)
        {

            Point r1 = new Rectangle(5, 5, 30, 40);
            r1.Draw();

            Point c1 = new Circle(150, 30, 40);
            c1.Draw();

        }
    }
}