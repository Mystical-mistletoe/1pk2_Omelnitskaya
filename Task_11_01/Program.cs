﻿using System.Threading.Channels;

namespace Task_11_01
{
    internal class Program
    {
        /*Передача по значению: 
         * Напишите метод, который принимает 
         * два целых числа и меняет их местами. 
         * Проверьте, изменились ли значения 
         * переменных вне метода
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            SwapPlaces(numOne, numTwo);
            Console.WriteLine($"Первое число вне метода: {numOne}");
            Console.WriteLine($"Второе число вне метода: {numTwo}");

        }
        /// <summary>
        /// замена чисел местами
        /// </summary>
        /// <param name="numOne">целое число 1</param>
        /// /// <param name="numTwo">целое число 2</param>
        /// <returns></returns>
        public static void SwapPlaces(int numOne, int numTwo)
        {
            int consumables = numOne;
            numOne = numTwo;
            numTwo = consumables;
            Console.WriteLine($"Первое число внутри метода: {numOne}");
            Console.WriteLine($"Второе число внутри метода: {numTwo}");
        }
    }
}
