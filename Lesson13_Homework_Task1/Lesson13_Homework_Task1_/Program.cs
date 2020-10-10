using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Homework_Task1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Dictionary dictionary = new Dictionary();

            Console.WriteLine(dictionary["книга"]);
            Console.WriteLine(dictionary["будинок"]);
            Console.WriteLine(dictionary["ручка"]);
            Console.WriteLine(dictionary["стіл"]);
            Console.WriteLine(dictionary["олівець"]);
            Console.WriteLine(dictionary["яблуко"]);
            Console.WriteLine(dictionary["сонце"]);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.ReadKey();

        }
    }
}