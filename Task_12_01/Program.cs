using Task_12_01.Publications;

namespace Task_12_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


            book1.autor = "Рей Бредберри";
            //book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            //выдача книги
            book2.GetBook(); // книга выдана на неделю

            //попытка выдать уже занятую книгу
            book2.GetBook(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю

            //попытка вернуть занятую книгу
            book2.ReturnBook(); // книга Гарри Поттер и философский камень возвращена

            //повторная выдача книги (для проверки)
            book2.GetBook(); // книга выдана на неделю

            Console.WriteLine();

            Journal journal1 = new Journal();
            journal1.title = "Придира";
            journal1.pageCount = 28;
            journal1.publicationDate = "14.03.2025";
            journal1.subjectArea = "Универсальная специализация";
            journal1.price = 120.59;
            journal1.content = "Мозгошмыг (англ. Wrackspurts) — мелкое летающее существо, ...";
            journal1.GetInfo();

            //покупка журнала
            journal1.BuyJournal(); // куплен

            //попытка купить уже купленный журнал
            journal1.BuyJournal(); // не выходит

            //просмотр содержания купленного журнала
            journal1.ViewJournal();

            Console.WriteLine();

            Journal journal2 = new Journal();
            journal2.title = "Мурзилка";
            journal2.pageCount = 34;
            journal2.publicationDate = "14.03.2025";
            journal2.price = 89;
            journal2.content = "Что-то очень интересное";
            journal2.GetInfo();

            //просмотр содержания НЕ купленного журнала
            journal2.ViewJournal();

            Console.WriteLine();

            Newspaper newspaper1 = new Newspaper();
            newspaper1.title = "Ежедневный пророк";
            newspaper1.pageCount = 6;
            newspaper1.publicationDate = "13.03.2025";
            newspaper1.price = 80;
            newspaper1.headNewspaper = "Сенсация! Мальчик-который-выжил на самом деле ...";
            newspaper1.GetInfo();

            //покупка газеты
            newspaper1.BuyNewspaper(); // куплена

            //попытка купить уже купленную газету
            newspaper1.BuyNewspaper(); // не выходит

            //просмотр содержания купленной газеты
            newspaper1.ViewNewspaper();

            Console.WriteLine();

            Newspaper newspaper2 = new Newspaper();
            newspaper2.title = "Какая-то другая газета";
            newspaper2.pageCount = 3;
            newspaper2.publicationDate = "01.11.1941";
            newspaper2.price = 20;
            newspaper2.headNewspaper = "Что-то очень интересное";
            newspaper2.GetInfo();

            //просмотр содержания НЕ купленной газеты
            newspaper2.ViewNewspaper();

        }
    }
}
