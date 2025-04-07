using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_21_09
{
    internal class Ticket
    {
        /*создайте класс билета (Ticket). 
         * сгенерируйте список из 30 билетов. произведите:
         * • поиск билета с максимальной суммой,
         * • билета с минимальной суммой,
         * • выведите список билетов с багажом
         * • выведите список люготных билетов
        */
        public int TicketNumber { get; set; }
        public decimal Price { get; set; }
        public bool HasBaggage { get; set; }
        public bool IsDiscounted { get; set; }

        public Ticket(int ticketNumber, decimal price, bool hasBaggage, bool isDiscounted)
        {
            TicketNumber = ticketNumber;
            Price = price;
            HasBaggage = hasBaggage;
            IsDiscounted = isDiscounted;
        }
    }
}
