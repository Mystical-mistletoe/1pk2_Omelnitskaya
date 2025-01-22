using System;

namespace Task_03_05
{
    internal class Program
    {
        /*Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
        Фаренгейта(F = C * 1,8 + 32). Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
        время работы программы
        */

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите начальную температуру в градусах Цельсия:");
            double TemperatureInCelsiusFirst = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите конечную температуру в градусах Цельсия:");
            double TemperatureInCelsiusEnd = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите диапазон изменения температуры в градусах Цельсия:");
            double TemperatureRange = int.Parse(Console.ReadLine());
            Console.WriteLine("C ---> F");

            for (double i = TemperatureInCelsiusFirst; i <= TemperatureInCelsiusEnd; i+=TemperatureRange) //цикл ограничен количеством попыток
            {
                if (TemperatureRange == 0 | TemperatureInCelsiusFirst == TemperatureInCelsiusEnd + 1)
                {
                    Console.WriteLine("Введены некорректные данные");
                    break;
                }
                double Answer = i * 1.8 + 32;
                Console.WriteLine($"{i}\t{Answer}");

                
                
            }
        }
    }
}
