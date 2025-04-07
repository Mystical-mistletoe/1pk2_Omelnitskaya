namespace Task_21_06
{
    internal class Program
    {
        /*Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
         *
         */
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 1, 5 };

            List<int> uniqueNumbers = RemoveDuplicates(numbers);

            foreach (int number in uniqueNumbers)
            {
                Console.Write($"{number} ");
            }
        }

        public static List<int> RemoveDuplicates(List<int> list)
        {
            List<int> result = new List<int>();
            HashSet<int> seen = new HashSet<int>();

            foreach (int item in list)
            {
                if (seen.Add(item)) //если элемент добавлен (те еще не было)
                {
                    result.Add(item);
                }
            }

            return result;
        }
    }
}
