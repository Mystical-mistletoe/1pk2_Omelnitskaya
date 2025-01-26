using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_04_08
{
    internal class Program
    {
        /*Дан массив, содержащий последовательность 
         * 50 случайных чисел. Найти количество пар 
         * элементов, значения которых равны.
         */
        static void Main(string[] args)
        {
            int[] numbers = new int[50];
            Random random = new Random();

            //заполнение массива
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(0, 11);
            }

            bool[] isPair = new bool[50]; //массив флагов для обозначения найденных пар

            //поиск пар начиная со 2 элемента
            int countOfPairs = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    countOfPairs++;
                    isPair[i] = true;
                    isPair[i - 1] = true;

                }
            }

            //вывод с выделением цветом
            for (int i = 0; i < numbers.Length; i++)
            {
                if (isPair[i])//если есть отметка в массиве isPair что этот элемент является парным, то выделяем цветом
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(numbers[i] + " ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else //в противном случае при выводе фон не меняется
                {
                    Console.Write(numbers[i] + " ");
                }
            }



            Console.WriteLine($"\n\nколичество пар с одинаковым значением - {countOfPairs}");
        }
    }
}
