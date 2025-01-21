namespace Task_02_02
{
    internal class Program
    {

        /*
         * Найти значение выражения при a = 8, b = 14, с = π/4
         */
        static void Main(string[] args)
        {
            double a = Math.PI;
            double b = 6;
            double c = Math.PI / 4;

            double part1 = Math.Pow((a - 1), 1.0 / 3);
            double part2 = Math.Pow((b + part1), 1.0 / 4);
            double part3 = Math.Abs(a - b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c));

            double result = part2 / part3;
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
