namespace Task_03_06
{
    internal class Program
    {
        /*Написать программу, которая выводит таблицу
         * значений функции: 𝑦=|𝑥| для -4≤x≤4, с шагом h = 0,5
         */
        static void Main(string[] args)
        {
            Console.WriteLine($"Значения функции y=|x|");

            for (double x = -4; x <= 4; x += 0.5)
            {
                double Answer = Math.Abs(x);
                Console.WriteLine($"y=|{x}|-->\t{Answer}");

            }
        }
    }
}
