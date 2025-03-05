namespace Task_10_08
{
    internal class Program
    {
        /*Создайте метод, который на вход принимает 
         * одномерный массив и число для поиска, 
         * верните индекс искомого элемента в массиве. 
         * Если элемента нет – верните индекс = -1
        */
        static void Main(string[] args)
        {

            while (true) // для удобства проверки
            {
                Console.WriteLine("Введите целое число для генерации массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите число для поиска:");
                int founding = Convert.ToInt32(Console.ReadLine());

                
                int[] numbers = ArrayGeneration(n);
                PrintArray(numbers);
                Console.WriteLine("Индекс искомого элемента:");
                Console.WriteLine(Find(numbers, founding));
            }

        }
        /// <summary>
        /// генерация массива размерности n*m
        /// </summary>
        /// <param name="n">целое число, размер  массива</param>
        /// <returns></returns>
        public static int[] ArrayGeneration(int n)
        {
            Random random = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 51);
            }
            return array;
        }
        /// <summary>
        /// вывод на консоль массива
        /// </summary>
        /// <param name="array">вх массив</param>
        /// <returns></returns>
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// поиск индекса элемента
        /// </summary>
        /// <param name="numbers">вх массив</param>
        /// <param name="founding">искомое число</param>
        /// <returns>индекс числа</returns>
        public static int Find(int[] numbers, int founding)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == founding) // Если нашли число
                {
                    return i;
                }
            }
            return -1; // если нет -1
        }
    }
}
