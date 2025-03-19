namespace Task_13_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet();
            pet1.Name = "Живоглот";
            pet1.Species = "Кот";
            pet1.Age = 103;
            pet1.Weight = 4.5;
            Console.WriteLine(pet1.GetInfo());

            Pet pet2 = new Pet("Апокалипсис", "Собака", 1, 12, true);
            Console.WriteLine(pet2.GetInfo());

            Pet pet3 = new Pet
            {
                Name = "Дашка",
                Species = "Волнистик",
                IsHealthy = true,
            };
            Console.WriteLine(pet3.GetInfo());

            //методы
            pet2.ChangeWeight(11.0);
            pet2.ChangeHealth(false);
            Console.WriteLine(pet2.GetInfo());


        }
    }
}
