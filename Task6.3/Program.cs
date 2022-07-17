using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите предложение:");
            string str = Console.ReadLine();
            string s2 = "{";
            string s3 = "}";
            //int a = 0;
            //int b = 0;
            //bool b = str.Contains(s2);
            //Console.WriteLine("'{0}' is in the string '{1}': {2}",
            // s2, str, b);
            //if (b)
            //{
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] == '{')
                    //a = i;
                   
                Console.WriteLine("'{0} позиция символа {1}", s2, i);

                if (str[i] == '}')
                   // b = i;

                Console.WriteLine("'{0} позиция символа {1}", s3, i);
                //str = str.Remove((a),(b));
            }  
            Console.WriteLine(str);
            Console.ReadKey();
        }
                
              //string[] str2= str.Split(new char[] { '{', '}' });
                //int num1 = str.IndexOf('{'); //номер в строке символа
                //int num2 = str.IndexOf('}'); //номер в строке символа
                //str = str.Remove(str.Length - (str.Length - num1), (str.Length - num1)); 
         

    }
}
