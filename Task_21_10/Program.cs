namespace Task_21_10
{
    internal class Program
    {
        /*
         *Написать метод, который объединяет два словаря. 
         *Если ключ присутствует в обоих словарях, суммировать
         *их значения.
         */
        static void Main(string[] args)
        {
            Dictionary<string, int> dict1 = new Dictionary<string, int>() { { "a", 1 }, { "b", 2 }, { "c", 3 } };
            Dictionary<string, int> dict2 = new Dictionary<string, int>() { { "b", 4 }, { "d", 5 }, { "c", 6 } };

            Dictionary<string, int> merged = DictionaryTogether.MergeDictionaries(dict1, dict2);

            foreach (KeyValuePair<string, int> k in merged)
            {
                Console.WriteLine($"{k.Key}: {k.Value}");
            }
        }
    }
}
