namespace BamawWebApi.Models
{
    public class FavoriteBookmark
    {
        public int AccountId  { get; set; }
        public Account? Account { get; set; }
        public int CarListingId { get; set; }
        public CarListing? CarListing { get; set; }
        public byte Type { get; set; } //0=favor  1=bookmark
        public DateTime CreatedAt { get; set; }
    }
}