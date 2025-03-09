using System;

namespace Task_11_06
{
    internal class Program
    {
        /*Передача массива по значению: 
         * Напишите метод, который принимает массив 
         * целых чисел и изменяет его элементы, 
         * увеличивая каждый на 1. 
         * Проверьте, изменился ли оригинальный
         * массив вне метода.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[n];

            Random random = new Random();
            Console.WriteLine($"Изначальный массив:");

            for (int i = 0; i < n; i++)
            {
                numbers[i] = random.Next(0, 99);
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            EnlargedArray(numbers);

            Console.WriteLine($"Проверка изначального массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(numbers[i] + " ");
            }

        }
        /// <summary>
        /// изменяет массив на +1
        /// </summary>
        /// <param name="numbers">массив чисел</param>
        /// <returns></returns>
        static void EnlargedArray(double[] num)
        {
            Console.WriteLine("Измененный массив:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i]++;
            }
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
