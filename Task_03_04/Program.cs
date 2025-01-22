namespace Task_03_04
{
    internal class Program
    {
        /*Пользователь вводить в консоли произвольный текст.
         * После каждого ввода консоль очищается. Когда
         * пользователь вводить слово «exit» или пустую 
         * строку – ввод останавливается и выводиться 
         * количество строк введенных пользователем
         */

        static void Main(string[] args)
        {
            int a = 0;
            string customText;
            Console.WriteLine("вводите текст, для остановки ввода введите слово «exit» или пустую строку");
            do
            {
                customText = Console.ReadLine();
                a++;
                Console.Clear();
            }
            while (customText != "exit" && customText != " ");
            Console.WriteLine($"вы ввели {a-1} строк(у)");
        }
    }
}
