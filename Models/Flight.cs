namespace WebProgWithAspNet.Models
{
    public class Flight
    {
        public int FlightID { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan DepartureTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public decimal Price { get; set; }
        public string Class { get; set; }
        public decimal ExtraBaggageCost { get; set; }
        public string AirlineName { get; set; }
        public string AircraftModel { get; set; }
    }
}
