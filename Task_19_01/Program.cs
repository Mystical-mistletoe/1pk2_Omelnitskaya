namespace Task_19_01
{
    internal class Program
    {
        /*Напишите программу, в которой пользователь
         * вводит произвольный текст в консоли, после чего
         * программа запрашивает подстроку для поиска. Если 
         * подстрока найдена - то программа запрашивает
         * текст для того чтобы заменить на него эту 
         * подстроку (столько раз, сколько раз подстрока 
         * встречена в тексте)
         * Пример:
         * 
         * Введите строку: "Привет, мир!"
         * Введите подстроку для поиска: "мир"
         * Введите подстроку для замены: "друг"
         * 
         * Результат: "Привет, друг!"
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Введите подстроку для поиска:");
            string searchStr1 = Console.ReadLine();

            if (str1.Contains(searchStr1))
            {
                Console.WriteLine("Введите подстроку для замены:");
                string replaceStr1 = Console.ReadLine();

                string resStr1 = str1.Replace(searchStr1, replaceStr1);
                Console.WriteLine("Результат: " + resStr1);
            }
            else
            {
                Console.WriteLine("Подстрока не найдена.");
            }
        }
    }
}
