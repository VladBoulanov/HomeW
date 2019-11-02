using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp10
{
    class Array1Demo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine("Здравствуйте, " + name);
            Console.ReadKey();
            Thread.Sleep(5000);
            Console.WriteLine("До свидания, " + name);
            Console.ReadKey();
        }
    }
}
