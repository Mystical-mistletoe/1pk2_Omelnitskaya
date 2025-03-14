namespace Task_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat { age = 1, gender = "жeн", name = "Амара", breed = "Сиамская" };
            Dog dog = new Dog { age = 2, gender = "муж", name = "Апокалипсис", breed = "Лабрадор" };

            cat.GetInfo();
            cat.GetVaccinations();
            cat.Meow();
            Console.WriteLine();

            dog.GetInfo();
            dog.GetVaccinations();
            dog.GetVaccinations();
            dog.Woof();

        }
    }
}
