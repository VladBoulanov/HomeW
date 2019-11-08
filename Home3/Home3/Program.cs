using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[3];
            int [] age = new int[3];
            Console.WriteLine("Введите имя");
            name[0] = "Влад";
            name[1] = "Андрей";
            name[2] = "Ольга";
            age[0] = 20;
            age[1] = 30;
            age[2] = 24;
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("name:" + name[i] + " ,age in 4 years: " + age[i]);
            }
            
        }
    }
}
