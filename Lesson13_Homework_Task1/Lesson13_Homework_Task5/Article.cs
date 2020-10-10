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

    class Article
    {
        private string model;
        private string dealer;
        private double price;

        public string ModelName
        {
            get
            {
                return model;
            }
        }
        public string Dealer
        {
            get
            {
                return dealer;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }
        public Article(string model, string dealer, double price)
        {

            Console.WriteLine("Модель: {0}; Дилер : {1}; Ціна : {2} грн; ", this.model = model, this.dealer = dealer, this.price = price);
        }
    }
}
