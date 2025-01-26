namespace Task_04_04
{
    internal class Program
    {
        /*В массиве хранится вес товаров, загружаемых в 
         * контейнер. Количество товаров = 30, вес 
         * товаров в диапазоне от 5,00 до 50,00 кг 
         * (использовать заполнение рандомом). 
         * Грузоподъемность контейнера 1 тонна. 
         * Определить, насколько превышает 
         * общий вес товаров грузоподъемность.
        */
        static void Main(string[] args)
        {
            // Инициализация переменных
            int n = 30;
            double[] weights = new double[n];
            Random random = new Random();
            double totalWeight = 0.0;
            double containerCapacity = 1000.0; // грузоподъемность в кг (1 тонна)

            // Заполнение массива случайным весом товаров
            for (int i = 0; i < n; i++)
            {
                weights[i] = Math.Round(random.NextDouble() * (50.0 - 5.0) + 5.0, 2); // вес от 5.00 до 50.00
                //RandomObj.NextDouble() * (end - begin) + begin
                totalWeight += weights[i];
            }

            // Вывод общего веса товаров
            Console.WriteLine("Общий вес товаров: " + Math.Round(totalWeight, 2) + " кг");

            // Определение превышения грузоподъемности
            if (totalWeight > containerCapacity)
            {
                double exceedingWeight = totalWeight - containerCapacity;
                Console.WriteLine("Превышение грузоподъемности контейнера на: " + exceedingWeight + " кг");
            }
            else
            {
                Console.WriteLine("Грузоподъемность контейнера не превышена.");
            }
        }
    }
}
