namespace Task_24_06
{
    internal class Program
    {
        /*Напишите метод, который принимает путь к 
         * файлу и возвращает количество строк в нем. 
         * ИспользуйтеStreamReader.
         */
        static void Main(string[] args)
        {
            int lineCount = 0;
            string filePath = "D:/work/file.txt";

            //проверка на наличие
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл '{filePath}' не найден.");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null) //построчно
                {
                    lineCount++;
                }
            }

            Console.WriteLine($"Количество строк в файле: {lineCount}");
        }
    }
}
