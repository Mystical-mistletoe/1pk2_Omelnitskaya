namespace Task_20_04
{
    internal class Program
    {
        /*Создайте программу для учета транспортных средств.
         * Используйте перечисление VehicleType:
         * • Car
         * • Bike
         * • Bus
         * • Truck
         * • Motorcycle
         * Храните список транспортных средств 
         * (можно просто List<VehicleType>). 
         * Добавьте метод для подсчёта транспорта 
         * определённого типа (например, сколько грузовиков). 
         * Реализуйте поиск по типу и вывод информации.
         */
        static void Main(string[] args)
        {
            List<VehicleType> vehicles = new List<VehicleType>() {
            VehicleType.Truck, VehicleType.Car, 
            VehicleType.Truck, VehicleType.Bike, 
            VehicleType.Car, VehicleType.Motorcycle, 
            VehicleType.Truck, VehicleType.Car
            };

            //подсчет транспорта определен типа
            VehicleType truckCount = VehicleType.Truck;
            int count = 0;
            foreach (VehicleType vehicle in vehicles)
            {
                if (vehicle == truckCount)
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество {truckCount}: {count}");


            //поиск и вывод инфы о всех транспортных средствах определен типа
            VehicleType toSearch = VehicleType.Car;

            List<VehicleType> foundVehicles = new List<VehicleType>();
            foreach (VehicleType vehicle in vehicles)
            {
                if (vehicle == toSearch)
                {
                    foundVehicles.Add(vehicle);
                }
            }

            Console.WriteLine($"\nНайденные транспортные средства типа {toSearch}:");
            foreach (var vehicle in foundVehicles)
            {
                Console.WriteLine(vehicle);
            }

            Console.ReadKey();
        }
    }
}
