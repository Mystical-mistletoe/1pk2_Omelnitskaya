using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_13_03
{
    /// <summary>
    /// класс автомобиля: номер авто, марка, цвет, текущая скорость
    /// </summary>
    internal class Car
    {
        #region поля
        public string number;
        public string brand;
        public string color;
        public double currentSpeed;
        private double MaxSpeed = 150;
        #endregion

        #region Свойства

        /// <summary>
        /// Номер автомобиля
        /// </summary>
        public string Number
        {
            get { return number; }
            set
            {
                if (number != null)
                    number = value;
                else
                    Console.WriteLine("Warning! Number cannot be empty.");
            }
        }

        /// <summary>
        /// Марка автомобиля
        /// </summary>
        public string Brand
        {
            get { return brand; }
            set
            {
                if (brand != null)
                    brand = value;
                else
                    Console.WriteLine("Warning! Brand cannot be empty.");
            }
        }

        /// <summary>
        /// Цвет автомобиля
        /// </summary>
        public string Color
        {
            get { return color; }
            set
            {
                if (color != null)
                    color = value;
                else
                    Console.WriteLine("Warning! Color cannot be empty.");
            }
        }

        /// <summary>
        /// Текущая скорость автомобиля. Не должна превышать MaxSpeed.
        /// </summary>
        public double CurrentSpeed
        {
            get { return currentSpeed; }
            set
            {
                if (value >= 0 && value <= MaxSpeed)
                    currentSpeed = value;
                else if (value < 0)
                    Console.WriteLine("Warning! Speed cannot be negative.");
                else
                {
                    Console.WriteLine($"Warning! Speed cannot exceed {MaxSpeed}. Setting speed to {MaxSpeed}.");
                    currentSpeed = MaxSpeed; //макс скорость, если превышена
                }
            }
        }

        #endregion

        #region конструкторы
        /// <summary>
        /// Конструктор с инициализацией номера и марки.
        /// </summary>
        /// <param name="number">Номер автомобиля.</param>
        /// <param name="brand">Марка автомобиля.</param>
        public Car(string number, string brand)
        {
            Number = number;
            Brand = brand;
        }
        /// <summary>
        /// Конструктор с инициализацией номера, марки и цвета.
        /// </summary>
        /// <param name="number">Номер автомобиля.</param>
        /// <param name="brand">Марка автомобиля.</param>
        /// <param name="color">Цвет автомобиля.</param>
        public Car(string number, string brand, string color)
        {
            Number = number;
            Brand = brand;
            Color = color;
        }
        /// <summary>
        /// Конструктор с инициализацией номера, марки, цвета и текущей скорости.
        /// </summary>
        /// <param name="number">Номер автомобиля.</param>
        /// <param name="brand">Марка автомобиля.</param>
        /// <param name="color">Цвет автомобиля.</param>
        /// <param name="currentSpeed">Текущая скорость.</param>
        public Car(string number, string brand, string color, double currentSpeed)
        {
            Number = number;
            Brand = brand;
            Color = color;
            CurrentSpeed = currentSpeed;
            CheckSpeed(); // Проверка скорости при инициализации
        }

        // Конструктор по умолчанию
        public Car() { }
        #endregion


        #region методы
        /// <summary>
        /// возврат текущей информации по объекту
        /// </summary>
        /// <returns>строка с информацией</returns>
        public string GetInfo()
        {
            return $"Номер: {Number}\n" + $"Марка: {Brand}\n" + $"Цвет: {Color}\n" + $"Текущая скорость: {CurrentSpeed} км/ч\n";
        }

        /// <summary>
        /// етод для симуляции езды (ускорения)
        /// </summary>
        /// <returns>строка с информацией</returns>
        public void Drive(double acceleration, int durationSeconds)
        {
            for (int i = 0; i < durationSeconds; i++)
            {
                CurrentSpeed += acceleration;
                CheckSpeed(); // проверка после каждого ускорения
                Console.WriteLine($"Автомобиль {Brand}, скорость = {CurrentSpeed} км/ч");
                Thread.Sleep(1000); // пауза в 1 секунду (симуляция)
            }

        }


        // Метод для торможения
        public void Brake()
        {
            CurrentSpeed = 0;
            Console.WriteLine($"Автомобиль остановился. Текущая скорость - {CurrentSpeed} км/ч");
        }

        /// <summary>
        /// етод для проверки скорости и торможения при превышении
        /// </summary>
        /// <returns>строка с информацией</returns>
        private void CheckSpeed()
        {
            if (CurrentSpeed > MaxSpeed)
            {
                Console.WriteLine($"Превышение скорости! Автомобиль {Brand} остановился.");
                Brake();
            }
        }
        #endregion
    }
}