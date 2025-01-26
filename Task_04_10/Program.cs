namespace Task_04_10
{
    internal class Program
    {
        /*Заполнить массив из 10 элементов случайными 
         * числами в интервале [-10..10] и сделать 
         * реверс элементов отдельно для 1-ой и 2-ой 
         * половин массива. Реверс реализовать через 
         * цикл. Стандартные методы класса Array 
         * использовать нельзя.
         * Например, 
         * исходный массив: [5,2,-10,0,4,-6,7,2,9,-7]
         * Результат: [4,0,-10,2,5,-7,9,2,7,-6]
         */
        static void Main(string[] args)
        {
            // Создаем массив для 10 случайных чисел
            int n = 10;
            int[] numbers = new int[10];
            int[] numbersTwo = new int[10];
            Random random = new Random();

            // Заполнение массива случайными значениями от -10 до 10
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-10, 11);
            }

            Console.WriteLine("Сгенерированный массив: " + string.Join(" ", numbers));

            // Реверс первой половины
            for (int i = 0; i < n / 2; i++)
            {
                int temp = numbers[i];
                numbersTwo[i] = numbers[n / 2 - 1 - i];
                numbersTwo[n / 2 - 1 - i] = temp;

            }

            // Реверс второй половины
            for (int i = n / 2; i < n; i++)
            {
                int temp = numbers[i];
                numbersTwo[i] = numbers[n - 1 - (i - n / 2)];
                numbersTwo[n - 1 - (i - n / 2)] = temp;
            }

            // Вывод результирующего массива
            Console.WriteLine("Результат: " + string.Join(", ", numbersTwo));
        }
    }
}
