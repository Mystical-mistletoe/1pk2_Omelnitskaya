namespace Task_11_03
{
    internal class Program
    {
        /*Выходной параметр (out): 
         * Напишите метод, который принимает строку 
         * и возвращает через выходной параметр 
         * количество гласных и согласных букв в этой строке
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string strochka = Console.ReadLine();
            int countVowels, countConsonats;

            VowelsConsonants(strochka, out countVowels, out countConsonats);

            Console.WriteLine($"Количество гласных: {countVowels}");
            Console.WriteLine($"Количество согласных: {countConsonats}");
            Console.WriteLine("ъ и ь не относятся");

        }
        /// <summary>
        /// подсчитывает колво гл и согл букв в строке
        /// </summary>
        /// <param name="cVowels">целое число 1</param>
        /// /// <param name="cConsonats">целое число 2</param>
        /// <returns>количество гласных и согласных букв</returns>
        static void VowelsConsonants(string strochka, out int cVowels, out int cConsonats)
        {
            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            string consonats = "йцкнгшщзхфвпрлджчсмтбЙЦКНГШЩЗХЪФВПРЛДЖЧСМТЬБ";
            cVowels = 0;
            cConsonats = 0;

            for (int i = 0; i < strochka.Length; i++)
            {
                if (vowels.Contains(strochka[i].ToString()))
                {
                    cVowels++;
                }
                else if (consonats.Contains(strochka[i].ToString()))
                {
                    cConsonats++;
                }
            }
        }
    }
}
