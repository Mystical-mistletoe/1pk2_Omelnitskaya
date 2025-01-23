namespace Task_03_09
{
    internal class Program
    {
        /*
         * Вклад в банке составляет x рублей. 
         * Ежегодно он увеличивается на p процентов, 
         * после чего дробная часть копеек отбрасывается. 
         * Каждый год сумма вклада становится больше. 
         * Определите, через сколько лет вклад составит
         * не менее y рублей.
         * Примеры
         * входные данные
         * 100
         * 10
         * 200
         * выходные данные
         * 8
         */

        static void Main(string[] args)
        {
            // Ввод данных
            Console.WriteLine("Введите начальную сумму вклада:");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите процент увеличения:");
            double p = double.Parse(Console.ReadLine()) / 100; // преобразуем в доли

            Console.WriteLine("Введите итоговую сумму:");
            double y = double.Parse(Console.ReadLine());

            int years = 0;

            // Расчет количества лет
            while (x < y)
            {
                x += x * p;
                x = Math.Floor(x); // отбрасываем дробную часть
                years++;
            }
            Console.WriteLine($"Сумма вклада составит не менее {y} рублей через {years} лет.");
        }
    }
}
