using System;

class Event
{
    private string name;
    private int totalSeats;
    private int bookedSeats;

    public Event(string name, int totalSeats)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.");

        if (totalSeats <= 0)
            throw new ArgumentException("Total seats must be greater than zero.");

        this.name = name.Trim();
        this.totalSeats = totalSeats;
        bookedSeats = 0;
    }

    public string Name
    {
        get { return name; }
    }

    public int AvailableSeats
    {
        get { return totalSeats - bookedSeats; }
    }

    public bool BookTicket(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be greater than zero.");
            return false;
        }

        if (amount > AvailableSeats)
        {
            Console.WriteLine($"{Name}: could not book {amount}. Available seats: {AvailableSeats}.");
            return false;
        }

        bookedSeats += amount;
        Console.WriteLine($"{Name}: booked {amount}. Available seats: {AvailableSeats}.");
        return true;
    }

    public bool CancelTicket(int amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Amount must be greater than zero.");
            return false;
        }

        if (amount > bookedSeats)
        {
            Console.WriteLine($"{Name}: could not cancel {amount}. Booked seats: {bookedSeats}.");
            return false;
        }

        bookedSeats -= amount;
        Console.WriteLine($"{Name}: cancelled {amount}. Available seats: {AvailableSeats}.");
        return true;
    }
}