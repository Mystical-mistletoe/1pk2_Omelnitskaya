using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_38_04
{
    public class Class
    {
        private List<Student> students = new(); //внутренняя (закрытая) коллекция книг
        public List<Student> Students => students; //свойство для чтения коллекции книг
        private string saveFileName = "students.json"; //название файла сохранения

        //	Добавление книги во внутреннюю коллекцию
        public void AddStudent(Student student)
        {
            if (student  != null) //исключаем возможность сохранения пустого объекта
            {
                students.Add(student); //добавляем книгку в коллекцию
                students.Sort(); //сортируем коллекцию
            }
        }

        //	Удаление книги из внутренней коллекции
        public void RemoveStudent(Student student)
        {
            if (students.Contains(student)) //проверяем наличие нужного объекта в коллекции
                students.Remove(student); //удаляяем объект из коллекции
        }

        //Сохранение всей коллекции в файле
        public void Save()
        {
            //параметры сериализации
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            //сериализация данных
            var serializationData = JsonSerializer.Serialize(students, options);
            //запись в файл
            File.WriteAllText(saveFileName, serializationData);
        }
        // Загрузка ранее сохраненных данных из файла в коллекцию
        public void Load()
        {
            if (!File.Exists(saveFileName)) //проверка на существование файла
                return; //если его нет - метод останавливается

            //чтение данных из файла
            var data = File.ReadAllText(saveFileName);
            //если входные данные не пустые - десериализуем в коллекцию books
            if (data != null)
                students = JsonSerializer.Deserialize<List<Student>>(data);
            else //в противном случае просто делаем новую пустую коллекцию
                students = new List<Student>();
        }
    }
}
