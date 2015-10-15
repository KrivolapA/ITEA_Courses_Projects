using System;
using System.Globalization;

namespace Lesson2
{
    class Program
    {
        //static int radius = 1l;
        static void Main()
        {
            /*byte b = 255;
            unchecked
            {
                
                Console.WriteLine(sizeof(int));
                
            }
            
            int i = 1;
            int j = 2;
            //bool b = i > 0 & (j=3)>2;
            Console.WriteLine(j);
            
            decimal f = 0.5m;
            //int i = 0;
            //i = i++ + i++;
            Console.WriteLine( i);*/
            int i = 1;
            int j = 100;
            const double pi = 3.14;
            Console.Write("Введите радиус:");
            int radius = Int32.Parse(Console.ReadLine());
            Console.Write("Введите сторону квадрата:");
            int side = int.Parse(Console.ReadLine());
            int square = (int) (pi*radius*radius);
            //Console.WriteLine("{0},   {1}",square, pi * radius * radius);
            Console.WriteLine("Радиус круга = {0}, Площадь = {1}", radius, square);
            int square2 =  side * side;
            Console.WriteLine("Сторона квадрата = {0}, Площадь = {1}", side, square2);
            Console.WriteLine(square > square2 ? "Круг больше": " Квадрат больше");
            i = (j > 10 ? 3 : 2)*i;
            Console.ReadLine();
        }
    }
}
