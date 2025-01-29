namespace Task_05_06
{
    internal class Program
    {
        /*Осуществить генерация двумерного [10*5] массива по 
         * следующему правилу:
         * • 1 столбец содержит нули
         * • 2 столбце содержит числа кратные 2
         * • 3 столбец содержит числа кратные 3
         * • 4 столбец содержит числа кратные 4
         * • 5 столбец содержит числа кратные 5
         * Осуществить переворот массива (поменять строки 
         * и столбцы местами) вывести обновленный массив
         */
        static void Main(string[] args)
        {
            int n = 10;
            int m = 5;

            int[,] numbers = new int[n, m];

            Random random = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                numbers[i, 0] = 0; // нули
                numbers[i, 1] = random.Next(1, 100) * 2; // кратные 2
                numbers[i, 2] = random.Next(1, 100) * 3; // кратные 3
                numbers[i, 3] = random.Next(1, 100) * 4; // кратные 4
                numbers[i, 4] = random.Next(1, 100) * 5; // кратные 5
            }

            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("переворот массива:");
            Console.WriteLine();

            for (int j = 0; j < numbers.GetLength(0); j++)
            {
                for (int i = 0; i < numbers.GetLength(1); i++)
                {
                    Console.Write(numbers[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
