using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Homework_Task5
{
    /*Створити клас Article, що містить наступні закриті поля:
    • назва товару;
    • назва магазину, в якому продається товар;
    • вартість товару в гривнях.
    Створити клас Store, який містить закритий масив елементів типу Article.
    Забезпечити такі можливості:
    • вивідна екран інформації про товар за номером за допомогою індексу;
    • вивідна екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, вивести відповідне повідомлення;
    Написати програму, виведення на екран інформацію про товар.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть індекс моделі:\n0 - RX350;\n1 - GS300t;\n2 - ES300 HYBRID;\n3 - LX450d");
            int modelNumber = Int32.Parse(Console.ReadLine());

            Store store = new Store();

            switch (modelNumber)
            {
                case 0:
                    {
                        store[0] = new Article("Lexus RX350", "Лексус Львів Діамант", 2000000);
                        break;
                    }
                case 1:
                    {
                        store[0] = new Article("Lexus GS300t", "Лексус Плаза Київ", 1875000);
                        break;
                    }
                case 2:
                    {
                        store[0] = new Article("Lexus ES300 HYBRID", "Тойота на Столичному шоссе", 1680000);
                        break;
                    }
                case 3:
                    {
                        store[0] = new Article("Lexus LX450d", "Тойота Центр Одеса", 3465000);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Моделі за таким інлексом немає.");
                        break;
                    }
            }
            Console.WriteLine("Введіть назву моделі:\nRX350;\nGS300t;\nES300 HYBRID;\nLX450d");
            string modelName = Console.ReadLine();

            switch(modelName)
            {
                case "RX350":
                    {
                        store[0] = new Article("Lexus RX350", "Лексус Львів Діамант", 2000000);
                        break;
                    }
                case "GS300t":
                    {
                        store[0] = new Article("Lexus GS300t", "Лексус Плаза Київ", 1875000);
                        break;
                    }
                case "ES300 HYBRID":
                    {
                        store[0] = new Article("Lexus ES300 HYBRID", "Тойота на Столичному шоссе", 1680000);
                        break;
                    }
                case "LX450d":
                    {
                        store[0] = new Article("Lexus LX450d", "Тойота Центр Одеса", 3465000);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такої моделі немає.");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
