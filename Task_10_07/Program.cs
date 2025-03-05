using System.Text;

namespace Task_10_07
{
    internal class Program
    {
        /*Создайте метод с помощью которого 
         * можно сгенерировать и вернуть символьный 
         * двумерныймассив(состоящийиз символов русского 
         * алфавита) и выведите на консоль данный массив с 
         * помощью другого метода(которыйпринимает данный 
         * массив в качестве параметра)
        */
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Введите целые числа для генерации массива:");
                int n = Convert.ToInt32(Console.ReadLine());
                int m = Convert.ToInt32(Console.ReadLine());

                PrintArray(ArrayGeneration(n, m));
            }

        }
        /// <summary>
        /// генерация двумерного массива размерности n*m
        /// </summary>
        /// <param name="n">целое число, размер  массива</param>
        /// <param name="m">целое число, размер массива</param>
        /// <returns></returns>
        public static char[,] ArrayGeneration(int n, int m)
        {
            Random random = new Random();
            char[,] array = new char[n, m];
            string russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = russianAlphabet[random.Next(russianAlphabet.Length)];
                }
            }
            return array;
        }
        /// <summary>
        /// вывод на консоль двумерного массива
        /// </summary>
        /// <param name="array">вх массив</param>
        /// <returns></returns>
        static void PrintArray(char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
