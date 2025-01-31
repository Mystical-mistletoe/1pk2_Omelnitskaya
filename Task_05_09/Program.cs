namespace Task_05_09
{
    internal class Program
    {
        /*Дан квадратный массив размерность n*n. 
         * Произведите анализ данной матрицы и 
         * выясните является ли данная матрица Z-матрицей
         * (это матрица, где все недиагональные элементы 
         * меньше нуля)
         * Если данное условие выполняется то вывести 
         * данную матрицу с цветовой индикацией главной 
         * диагонали. Если не выполняется, то
         * вывести сообщение что данная матрица 
         * не является Z-матрицей
         */
        static void Main(string[] args)
        {
            int[,] numbers = {
                { 1,-1,-1,-1, 1},
                { -1, 1, -1, 1, -1},
                { -1, - 1, 1, -1, -1},
                { -1, 1, -1, 1, -1},
                { 1, - 1, -1, - 1, 1},
            };
            bool flag = false;

            //заполнение массива - для проверки других вариантов
            /*
            Console.WriteLine("Введите размер квадратной матрицы:");
            int n = Int32.Parse(Console.ReadLine());

            int[,] numbers = new int[n, n];
            Random random = new Random();
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(-1, 2);
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            */

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] >= 0 && i != j && i != numbers.GetLength(0) - j - 1)
                    {
                        flag = true;
                        break;
                    }
                    if (numbers[i, j] <= 0 && (i == j || i == numbers.GetLength(0)- j - 1))
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("матрица не является Z-матрицей");
            }
            else
            {
                Console.WriteLine("вывод матрицы с выделением главной диагонали:");
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(0); j++)
                    {
                        if (i == j)
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
}
