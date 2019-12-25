using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> charList = new List<char> (Console.ReadLine());
            int cht = 0;
            int sum = 0;
            foreach (char number in charList)
            {
                if (number=='(')
                {
                    cht++;
                }
                else if(number == ')')
                {
                    cht--;
                }
               else if(number == '[')
               {
                   sum++;
               }
               else if (number == ']')
               {
                   sum--;
               }

            }
            if (cht == 0 || sum == 0)
                Console.WriteLine("Правильно");
            else
                Console.WriteLine("Неправильно");
            
        }
    }
}
