namespace Task_21_08
{
    internal class Program
    {
        /*напишите метод, который на 
         * вход получается массив параметров 
         * (строк) и возвращает 
         * только уникальные строки
         * */
        static void Main(string[] args)
        {
            string[] input = { "Диадема", "Кубок", "Кольцо", "Змея", "Кольцо", "Дневник", "Кубок" };
            string[] end = StringArray.GetUniqueStrings(input);

            foreach (string s in end)
            {
                Console.WriteLine(s);
            }
        }
    }
}
