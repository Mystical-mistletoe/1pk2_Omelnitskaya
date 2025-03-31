using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_06
{
    internal class TrafficLight
    {
        private TrafficLightColor currentColor;

        public TrafficLight()
        {
            currentColor = TrafficLightColor.Red;
        }

        public void Run()
        {
            while (true)
            {
                Console.WriteLine($"Светофор: {currentColor}");
                switch (currentColor)
                {
                    case TrafficLightColor.Red:
                        Thread.Sleep(3000);
                        currentColor = TrafficLightColor.Yellow;
                        break;
                    case TrafficLightColor.Yellow:
                        Thread.Sleep(3000);
                        currentColor = TrafficLightColor.Green;
                        break;
                    case TrafficLightColor.Green:
                        Thread.Sleep(3000);
                        currentColor = TrafficLightColor.Red;
                        break;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    ManualSwitch(key.Key);
                }

            }
        }

        public void ManualSwitch(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.R:
                    currentColor = TrafficLightColor.Red;
                    break;
                case ConsoleKey.Y:
                    currentColor = TrafficLightColor.Yellow;
                    break;
                case ConsoleKey.G:
                    currentColor = TrafficLightColor.Green;
                    break;
                default:
                    Console.WriteLine("Неверная клавиша. Введите R, Y или G.");
                    break;
            }
        }
    }
}
