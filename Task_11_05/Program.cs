namespace Task_11_05
{
    internal class Program
    {
        /*Комбинирование ref и out: 
         * Напишите метод, который принимает 
         * два числа по ссылке (ref) и
         * возвращает их сумму и произведение 
         * через выходные параметры (out).
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            int numAddition, numMultiplication;

            Console.WriteLine("---------------------");

            AdditionMultiplication(ref numOne, ref numTwo, out numAddition, out numMultiplication);
            Console.WriteLine($"Сумма чисел: {numAddition}, произведение чисел: {numMultiplication}");

        }
        /// <summary>
        /// подсчитывает сумма и произведение
        /// </summary>
        /// <param name="numOne">число 1</param>
        /// <param name="numTwo">число 2</param>
        /// <returns></returns>
        static void AdditionMultiplication(ref int numOne, ref int numTwo, out int numAddition, out int numMultiplication)
        {
            numAddition = numOne + numTwo;
            numMultiplication = numOne * numTwo;
        }
    }
}
