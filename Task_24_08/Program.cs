namespace Task_24_08
{
    internal class Program
    {
        /*реализуйте функцию, осуществляющую 
         * поиск текста в файле и его замену 
         * на значения, введенные пользователем
         */
        static void ReplaceText(string filePath, string searchText, string replaceText)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл '{filePath}' не найден.");
                return;
            }

            string fileContent = File.ReadAllText(filePath);
            string newContent = fileContent.Replace(searchText, replaceText);
            File.WriteAllText(filePath, newContent);
            Console.WriteLine("Текст успешно заменен.");
        }

        static void Main(string[] args)
        {
            string filePath = "D:/work/file.txt";
            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();
            Console.Write("Введите текст для замены: ");
            string replaceText = Console.ReadLine();

            ReplaceText(filePath, searchText, replaceText);
        }
    }
}
