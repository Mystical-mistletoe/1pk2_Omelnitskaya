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

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(10, 100);
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
