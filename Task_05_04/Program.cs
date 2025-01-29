namespace Task_05_04
{
    internal class Program
    {
        /*
         * Дан квадратный массив размерность n*n. 
         * Произведите анализ данной матрицы и 
         * выясните является ли данная матрица 
         * диагональной (все элементы вне главной 
         * диагонали равны нулю)
         * Если матрица является диагональной, 
         * то вывести ее повторно с цветовым 
         * выделением главной диагонали. Если нет, 
         * то вывеси сообщение что матрица не 
         * является диагональной
         */
        static void Main(string[] args)
        {
            int n = 3;

            int[,] numbers = new int[n, n];
            bool flag = false;
            Random random = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(0, 2);
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] != 0 && i != j)
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("матрица не является диагональной");
            }
            else
            {
                Console.WriteLine("вывод матрицы с выделением главной диагонали:");
                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(0); j++)
                    {
                        if (i ==j)
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
