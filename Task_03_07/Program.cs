namespace Task_03_07
{
    internal class Program
    {
        /*
         * Написать программу, которая выводит 
         * таблицу скорости (через каждые 0,5с)
         * свободно падающего тела v = g t , 
         * где 2 g = 9,8 м/с2 – ускорение 
         * свободного падения.
         */

        static void Main(string[] args)
        {
            double g = 9.8; // ускорение свободного падения
            double timeInterval = 0.5; // интервал времени в секундах
            double maxTime = 10;

            Console.WriteLine("Время (c)-->Скорость (м/с)");

            for (double t = 0; t <= maxTime; t += timeInterval)
            {
                double v = g * t; // вычисление скорости
                Console.WriteLine($"{Math.Round(t, 2)}\t|\t{Math.Round(v, 2)}");
            }
        }
    }
}
