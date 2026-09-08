using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Listing
{
    public enum LocationType
    {
        Province = 1, City = 2, District = 3
    }
    public class Location
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        public LocationType Type { get; set; }
        public int? ParentId { get; set; }
        public Location? Parent { get; set; }
        public ICollection<Location> Children { get; set; }
            = new List<Location>();
    }
}