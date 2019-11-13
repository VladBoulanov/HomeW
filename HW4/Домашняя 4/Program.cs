using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашняя_4
{
    class Program
    {
        [Flags]
        public enum Volume
        {
            Littre1=0x1,
            Littre5 = 0x2,
            Littre20 = 0x4
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Какой объем сока требуется упаковать?");
            string answer = Console.ReadLine();
            decimal v;
            if(decimal.TryParse(answer,out v))
                {
                int volume = (int)Math.Ceiling(v);
                int littre20 = volume / 20;
                int littre5 = (volume - littre20 * 20);
                int littre1 = (volume - littre20 * 20 - littre5 * 5);
                int presence = 0;
                if(littre1>0)
                {
                    presence |= (int)Volume.Littre1;
                }
                if (littre5 > 0)
                {
                    presence |= (int)Volume.Littre5;
                }
                if (littre20 > 0)
                {
                    presence |= (int)Volume.Littre20;
                }
                Console.WriteLine("Вам понадобятся следующие контейнеры");
                if((presence  & (int)Volume.Littre20) != 0)
                {
                    Console.WriteLine("20 л:{0} шт.", littre20);
                }
                if ((presence & (int)Volume.Littre5) != 0)
                {
                    Console.WriteLine("5 л:{0} шт.", littre5);
                }
                if ((presence & (int)Volume.Littre1) != 0)
                {
                    Console.WriteLine("1 л:{0} шт.", littre1);
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода,до свидания!");
            }
        }
    }
}
