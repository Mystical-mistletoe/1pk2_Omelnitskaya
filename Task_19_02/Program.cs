namespace Task_19_02
{
    internal class Program
    {
        /*
         * Напишите программу, которая запрашивает у 
         * пользователя произвольный текст, содержащий
         * предложения (есть знаки препинания). 
         * программу после анализа выводит текст, 
         * разделенный на части:
         * 
         * a) По пробелам (отдельные слова построчно)
         * 
         * b) По предложениям (отдельные предложения построчно)
         * (используйте метод Split())
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный текст, содержащий предложения:");
            string str1 = Console.ReadLine();

            //a) По пробелам (отдельные слова построчно)
            string[] words = str1.Split(new char[] { ' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries); 
            //StringSplitOptions.RemoveEmptyEntries позволяет удалить все пустые подстроки (те подряд)
            Console.WriteLine("\nСлова:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            //b) По предложениям (отдельные предложения построчно)
            char[] separator = { '.', '!', '?'};
            string[] sentences = str1.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nПредложения:");
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
