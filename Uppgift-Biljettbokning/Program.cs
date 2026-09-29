using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Event> events = new List<Event>
        {
            new Event("Rock Night", 10),
            new Event("Jazz Evening", 4),
            new Event("Choir Concert", 6)
        };

        events[0].BookTicket(4);
        events[1].BookTicket(3);
        events[2].BookTicket(5);
        events[0].BookTicket(8);
        events[1].BookTicket(2);

        events[2].CancelTicket(2);
        events[1].CancelTicket(5);

        Console.WriteLine();

        foreach (Event concert in events)
            Console.WriteLine($"{concert.Name}: {concert.AvailableSeats} seats left");
    }
}