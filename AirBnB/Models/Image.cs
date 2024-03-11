namespace AirBnB.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public bool isCover { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int LandLord { get; set; }
        public LandLord? LandLordId { get; set; }

    }
}
