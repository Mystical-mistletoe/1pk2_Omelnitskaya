using System.Diagnostics.Metrics;

namespace Task_32_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();
            List<object> obs = new List<object>
            {
                new Hare(),
                new Obstacle("Трава", 1),
                new Wolf(),
                new Obstacle ("Яма", 2),
                new Bear(),
                new Fox()
            };

            foreach (var x in obs)
            {
                if (!kolobok.IsAlive)
                    break;

                kolobok.Roll();
                if (x is Animal animal)
                {
                    kolobok.MeetAnimal(animal);
                }
                else if (x is Obstacle obstacle)
                {
                    kolobok.EncounterObstacle(obstacle);
                }
            }
            if (kolobok.IsAlive)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }

    }
}
