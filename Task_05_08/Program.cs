namespace Task_05_08
{
    internal class Program
    {
        /*Даны два массива размером 10*10, заполненные
         * целыми числами в диапазоне от 1 до 9 вкл. 
         * Создать новый массив, который будет
         * произведением двух предыдущих (перемножить 
         * элементы первых двух массивов, стоящие на 
         * одинаковых позициях и записать их в
         * результирующий массив)
         * Вывести результирующий массив
         */
        static void Main(string[] args)
        {
            int n = 10;
            int[,] numbersOne = new int[n, n];
            int[,] numbersTwo = new int[n, n];
            int[,] endNumbers = new int[n, n];
            Random random = new Random();

            for (int i = 0; i < numbersOne.GetLength(0); i++)
            {
                for (int j = 0; j < numbersOne.GetLength(1); j++)
                {
                    numbersOne[i, j] = (char)random.Next(1, 10);
                    Console.Write(numbersOne[i, j] + " ");
                }

                Console.Write("\t");

                for (int j = 0; j < numbersOne.GetLength(1); j++)
                {
                    numbersTwo[i, j] = (char)random.Next(1, 10);
                    Console.Write(numbersTwo[i, j] + " ");

                    //вычисление произведения
                    endNumbers[i, j] = numbersOne[i, j] * numbersTwo[i, j];
                }

                Console.WriteLine();
            }
            Console.WriteLine("Результат перемножения двух массивов:");
            //вывод резул. массива
            for (int i = 0; i < numbersOne.GetLength(0); i++)
            {
                for (int j = 0; j < numbersOne.GetLength(1); j++)
                {
                    numbersTwo[i, j] = (char)random.Next(1, 10);
                    Console.Write(endNumbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
