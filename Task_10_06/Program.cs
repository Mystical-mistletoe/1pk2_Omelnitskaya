namespace Task_10_06
{
    internal class Program
    {
        /*Создать Метод ArrayGeneration не возвращающий 
         * значения, принимает целое число n, выводит 
         * на консоль сгенерированный массив размерности n*n.
        */
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите целое число для генерации массива:");
                int n = Convert.ToInt32(Console.ReadLine());

                ArrayGeneration(n);
            }

        }
        /// <summary>
        /// генерация двумерного массива размерности n*n
        /// </summary>
        /// <param name="n">целое число, размер квадратного массива</param>
        /// <returns></returns>
        static void ArrayGeneration(int n)
        {
            Random random = new Random();
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = random.Next(-99, 100);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
