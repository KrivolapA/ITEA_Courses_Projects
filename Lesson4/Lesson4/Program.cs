using System;

namespace Lesson4
{
    class NewClass
    {
        private PointClass point;
        private int i;

        NewClass()
        {
            i = 0;
            point = new PointClass();
        }

        NewClass(PointClass point)
        {
            this.point = point;
            
        }
    }
    enum Availiability
    {
        NotAvailiable,
        Availiable,
        Order
    }
    struct Pointstr
    {
        public int X;
        public int Y;
        //Program.Availiability
        /*Point(int x)
        {
            X = x;
            Y = 0;
        }*/
    }

    class PointClass
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void MyMethod(out int i, string str)
        {
            i = 20;
            Console.WriteLine("i = {0}",i);
        }
        static void MyMethodClass(PointClass i)
        {
            i.X += 20;
        }
       /* static void MyMethodStruct(Point i)
        {
            i.X += 20;
        }*/
        static void Main()
        {
           /* Point p =  new Point();
            Point p2 = p;
            p.X = 10;*/
            int j;
            Availiability a = Availiability.Availiable;
            a ^= Availiability.Availiable;
            //Console.Write((int)a);
            MyMethod(out j, "");
            Point p = new Point(2,3);
            p.DistTo();
            Console.WriteLine("j = {0}", j);
            PointClass pc = new PointClass();
            //pc.X = 100;
            PointClass newpc = new PointClass();
            //MyMethodClass(pc);
            //Console.WriteLine(pc.X);
            //MyMethodStruct(p);
            //Math.Sqrt((x1 - x2)*(x1 - x2)+ (y1 - y2) * (y1 - y2));
            //Console.WriteLine(p.X);
            Console.Read();
        }
    }
}

