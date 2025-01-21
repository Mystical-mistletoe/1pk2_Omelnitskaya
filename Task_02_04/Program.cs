namespace Task_02_04
{
    internal class Program
    {
        /*
         Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите 
            расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об 
            этом

        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату");
            int day = Int32.Parse(Console.ReadLine());


            var a = (year * 100 + month) * 100 + day;
            var b = (2025 * 100 + 1) * 100 + 18;

            int answer = (b - a) / 10000;
            string text = answer >= 18 ? "вы являетесь совершеннолетним" : "вы не являетесь совершеннолетним";

            Console.WriteLine(text);
            /*
             * это код с проверкой условия правильности введенного года относительно нынешней даты

            if (year < 2026 && month < 2 && day < 19)
            {
                var a = (year * 100 + month) * 100 + day;
                var b = (2025 * 100 + 1) * 100 + 18;

                Console.WriteLine((b - a) / 10000);
            }

            else
            {
                Console.WriteLine("вы ввели неверную дату (превышающую нынешнюю");
            }
            */


            /*
             * DateTime date1 = new DateTime(year, month, datte); // год - месяц - день

               Console.WriteLine(date1);



            DateTime now = DateTime.Now;

            Console.WriteLine($"Дата: {now.Date}");
            Console.WriteLine($"date1.Subtract: {now.Subtract(date1)}");
            */
        }
    }
}
