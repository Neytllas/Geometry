using System;

namespace Geometry
{
    enum Figures { Romb, Rect, RightTriangle, Circle }
    struct Fdata
    {
        public int x0, y0;
        public double a, b;
        public int color;
        public Figures type;
    }
    class Program
    {
        static double area(Fdata fd)
        {
            double res = 0;

            switch (fd.type)
            {   
                case Figures.Romb:
                    res = (fd.a * fd.b) / 2;
                    break;
                case Figures.Rect:
                    res = fd.a * fd.b;
                    break;
                case Figures.RightTriangle:
                    res = (fd.a * fd.b) / 2;
                    break;

                case Figures.Circle:
                    res = Math.PI * Math.Pow(fd.a, 2);
                    break;
            }

            return res;
        }
        static void Main(string[] args)
        {
            Fdata fd = new Fdata() { a = 4, b = 3, type = Figures.Romb };
            Console.WriteLine(area(fd));
            Console.ReadLine();
        }
    }
}
