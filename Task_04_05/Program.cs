namespace Task_04_05
{
    internal class Program
    {
        /*В массиве хранятся сведения о количестве 
         * осадков за месяц (30 дней). 
         * Необходимо 
         * определить общее количество осадков, 
         * выпавших за каждую декаду месяца, 
         * 
         * вывести день с самыми сильными 
         * осадками за месяц и 
         * 
         * отдельно вывести дни без осадков. 
         * 
         * Массив с 
         * осадками заполнятся с помощью рандома в 
         * диапазоне от 0 – нет осадков, до 300 мм 
         * выпавших осадков.
        */
        static void Main(string[] args)
        {
            // Инициализация переменных
            int n = 30;
            int[] precipitation = new int[n];
            Random random = new Random();

            // Заполнение массива случайными значениями осадков
            for (int i = 0; i < n; i++)
            {
                precipitation[i] = random.Next(0, 301); // Значение от 0 до 300 мм

            }

            // Вычисление осадков по декадам
            // декада - 10 дней
            for (int i = 0; i < (n/10); i++)
            {
                int decadePrecipitation = 0;
                for (int j = 0; j < 10; j++)
                {
                    decadePrecipitation += precipitation[i * 10 + j];
                }
                Console.WriteLine($"Общее количество осадков за {i + 1}-ю декаду: {decadePrecipitation} мм");
            }

            // Нахождение дня с самыми сильными осадками и дней без осадков
            int maxPrecipitation = 0;
            int maxPrecipitationDay = 0;
            Console.WriteLine("Дни без осадков:");

            for (int i = 0; i < n; i++)
            {
                if (precipitation[i] == 0)
                {
                    Console.WriteLine($"День {i + 1}");
                }
                else
                {
                    if (precipitation[i] > maxPrecipitation)
                    {
                        maxPrecipitation = precipitation[i];
                        maxPrecipitationDay = i + 1;
                    }
                }
            }

            // Вывод информации о самом дождливом дне
            if (maxPrecipitationDay != 0)
            {
                Console.WriteLine($"Самые сильные осадки были в день {maxPrecipitationDay}: {maxPrecipitation} мм");
            }
            else
            {
                Console.WriteLine("Нет дней с осадками.");
            }



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(precipitation[i]);
            }


        }
    }
}
