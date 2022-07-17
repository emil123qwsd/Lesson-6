using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение:");
            string str = Console.ReadLine();
            str = str.ToLower().Replace(" ", string.Empty);
            string str2 = "";
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            str2 = str2.ToLower().Replace(" ", string.Empty);
            Console.WriteLine("Справа налево: {0}", str2);
            if (str == str2)
            {
                Console.WriteLine("Строка палиндром!");
            }
            else
                Console.WriteLine("Строка не палиндром!");
            Console.ReadKey();
        }
    }
}
