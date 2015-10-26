using System;
using System.Security.Cryptography.X509Certificates;

namespace Lesson4
{
    class Point
    {
        private int x;
        private int y;
        private static int x0;
        private static int y0;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point() : this(0, 0)
        {}

        public int X
        {
            get { return x; }
            private set { x = value; }
        }
        public int Y
        {
            get { return y; }
            private set { y = value; }
        }

        public static int DistBetween(int x1, int y1, int x2, int y2)
        {
            return (int) Math.Sqrt((x1 - x2) ^ 2 + (y1 - y2) ^ 2);
        }

        public int DistTo(int x = 0, int y = 0)
        {
            return DistBetween(x,y, this.x, this.y);
        }

        public int DistTo(Point p)
        {
            DistTo();
            return DistBetween(p.X, p.Y, x, y);
        }

        public int DistTo()
        {
            Console.WriteLine();
            return DistBetween(x, y, x0, y0);
        }
    }
}
