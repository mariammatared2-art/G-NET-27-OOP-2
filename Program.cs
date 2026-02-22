using Session_2_OOP.Enum;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            //Q1:
            //   a) Problems with the design(Encapsulation issues) 
            //        1-Public fields
            //        2- No validation
            //        3- Poor data protection
            //   b) How to fix the class
            //        *Make fields private.
            //        *Add validation logic inside property setters.
            //        *Allow balance modification only through methods like Withdraw.
            //  c) Why exposing fields directly is bad practice
            //        *Breaks encapsulation.
            //        *Makes the code harder to maintain and extend.
            //        *Prevents adding validation, logging, or security checks.
            //        *Increases the risk of invalid data.
            //Q2:
            //    Field 
            //       - Stores data directly
            //       - No logic allowed 
            //       - Less secure
            //    Property
            //       - Controls access to data   
            //       - Can contain logic
            //       - More secure
            //    Yes, a property can contain logic.
            //    public double PriceAfterTax
            //{
            //    get { return Price * 1.14; }
            //}
            //Q3:
            //    a) What is this[int index] ?
            //          It is called an Indexer.
            //          Purpose:
            //          Allows objects to be accessed like arrays
            //    b) What happens with:
            //          Causes an IndexOutOfRangeException.
            //          Making the indexer safer:
            //          Check bounds before accessing the array.
            //    c) Can a class have more than one indexer? Yes.
            //       Example use case:
            //         One indexer by number(int)
            //         Another indexer by key(string)
            //Q4:
            //    a) Meaning of static in TotalOrders
            //          -Shared among all instances of the class.
            //          -Created once for the entire application.
            //          -Difference from Item:
            //          -Item belongs to each individual object.
            //   b) Can a static method access Item directly? No.
            //         Reason:
            //           Static members belong to the class, not to instances.
            //           Item is instance-level data.
            #endregion

            #region Part 2
            //Cinema cinema = new Cinema();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter data for Ticket {i + 1}:");

            //    Ticket t = new Ticket();

            //    Console.Write("Movie Name: ");
            //    t.MovieName = Console.ReadLine();

            //    Console.Write("Ticket Type (0=Standard,1=VIP,2=IMAX): ");
            //    t.Type = (TicketType)int.Parse(Console.ReadLine());

            //    Console.Write("Seat Row: ");
            //    char row = char.Parse(Console.ReadLine());

            //    Console.Write("Seat Number: ");
            //    int number = int.Parse(Console.ReadLine());

            //    t.Seat = new SeatLocation { Row = row, Number = number };

            //    Console.Write("Price: ");
            //    t.Price = double.Parse(Console.ReadLine());

            //    cinema.AddTicket(t);
            //}

            //Console.WriteLine("\n========== All Tickets ==========");
            //for (int i = 0; i < 3; i++)
            //{
            //    Ticket t = cinema[i];
            //    Console.WriteLine(
            //        $"Ticket #{t.TicketId} | {t.MovieName} | {t.Type} | Seat: {t.Seat} | Price: {t.Price} | After Tax: {t.PriceAfterTax}");
            //}

            //Console.Write("\nEnter movie name to search: ");
            //string search = Console.ReadLine();
            //Ticket found = cinema.GetMovieByName(search);

            //if (found != null)
            //    Console.WriteLine($"Found: Ticket #{found.TicketId} | {found.MovieName}");
            //else
            //    Console.WriteLine("Not found");

            //Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketsSold()}");

            //Console.WriteLine("Booking Reference 1: " + BookingHelper.GenerateBookingReference());
            //Console.WriteLine("Booking Reference 2: " + BookingHelper.GenerateBookingReference());

            //Console.WriteLine(
            //    $"Group Discount (5 tickets x 80 EGP): {BookingHelper.CalcGroupDiscount(5, 80)} EGP");
        
        #endregion


    }
    }
}
