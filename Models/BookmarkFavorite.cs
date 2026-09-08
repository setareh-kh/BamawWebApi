using BamawWebApi.Models.Listing;

namespace BamawWebApi.Models
{
    public enum BookmarkFavoriteType
    {
        Bookmarke=1,Favorite=2
    }
    public class BookmarkFavorite
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public long CarListingId { get; set; }
        public CarListing CarListing { get; set; } = null!;
        public BookmarkFavoriteType Type { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}