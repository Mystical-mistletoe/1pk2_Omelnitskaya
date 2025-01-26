namespace Task_04_07
{
    internal class Program
    {
        /*В массиве на 30 элементов содержатся данные 
         * по росту учеников в классе. Рост мальчиков 
         * условно задан отрицательными значениями. 
         * Вычислить и вывести количество мальчиков 
         * и девочек в классе и средний рост для 
         * мальчиков и девочек. При выводе 
         * избавиться от отрицательных значений.
         */
        static void Main(string[] args)
        {
            // Определяем массив ростов учеников
            int[] heights = new int[30];
            Random random = new Random();

            // Заполнение массива случайными значениями роста
            for (int i = 0; i < heights.Length; i++)
            {
                // Генерация роста для девочек от 130 до 180 см (положительные значения)
                // Генерация роста для мальчиков от -130 до -180 см (отрицательные значения)
                heights[i] = random.NextDouble() > 0.5 ? random.Next(130, 181) : -random.Next(130, 181);
            }

            // Переменные для подсчета
            int boysCount = 0;
            int girlsCount = 0;
            int boysSum = 0;
            int girlsSum = 0;

            // Обработка массива
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] < 0) // Мальчики
                {
                    boysCount++;
                    boysSum += Math.Abs(heights[i]);
                }
                else // Девочки
                {
                    girlsCount++;
                    girlsSum += heights[i];
                }
            }

            // Вычисление средних значений
            double boysAverage = boysCount > 0 ? (double)boysSum / boysCount : 0;
            double girlsAverage = girlsCount > 0 ? (double)girlsSum / girlsCount : 0;

            // Вывод результатов
            Console.WriteLine($"Количество мальчиков: {boysCount}");
            Console.WriteLine($"Количество девочек: {girlsCount}");
            Console.WriteLine($"Средний рост мальчиков: {Math.Round(boysAverage, 2)} см");
            Console.WriteLine($"Средний рост девочек: {Math.Round(girlsAverage, 2)} см");


        }
    }
}
