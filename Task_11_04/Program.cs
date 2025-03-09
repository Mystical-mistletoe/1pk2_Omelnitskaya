using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_11_04
{
    internal class Program
    {
        /*Массив параметров (params): 
         * Напишите метод, который принимает 
         * массив чисел и возвращает
         * их среднее значение. 
         * Используйте ключевое слово params
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(0, 99);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(AverageValue(numbers));


        }
        /// <summary>
        /// подсчитывает среднее значение из массива
        /// </summary>
        /// <param name="numbers">массив</param>
        /// <returns>среднее значение из массива</returns>
        static double AverageValue(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            double sum = 0;
            foreach (double number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }
    }
}
