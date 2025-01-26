namespace Task_04_09
{
    internal class Program
    {
        /*В массиве найти элементы, которые 
         * в нем встречаются только один раз, 
         * и вывести их на экран. То есть найти и
         * вывести уникальные элементы массива. 
         * (LINQ использовать нельзя)
         * 
         * что это такое??
         */
        static void Main(string[] args)
        {
            // Создаем массив для 50 случайных чисел
            int[] numbers = new int[50];
            Random random = new Random();

            // Заполнение массива случайными значениями от 1 до 20
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 20);
            }

            Console.WriteLine("Сгенерированный массив: " + string.Join(" ", numbers));

            //массив для хранения количества вхождений
            int[] counts = new int[21]; //от 1 до 20

            // Подсчет элемента
            foreach (var number in numbers)
            {
                counts[number]++;
            }

            // Вывод уникальных элементов
            Console.WriteLine("Уникальные элементы:");
            for (int i = 1; i < counts.Length; i++) //от 1 до 20
            {
                if (counts[i] == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
