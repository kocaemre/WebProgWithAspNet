namespace WebProgWithAspNet.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string PNR { get; set; }
        public int FlightID { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int PassengerCount { get; set; }
        public int ExtraBaggage { get; set; }
        public string Class { get; set; }
        public decimal TotalPrice { get; set; }

        // Navigation property
        public Flight Flight { get; set; }
    }
}
