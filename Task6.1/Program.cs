﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение:");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string min = strArray[0];
            foreach (string s in strArray)
            {
                if (s.Length > min.Length)
                {
                    min = s;
                }
            }
            Console.WriteLine("Самаое длинное слово:");
            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
