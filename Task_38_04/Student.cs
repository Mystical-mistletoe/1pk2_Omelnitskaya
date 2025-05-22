using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38_04
{
    public class Student : IComparable
    {
        public string Name { get; private set; } //название
        public string Surname { get; private set; } //автор
        public string Lastname { get; private set; } //год издания
        public int Group { get; private set; } //год издания
        public Sex Sex { get; private set; } //состояние

        //конструтор
        public Student(string name, string surname, string lastname, int group, Sex sex)
        {
            Name = name;
            Surname = surname;
            Lastname = lastname;
            Group = group;
            Sex = sex;
        }
        //вывод информации о книге
        public override string ToString()
        {
            return $"{Name} {Surname} {Lastname} - \"{Group}\" ({Sex})";
        }
        //метод-конвертер для русскоязычного вывода состояния книги
        public string StringState()
        {
            switch (Sex)
            {
                case Sex.Male: return "муж"; break;
                case Sex.Female: return "жен"; break;
            }
            return null;
        }

        public int CompareTo(object? obj)
        {
            if (obj != null && obj is Student student)
            {
                return (Name + Lastname).CompareTo(student.Name + student.LastName);
            }
            else
                throw new ArgumentException();
        }
    }
}
