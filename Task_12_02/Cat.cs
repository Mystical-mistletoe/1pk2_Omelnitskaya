using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_12_02
{
    internal class Cat
    {
        public int age;
        public string gender; // пол
        public string name; // имя
        public string breed; // порода
        public bool vaccinationsDone = false; // По умолчанию прививки не сделаны

        //метод класса - печатает в консоль информацию о питомце
        public void GetInfo()
        {
            Console.WriteLine($"{name}. Возраст - {age}, пол - {gender}, порода - {breed}");
        }
        //метод класса - печатает в консоль информацию о прививках
        public void GetVaccinations()
        {
            if (vaccinationsDone)
            {
                Console.WriteLine($"Прививки для кошки {name} уже сделаны");
            }
            else
            {
                Console.WriteLine($"Сделаны прививки для кошки {name}.");
                vaccinationsDone = true;
            }
            
        }
        //метод класса - печатает в консоль голос питомца
        public void Meow()
        {
            Console.WriteLine($"{name}: Мяу!");
        }
    }
}
    
