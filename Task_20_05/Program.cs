namespace Task_20_05
{
    internal class Program
    {
        /*Напишите программу, имитирующую систему 
         * авторизации с использованием перечисления 
         * AccessLevel:
         * • Guest (только чтение)
         * • User (чтение + комментарии)
         * • Moderator (удаление контента)
         * • Admin (полный доступ)
         * Создайте метод, который проверяет, 
         * может ли пользователь выполнить действие 
         * (например, удалитьпост).На основе уровня 
         * доступа выводите сообщение (например,
         * "Ошибка: Недостаточно прав!")
         */
        static void Main(string[] args)
        {
            // Пример использования
            AccessLevel userLevel1 = AccessLevel.User;
            Console.WriteLine("User:");

            CheckAccess(userLevel1, "delete_post"); //удаление
            CheckAccess(userLevel1, "add_comment"); //комм
            CheckAccess(userLevel1, "read_post");    //чтение

            AccessLevel userLevel2 = AccessLevel.Moderator;

            Console.WriteLine("Moderator:");

            CheckAccess(userLevel2, "delete_post"); //удаление
            CheckAccess(userLevel2, "add_comment"); //коммент
            CheckAccess(userLevel2, "read_post");    //чтение
            CheckAccess(userLevel2, "rd_post");    // неизвестное

            Console.ReadKey();
        }

        public static void CheckAccess(AccessLevel userLevel, string action)
        {
            switch (action)
            {
                case "read_post":
                    if (userLevel >= AccessLevel.Guest)
                    {
                        Console.WriteLine("Действие 'чтение поста' разрешено.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: недостаточно прав для 'чтение поста'!");
                    }
                    break;

                case "add_comment":
                    if (userLevel >= AccessLevel.User)
                    {
                        Console.WriteLine("Действие 'добавление коммента' разрешено.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: недостаточно прав для 'добавления коммента'!");
                    }
                    break;

                case "delete_post":
                    if (userLevel >= AccessLevel.Moderator)
                    {
                        Console.WriteLine("Действие 'удаление поста' разрешено.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: недостаточно прав для 'удаление поста'!");
                    }
                    break;
                case "full_access":
                    if (userLevel >= AccessLevel.Admin)
                    {
                        Console.WriteLine("Действие 'полный доступ' разрешено.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: недостаточно прав для 'полный доступ'!");
                    }
                    break;

                default:
                    Console.WriteLine($"Ошибка: неизвестное действие '{action}'.");
                    break;
            }
        }
    }
}
