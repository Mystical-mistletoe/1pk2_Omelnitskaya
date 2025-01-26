namespace Task_04_06
{
    internal class Program
    {
        /*Заполнить массив случайными положительными и 
         * отрицательными числами таким образом, чтобы 
         * все числа по модулю были разными. 
         * 
         * Это значит, 
         * что в массиве не может быть ни только двух 
         * равных чисел, но не может быть двух равных 
         * по модулю. 
         * 
         * В полученном массиве найти 
         * наибольшее по модулю число
        */
        static void Main(string[] args)
        {
            // Инициализация переменных
            int n = 10; // размер массива
            int[] numbers = new int[n];
            int[] absnumbers = new int[n];
            Random random = new Random();

            // Заполнение массива случайными положительными и отрицательными числами
            for (int i = 0; i < n; i++)
            {
                int number;
                
                do
                {
                    number = random.Next(-100, 101); // Генерация числа от -100 до 100
                    if (absnumbers.Contains(Math.Abs(number)) == false)
                    {
                        numbers[i] = number; // Заполнение массива
                        absnumbers[i] = Math.Abs(number);
                        break;
                    }

                } 
                while (true); // Проверка на уникальность по модулю

            }

            // Вывод заполненного массива (для проверки)
            Console.WriteLine("Сгенерированный массив:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Поиск наибольшего числа по модулю
            int maxAbsNumb = numbers[0];
            for (int i = 1; i < n; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(maxAbsNumb))
                {
                    maxAbsNumb = numbers[i];
                }
            }

            // Вывод результата
            Console.WriteLine($"Наибольшее по модулю число: {maxAbsNumb}");
        }
    }
}
