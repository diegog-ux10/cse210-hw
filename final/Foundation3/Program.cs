class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak St", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Pine St", "Vancouver", "BC", "Canada");

        Lecture lecture = new("C# Basics", "Introduction to C#", DateTime.Now.AddDays(10), "10:00 AM", address1, "John Doe", 50);
        Reception reception = new("Company Gala", "Annual company gala", DateTime.Now.AddDays(20), "6:00 PM", address2);
        OutdoorGathering outdoor = new("Picnic in the Park", "Community picnic", DateTime.Now.AddDays(30), "2:00 PM", address3, "Sunny");

        reception.RegisterAttendance("John Doe");
        reception.RegisterAttendance("Mike Lee");
        reception.RegisterAttendance("Julia Moore");

        List<Event> events = new List<Event> { lecture, reception, outdoor };

        foreach (Event ev in events)
        {
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}
