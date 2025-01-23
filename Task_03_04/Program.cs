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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("вводите текст, для остановки ввода введите слово «exit» или пустую строку");
                customText = Console.ReadLine();
                
                if (customText == "exit" || customText.Length == 0) // или customText == string.Empty
                {
                    break;
                }
                a++;
            }
            Console.WriteLine($"вы ввели {a} строк(у)");
        }
    }
}
