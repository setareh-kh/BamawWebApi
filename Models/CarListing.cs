namespace BamawWebApi.Models
{
    public enum ListingStatus
    {
        Draft = 0,
        PendingReview = 1,
        Published = 2,
        Rejected = 3,
        Suspended = 4,
        Expired = 5,
        Sold = 6
    }
    public enum CarCondition
    {
        New,             // صفر
        Used,            // کارکرده
        PreOrder,        // پیش‌فروش
        Assignment       // حواله
    }
    public class CarListing
    {
        public int Id { get; set; }
        public required string BrandName { get; set; }
        public required string ModelName { get; set; }
        public int ProductionYear { get; set; }
        public string? TrimName { get; set; }
        public CarCondition Condition { get; set; }
        public int ExteriorColorId { get; set; }
        public Color ExteriorColor { get; set; } = null!;
        public int? InteriorColorId { get; set; }
        public Color? InteriorColor { get; set; }
        public int BodyStatusId { get; set; }
        public BodyStatus? BodyStatus { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; } = null!;
        public required decimal Price { get; set; }
        public string? Description { get; set; }
        
        //...
        public required string ContactNumber { get; set; }
        public required DateTime CreatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ListingStatus Status { get; set; }
        public DateTime? ExpiresAt { get; set; }

        // Foreign key for Account
        public int AccountId { get; set; }
        public Account Account { get; set; } = null!;

        public int? VehicleModelId { get; set; }
        public VehicleModel? VehicleModel { get; set; } 

    }
}