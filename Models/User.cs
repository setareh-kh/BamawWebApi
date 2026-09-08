using System.ComponentModel.DataAnnotations;
using BamawWebApi.Models.Listing;

namespace BamawWebApi.Models
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(20)]
        public string MobileNumber { get; set; } = null!;
        public bool IsMobileVerified { get; set; }
        [MaxLength(250)]
        public string? ProfileImageUrl { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<CarListing> CarListings { get; set; }
            = new List<CarListing>();
        public ICollection<BookmarkFavorite> BookmarkFavorites { get; set; }
            = new List<BookmarkFavorite>();
    }
}