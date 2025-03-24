namespace Task_19_03
{
    internal class Program
    {
        /*
         * Напишите консольное приложение, в котором 
         * осуществляется построчный пользовательский
         * ввод (ввод каждой строки подтверждается 
         * нажатием на enter). количество введенных строк
         * произвольно, ввод завершается при вводе пустой 
         * строки.
         * После окончания ввода произведите объединение 
         * всех ранеее введенных строк в одну с
         * использованием разделителя «-»
         * Например:
         * 
         * Введите строку 1: "Hello"
         * Введите строку 2: "world"
         * Введите строку 3: "C#"
         * 
         * Результат: "Hello-world-C#"
         */
        static void Main(string[] args)
        {
            string[] lines = new string[10];
            int n = 10;
            int lineCount = 0; //кол-во введенных строк

            while (true)
            {
                Console.Write($"Введите строку {lineCount + 1} (или пустую строку для завершения):");
                string str1 = Console.ReadLine();

                //если пустая строка то конец
                if (string.IsNullOrEmpty(str1))
                    break;

                //при запол массиве увел размер
                if (lineCount == n)
                {
                    n *= 2;
                    string[] newLines = new string[n];
                    Array.Copy(lines, newLines, lineCount);
                    lines = newLines;
                }
                lines[lineCount] = str1;
                lineCount++;
            }
            Array.Resize(ref lines, lineCount);
            string combinedString = string.Join("-", lines);


            Console.WriteLine("Результат: " + combinedString);

        }
    }
}
