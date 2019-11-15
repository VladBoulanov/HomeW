using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        [Flags]
        public enum figure
        {
            Circle=1,
            Triangle=2,
            Rectangle=3
        }
        static void Main(string[] args)
        {
            try
            {
                int type = (int)figure.Circle;
                string message;
                switch (type)
                {
                    case 1:
                        message = "Круг";
                        int r = int.Parse(Console.ReadLine());
                        int d = 2 * r;
                        double Pc = d * 3.14;
                        Console.WriteLine("Периметр круга:{0} ", Pc);
                        double Sc = Pc * r / 2;
                        Console.WriteLine("Площадь круг:{0} ", Sc);
                        goto case 2;
                    case 2:
                        message = "Треугольник";
                        int a = int.Parse(Console.ReadLine());
                        double h = Math.Sqrt(Math.Pow(a, 2) - Math.Pow(a / 2, 2));
                        int Pt = a * 3;
                        Console.WriteLine("Периметр треугольника:{0} ", Pt);
                        double St = a * h / 2;
                        Console.WriteLine("Площадь треугольника:{0} ", St);
                        goto case 3;
                    case 3:
                        message = "Прямоугольник";
                        int b = int.Parse(Console.ReadLine());
                        int c = int.Parse(Console.ReadLine());
                        int Pr = 2 * (b + c);
                        Console.WriteLine("Периметр прямоугольника:{0} ", Pr);
                        int Sr = b * c;
                        Console.WriteLine("Площадь прямоугольника:{0} ", Sr);
                        break;
                    default:
                        Console.WriteLine("Ошибка! Введено нечисловое значение!");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Ошибка! Введено нечисловое значение!");
            }
        }
    }
}
