using Microsoft.AspNetCore.Routing.Constraints;

namespace AirBnB.Models
{

    public enum LocationType
    {

    }
    public class Location
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public LocationType Type { get; set; }
        public int Rooms { get; set; }
        public int NumberOfGuests { get; set; }
        public float PricePerDay { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<Image> Images { get; set; }
        public int LandLordId { get; set; }
        public LandLord LandLord { get; set; }
    }
}
