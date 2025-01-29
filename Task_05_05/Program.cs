namespace Task_05_05
{
    internal class Program
    {
        /*У пользователя в консоли запрашивается 
         * числа n и m, генерируется прямоугольный 
         * массив целых числе [n*m]. Заполнение 
         * случайными числами в диапазоне от -99 
         * до 99 включительно. Осуществите без 
         * создания нового массива преобразование текущего 
         * по следующему правилу:
         * 
         * • Если элемент меньше нуля, то отбрасываем знак 
         * и выделяем при выводе зеленым цветом
         * 
         * • Если элемент равен нулю, то перезаписываем 
         * единицу и выделяем при выводе красным цветом
         */
        static void Main(string[] args)
        {
            Console.WriteLine("введите n, m - размеры прямоугольного массива");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] numbers = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(-99, 100);
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] < 0)
                    {
                        numbers[i, j] = Math.Abs(numbers[i, j]);
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (numbers[i, j] == 0)
                    {
                        numbers[i, j] = 1;
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    Console.Write(numbers[i, j] + " ");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine();
            }

        }
    }
}
