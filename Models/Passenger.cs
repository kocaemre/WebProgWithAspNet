namespace WebProgWithAspNet.Models
{
    public class Passenger
    {
        public int PassengerID { get; set; }
        public int TicketID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navigation property
        public Ticket Ticket { get; set; }
    }
}
