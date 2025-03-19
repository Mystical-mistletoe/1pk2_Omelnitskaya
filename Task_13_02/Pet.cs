using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    /// <summary>
    /// класс питомца: кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
    /// </summary>
    internal class Pet
    {
        #region поля
        private string name;
        private string species;
        private int age;
        private double weight;
        private bool isHealthy;
        #endregion

        #region свойства
        //открытое свойство имени, связанное с полем имени и выполняющее предварительную проверка на попытку записать пустое имя
        public string Name
        {
            get { return name; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    name = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! name is empty"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        //открытое свойство вида (логика совпадает с именем)
        public string Species
        {
            get { return species; }
            set
            {
                if (value != null)
                    species = value;
                else Console.WriteLine("Warning! species is empty");
            }
        }
        //открытое свойство возраста (логика совпадает с именем)
        public int Age
        {
            get { return age; }
            set
            {
                if (value != null)
                    age = value;
                else Console.WriteLine("Warning! age is empty");
            }
        }
        //открытое свойство веса (логика совпадает с именем)
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value != null)
                    weight = value;
                else Console.WriteLine("Warning! weight is empty");
            }
        }

        public bool IsHealthy { get; set; }
        #endregion

        #region конструкторы
        /*можно создавать неограниченное количество конструкторов 
         * для создания объектов с разным набором параметров*/

        /// <summary>
        /// конструктор создает объект питомца с именем и видом, остальные
        /// поля остаются непроинициализированы
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="species">вид</param>
        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            IsHealthy = true; // По умолчанию питомец здоров
        }
        /// <summary>
        /// конструктор создает объект питомца видом, остальные
        /// поля остаются непроинициализированы
        /// </summary>
        /// <param name="species">вид</param>
        public Pet(string species)
        {
            Species = species;
            IsHealthy = true; // По умолчанию питомец здоров
        }
        /// <summary>
        /// конструктор, с помощью которого заполняются данными поля
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="species">вид</param>
        /// <param name="age">возраст</param>

        public Pet(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }
        /// <summary>
        /// полный конструктор, с помощью которого заполняются данными все поля
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="species">вид</param>
        /// <param name="age">возраст</param>
        /// <param name="weight">вес</param>
        public Pet(string name, string species, int age, double weight)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
        }
        /// <summary>
        /// полный конструктор, с помощью которого заполняются данными все поля
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="species">вид</param>
        /// <param name="age">возраст</param>
        /// <param name="weight">вес</param>
        /// <param name="isHealthy">здоровье</param>
        public Pet(string name, string species, int age, double weight, bool isHealthy)
        {
            Name = name;
            Species = species;
            Age = age;
            Weight = weight;
            IsHealthy = isHealthy;
        }
        /// <summary>
        /// конструтор по умолчанию, который становиться недоступным как только прописываются
        /// остальные конструкторы и его необходимо явно прописать
        /// </summary>
        public Pet() { }
        #endregion






        #region методы
        /// <summary>
        /// возврат текущей информации по объекту
        /// </summary>
        /// <returns>строка с информацией</returns>
        public string GetInfo()
        {
            return $"Кличка: {Name}\n" + $"Вид: {Species}\n" + $"Возраст: {Age}\n" + $"Вес: {Weight} кг\n" + $"Состояние здоровья: {(IsHealthy ? "Здоров" : "Нездоров")}\n";
        }

        /// <summary>
        /// изменение веса
        /// </summary>
        /// <returns>строка с информацией</returns>
        public string ChangeWeight(double newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
                Console.WriteLine($"Вес {Name} изменен на {Weight}");
            }
            else
            {
                Console.WriteLine("Вес отрицательный");
            }
        }

        /// <summary>
        /// изменение состояния здоровья
        /// </summary>
        /// <returns>строка с информацией</returns>
        public void ChangeHealth(bool isHealthy)
        {
            IsHealthy = isHealthy;
            Console.WriteLine($"Состояние здоровья {Name} изменено на {(IsHealthy ? "здоров" : "нездоров")}");
        }
        #endregion
    }
}
