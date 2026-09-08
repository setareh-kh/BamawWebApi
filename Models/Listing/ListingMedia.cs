using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Listing
{
    public enum MediaType
{
    Image = 1, Video = 2
}
    public class ListingMedia
{
    public long Id { get; set; }
    public long CarListingId { get; set; }
    public CarListing CarListing { get; set; } = null!;
    public MediaType MediaType { get; set; }
    [MaxLength(250)]
    public string Url { get; set; } = null!;
    public int DisplayOrder { get; set; }
    public DateTime CreatedAt { get; set; }
}
    
}