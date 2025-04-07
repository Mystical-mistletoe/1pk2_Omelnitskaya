using System.Net.Sockets;

namespace Task_21_09
{
    internal class Program
    {
        /*создайте класс билета (Ticket). 
         * сгенерируйте список из 30 билетов. произведите:
         * • поиск билета с максимальной суммой,
         * • билета с минимальной суммой,
         * • выведите список билетов с багажом
         * • выведите список люготных билетов
        */
        public static void Main(string[] args)
        {
            List<Ticket> tickets = new List<Ticket>();
            Random random = new Random();
            for (int i = 1; i <= 30; i++)
            {
                decimal price = (decimal)(random.NextDouble() * 1000 + 100);
                bool hasBaggage = random.Next(2) == 1; //конвертирует значение числа в логическое значение: 0 — false, 1 — true.
                bool isDiscounted = random.Next(2) == 1;
                tickets.Add(new Ticket(i, price, hasBaggage, isDiscounted));
            }

            //с максимальной суммой
            Ticket maxTicket = tickets[0];
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Price > maxTicket.Price)
                {
                    maxTicket = ticket;
                }
            }

            //с минимальной суммой
            Ticket minTicket = tickets[0];
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Price < minTicket.Price)
                {
                    minTicket = ticket;
                }
            }


            //с багажом
            List<Ticket> baggageTickets = new List<Ticket>();
            foreach (Ticket ticket in tickets)
            {
                if (ticket.HasBaggage)
                {
                    baggageTickets.Add(ticket);
                }
            }

            // льготбилет
            List<Ticket> discountedTickets = new List<Ticket>();
            foreach (Ticket ticket in tickets)
            {
                if (ticket.IsDiscounted)
                {
                    discountedTickets.Add(ticket);
                }
            }

            Console.WriteLine("Билет с максимальной суммой:");
            PrintInfo(maxTicket);
            Console.WriteLine("\nБилет с минимальной суммой:");
            PrintInfo(minTicket);
            Console.WriteLine("\nБилеты с багажом:");
            foreach (Ticket ticket in baggageTickets)
            {
                PrintInfo(ticket);
            }

            Console.WriteLine("\nЛьготные билеты:");
            foreach (Ticket ticket in discountedTickets)
            {
                PrintInfo(ticket);
            }

            static void PrintInfo(Ticket ticket)
            {
                Console.WriteLine($"Номер: {ticket.TicketNumber}, Цена: {ticket.Price}, Багаж: {(ticket.HasBaggage ? "Да" : "Нет")}, Льготный: {(ticket.IsDiscounted ? "Да" : "Нет")}");
            }

        }
    }
}
