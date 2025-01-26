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

            //вычисление количества лет
            var a = (year * 100 + month) * 100 + day;
            var b = (2025 * 100 + 1) * 100 + 18;

            int answer = (b - a) / 10000;
            string text = answer >= 18 ? "вы являетесь совершеннолетним" : "вы не являетесь совершеннолетним";

            Console.WriteLine(text);
        }
    }
}
