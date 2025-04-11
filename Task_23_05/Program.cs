namespace Task_23_05
{
    internal class Program
    {
        /*Напишите программу со следующими функциями:
         * 1. Выведите информации о всех дисках в системе
         * 2. Выведите содержимое каталога C:\Users (названия папок)
         * 3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
         *      a) Создание вложенного каталога “temp”
         *      b) Вывод информации о текущем каталоге (имя, родитель и тд)
         *      c) Вывод информации о вложенном каталоге
         * 4. Переместите каталог “temp” по пути “D:\work\newTemp”
         *      a) Реализуйте вывод информационного сообщения об успешном (или нет)
         *      перемещении
         * 5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет)
         * удалении.
         */
        static void Main(string[] args)
        {
            List<DriveInfo> drivers = DriveInfo.GetDrives().ToList();

            //1. Выведите информации о всех дисках в системе
            Console.WriteLine("Диски в системе:");
            foreach (DriveInfo drive in drivers)
            {
                Console.WriteLine($"{drive.Name}: Размер диска: {drive.TotalSize / 1024 / 1024 / 1024} Г6\n"
                    + $"\t Доступное место на диске: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} Г6\n" +
                    $"\t тип диска {drive.DriveType}\n" +
                    $"\t метка диска {drive.VolumeLabel}\n");
            }

            Console.WriteLine("--------------------");


            //2 Выведите содержимое каталога C:\Users (названия папок)
            string pathName = @"C:\Users";
            if (Directory.Exists(pathName))
            {
                Console.WriteLine(@"Содержимое C:\Users:");
                List<String> list = Directory.GetDirectories(pathName).ToList();
                if (list.Count > 0)
                {
                    int n = 1;
                    foreach (string s in list)
                    {
                        Console.WriteLine(n + ": " + s);
                        n++;
                    }
                }
            }
            else
            {
                Console.WriteLine(@"Ошибка при доступе к C:\Users");
            }


            Console.WriteLine("--------------------");

            //3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
            string workDir = @"D:\work";
            string tempDir = Path.Combine(workDir, "temp");
            //Path.Combine() - делает путь
            string newTempDir = Path.Combine(workDir, "newTemp");


            //Создание вложенного каталога “temp”
            Directory.CreateDirectory(workDir);
            Directory.CreateDirectory(tempDir);

            // b) Вывод информации о текущем каталоге (имя, родитель и тд)
            DirectoryInfo workDirInfo = new DirectoryInfo(workDir);
            Console.WriteLine($"{workDirInfo.Name} - {workDirInfo.FullName}\n" +
                $"\t дата создания: {workDirInfo.CreationTime}\n" +
                $"\t корневой каталог: {workDirInfo.Parent}\n" +
                $"\t последнее обращение: {workDirInfo.LastAccessTime}\n");

            Console.WriteLine("--------------------");

            // c) Вывод информации о вложенном каталоге
            DirectoryInfo tempDirInfo = new DirectoryInfo(tempDir);
            Console.WriteLine($"{tempDirInfo.Name} - {tempDirInfo.FullName}\n" +
                $"\t дата создания: {tempDirInfo.CreationTime}\n" +
                $"\t корневой каталог: {tempDirInfo.Parent}\n" +
                $"\t последнее обращение: {tempDirInfo.LastAccessTime}\n");

            Console.WriteLine("--------------------");

            //4. Переместите каталог “temp” по пути “D:\work\newTemp”
            // a) Реализуйте вывод информационного сообщения об успешном(или нет) перемещении
            if (Directory.Exists(tempDir) && !Directory.Exists(newTempDir))
            {
                Directory.Move(tempDir, newTempDir);
                Console.WriteLine("Каталог 'temp' успешно перемещен в 'newTemp'.");
            }
            else if (!Directory.Exists(tempDir))
            {
                Console.WriteLine("Каталог 'temp' не существует для перемещения.");
            }
            else if (Directory.Exists(newTempDir))
            {
                Console.WriteLine("Каталог 'newTemp' уже существует");
            }

            // 5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) удалении.
            if (Directory.Exists(newTempDir))
            {
                Directory.Delete(newTempDir, true); 
                // true означает что удалятся и подкаталоги
                Console.WriteLine("Каталог 'newTemp' успешно удален.");
            }
            else
            {
                Console.WriteLine("Каталог 'newTemp' не существует.");
            }
        }
    }
}
