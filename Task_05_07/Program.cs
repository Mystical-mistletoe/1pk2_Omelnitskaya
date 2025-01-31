namespace Task_05_07
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается число n,
         * генерируется квадратный массив целых числе [n*n]. 
         * Заполнение случайными числами в диапазоне от 10 
         * до 99 включительно.
         * 
         * Найти и вывести отдельно минимальный элемент в 
         * матрице (LINQ под запретом) Осуществить умножение 
         * матрицы на ее минимальный элемент, при выводе 
         * цветом выделить пять максимальных значений в массиве
         *
         */
        static void Main(string[] args)
        {
            Console.WriteLine("введите n - размер массива");
            int n = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, n];
            Random random = new Random();
            int minElement = 100;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(10, 100);
                    Console.Write(numbers[i, j] + " ");
                    if (numbers[i, j] < minElement)
                    {
                        minElement = numbers[i, j];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Минимальный элемент матрицы: {minElement}");
            
            //матрица с умножением на элемент

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = numbers[i, j] * minElement;
                }
            }

            int[] maxValues = new int[numbers.GetLength(0)*numbers.GetLength(1)];

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    maxValues[i * numbers.GetLength(0) + j] = numbers[i, j];
                }

            }

            Array.Sort(maxValues);
            Array.Reverse(maxValues);

            Console.WriteLine("Умноженная матрица с выводом пяти максимальных значений:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Проверка на максимальные значения
                    if (numbers[i, j] == maxValues[0] ||
                        numbers[i, j] == maxValues[1] ||
                        numbers[i, j] == maxValues[2] ||
                        numbers[i, j] == maxValues[3] ||
                        numbers[i, j] == maxValues[4])
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    Console.Write(numbers[i, j] + " ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }

        }
    }
}
