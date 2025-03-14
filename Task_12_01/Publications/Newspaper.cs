using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    internal class Newspaper
    {
        public string publicationDate; //поле класса - хранит дату издания газеты
        public string title; //поле класса - хранит название газеты
        public string headNewspaper; //поле класса - хранит заголовок главной полосы газеты
        public int pageCount; //поле класса - хранит количество страниц
        public double price; //поле класса - хранит цена
        bool isBuy = false; //поле класса - статус продано/нет

        //метод класса - печатает в консоль информацию о газете
        public void GetInfo()
        {
            Console.WriteLine($"{title}. Дата издания - {publicationDate}, количество страниц - {pageCount}");
        }
        //метод класса - покупка газеты
        public void BuyNewspaper()
        {
            if (isBuy)
                Console.WriteLine($"Газета {title} отсутствует в продаже ");
            else
            {
                Console.WriteLine($"Газета {title} приобретенa");
                isBuy = true;
            }
        }
        //метод класса - просмотр содержания газеты
        public void ViewNewspaper()
        {
            if (isBuy)
            {
                Console.WriteLine($"Газета {title}. Содержание: {headNewspaper}");
            }
            else
            {
                Console.WriteLine($"Невозможно посмотреть содержание: газета {title} не куплена");
            }
        }
    }
}
