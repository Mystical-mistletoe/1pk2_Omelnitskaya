namespace Task_13_03
{
    internal class Program
    {
        /*создайте класс автомобиля
         * свойства:
         * номер авто, марка, цвет, текущая скорость
         * методы:
         * езда (симитировать равномерное ускорение скорости автомобиля)
         * торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
         * конструторы
         * предусмотрите разные варианты инициализации объектов
        */
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                number = "0011F",
                brand = "jeep",
                color = "green",
                currentSpeed = 10,
            };

            Console.WriteLine(car1.GetInfo());
            car1.Drive(20, 5); // Ускорение 20 км/ч в течение 5 секунд


            Car car2 = new Car
            {
                brand = "bentley",
                color = "black",
                currentSpeed = 90,
            };
            Console.WriteLine(car2.GetInfo());
            car2.Drive(30, 4); // Ускорение 30 км/ч в течение 3 секунд
            Console.WriteLine();

            car1.Drive(10, 5); // Проверим остановку при превышении скорости
        }
    }
}
