using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    internal class Journal
    {
        public string publicationDate; //поле класса - хранит дату издания
        public string subjectArea; //поле класса - хранит предметно-тематическая направленность журнала
        public string title; //поле класса - хранит название журнала
        public int pageCount; //поле класса - хранит количество страниц
        public double price; //поле класса - хранит цена
        public string content; //поле класса - хранит содержание журнала
        bool isBuy = false; //поле класса - статус продано/нет
        //метод класса - печатает в консоль информацию о журнале
        public void GetInfo()
        {
            Console.WriteLine($"{title}. Дата издания - {publicationDate}, предметно-тематическая направленность - {subjectArea}, количество страниц - {pageCount}");
        }
        //метод класса - покупка журнала
        public void BuyJournal()
        {
            if (isBuy)
                Console.WriteLine($"Журнал {title} отсутствует в продаже ");
            else
            {
                Console.WriteLine($"Журнал {title} приобретен");
                isBuy = true;
            }
        }
        //метод класса - просмотр содержания журнала
        public void ViewJournal()
        {
            if (isBuy)
            {
                Console.WriteLine($"Журнал {title}. Содержание: {content}");
            }
            else
            {
                Console.WriteLine($"Невозможно посмотреть содержание: журнал {title} не куплен");
            }
        }
    }
}
