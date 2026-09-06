namespace BamawWebApi.Models
{
    public enum LocationType
    {
        Province = 1,
        City = 2,
        Area = 3
    }
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public LocationType Type { get; set; }
        public int? ParentId { get; set; }
        public Location? Parent { get; set; }
        public ICollection<Location> Children { get; set; } = new List<Location>();
        public ICollection<CarListing> Listings { get; set; } = new List<CarListing>();
    }

}