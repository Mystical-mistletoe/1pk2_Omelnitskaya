using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; set; }
        public bool IsAlive { get; private set; }
        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
        }
        public void Roll()
        {
            if (Speed > 0)
            {
                Position += Speed;
                Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
                Speed += 1;
            }
            else
            {
                Console.WriteLine($"Колобок застрял! Скорость: {Speed}");
            }
        }
        //встреча с животным
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }

        public void EncounterObstacle(Obstacle obstacle)
        {
            Speed -= obstacle.SlowGO;
            Console.WriteLine($"Колобок наткнулся на {obstacle.Name}! Скорость уменьшена на {obstacle.SlowGO}.");
            if (Speed < 0) Speed = 0;
        }
    }
}
