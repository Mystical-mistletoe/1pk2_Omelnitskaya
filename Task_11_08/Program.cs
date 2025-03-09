namespace Task_11_08
{
    internal class Program
    {
        /*Использование params и out: 
         * Напишите метод, который принимает 
         * переменное количество чисел и 
         * возвращает их сумму и максимальное 
         * значение через выходные параметры (out)
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 99);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            int numAddition, numMax;
            AverageValue(out numAddition, out numMax, array);
            Console.WriteLine($"Сумма чисел {numAddition}, максимальное значение {numMax}");


        }
        /// <summary>
        /// подсчитывает среднее значение из массива
        /// </summary>
        /// <param name="numbers">массив</param>
        /// <returns>среднее значение из массива</returns>
        static void AverageValue(out int numAddition, out int numMax, params int[]numbersArray)
        {
            numAddition = numbersArray.Sum();
            numMax = numbersArray.Max();
        }
    }
}
