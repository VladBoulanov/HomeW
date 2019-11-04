using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число");
            int b = int.Parse(Console.ReadLine());
            char operand = char.Parse(Console.ReadLine());
            if(operand == '+')
            {
                Console.WriteLine("a + b = " + (a + b));
            }
            if (operand == '-')
            {
                Console.WriteLine("a - b = " + (a - b));
            }
            if (operand == '*')
            {
                Console.WriteLine("a * b = " + (a * b));
            }
            if (operand == '/')
            {
                Console.WriteLine("a / b = " + (a / b));
            }
            if (operand == '%')
            {
                Console.WriteLine("a % b = " + (a % b));
            }
            if (operand == '^')
            {
                Console.WriteLine("a ^ b = " + (a ^ b));
            }
        }
    }
}
