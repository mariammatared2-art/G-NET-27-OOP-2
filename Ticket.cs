using Session_2_OOP.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_OOP
{
   public class Ticket
    {
        private static int ticketCounter = 0;

        private string movieName;
        private double price;

        public int TicketId { get; }

        public string MovieName
        {
            get => movieName;
            set
            {
                if (!string.IsNullOrEmpty(value))
                    movieName = value;
            }
        }

        public TicketType Type { get; set; }
        public SeatLocation Seat { get; set; }

        public double Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public double PriceAfterTax
        {
            get => Price * 1.14;
        }

        public Ticket()
        {
            ticketCounter++;
            TicketId = ticketCounter;
        }

        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }
    }
}
