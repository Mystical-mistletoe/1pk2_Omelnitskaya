namespace Task_24_07
{
    internal class Program
    {
        /*Реализуйте функцию, которая ищет заданное
         * слово в текстовом файле и возвращает 
         * все строки, содержащиеэтослово 
         * (регистронезависимо).
         */
        static List<string> FindLines(string filePath, string searchWord)
        {
            List<string> matchingLines = new List<string>();

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл '{filePath}' не найден.");
                return matchingLines;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchingLines.Add(line);
                    }
                }
            }
            return matchingLines;
        }

        static void Main(string[] args)
        {
            string filePath = "D:/work/file.txt";
            string searchWord = "rOn";


            List<string> lines = FindLines(filePath, searchWord);

            if (lines.Count > 0)
            {
                Console.WriteLine($"Строки, содержащие '{searchWord}':");
                foreach (string l in lines)
                {
                    Console.WriteLine(l);
                }
            }
            else if (File.Exists(filePath))
            {
                Console.WriteLine($"Слово '{searchWord}' не найдено в файле.");
            }
        }
    }
}
