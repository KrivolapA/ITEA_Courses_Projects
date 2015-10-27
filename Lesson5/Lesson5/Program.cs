using System;

namespace Lesson5
{
    class Program
    {
        static void Main()
        {
            bool cont = true;
            while (cont)
            {
                Console.Clear();
                Console.WriteLine("1. Площадь треугольника");
                Console.WriteLine("2. Периметр треугольника");
                Console.WriteLine("3. Площадь квадрата");
                Console.WriteLine("4. Периметр квадрата");
                Console.WriteLine("5. Площадь круга");
                Console.WriteLine("6. Периметр круга");
                Console.Write("Введите ваш выбор или другое значение для выхода:");
                string choice = Console.ReadLine();
                int c;
                Console.Clear();
                if (int.TryParse(choice, out c))
                {
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("Площадь треугольника");
                            Console.WriteLine("Введите стороны");
                            int tra, trb, trc;
                            int.TryParse(Console.ReadLine(), out tra);
                            int.TryParse(Console.ReadLine(), out trb);
                            int.TryParse(Console.ReadLine(), out trc);
                            Triangle tr = new Triangle(tra, trb, trc);
                            Console.WriteLine("Площадь равна {0}", tr.S());
                            break;
                        case 2:
                            Console.WriteLine("Периметр треугольника");
                            Console.WriteLine("Введите стороны");
                            int.TryParse(Console.ReadLine(), out tra);
                            int.TryParse(Console.ReadLine(), out trb);
                            int.TryParse(Console.ReadLine(), out trc);
                            tr = new Triangle(tra, trb, trc);
                            Console.WriteLine("Периметр равен {0}", tr.P());
                            break;
                        case 3:
                            Console.WriteLine("Площадь квадрата");
                            Console.WriteLine("Введите сторону");
                            int sa;
                            int.TryParse(Console.ReadLine(), out sa);
                            Square sq = new Square(sa);
                            Console.WriteLine("Площадь равна {0}", sq.S());
                            break;
                        case 4:
                            Console.WriteLine("Периметр квадрата");
                            Console.WriteLine("Введите сторону");
                            int.TryParse(Console.ReadLine(), out sa);
                            sq = new Square(sa);
                            Console.WriteLine("Периметр равен {0}", sq.P());
                            break;
                        case 5:
                            Console.WriteLine("Площадь круга");
                            Console.WriteLine("Введите сторону");
                            int cr;
                            int.TryParse(Console.ReadLine(), out cr);
                            Circle cl = new Circle(cr);
                            Console.WriteLine("Площадь равна {0}", cl.S());
                            break;
                        case 6:
                            Console.WriteLine("Периметр круга");
                            Console.WriteLine("Введите сторону");
                            int.TryParse(Console.ReadLine(), out cr);
                            cl = new Circle(cr);
                            Console.WriteLine("Периметр равен {0}", cl.P());
                            break;
                        default:
                            Console.WriteLine("Вы точно хотите выйти?");
                            choice = Console.ReadLine();
                            switch (choice)
                            {
                                case "Y":
                                case "y":
                                    cont = false;
                                    break;
                                case "N":
                                case "n":
                                    cont = true;
                                    break;
                            }
                            break;
                    }
                    /*if (c > 0)
                    c *= 2;
                else if (c == 0)
                    Console.WriteLine("нулевой баланс");
                else
                    c *= 3;*/
                }
                else
                {
                    Console.WriteLine("Неправильный ввод");
                }
                Console.ReadLine();
            }
        }
    }
}
