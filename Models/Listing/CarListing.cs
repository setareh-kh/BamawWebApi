using System.ComponentModel.DataAnnotations;
using BamawWebApi.Models.Catalog;

namespace BamawWebApi.Models.Listing
{
    public enum CarUsageStatus
    {
        New = 1, Used = 2, AssignmentPreSale = 3
    }
    public enum DeliveryTime
    {
        day = 1,//تحویل روز
        Less3month = 2 // کمتر از3ماه
    }
    public enum PriceType
    {
        Cash = 1 ,//نقدی
        Installment = 2,//اقساطی
        Negotiable = 3 //توافقی
    }
    public enum InstallmentCount
    {
        ThreeMonths = 3, SixMonths = 6, NineMonths = 9, TwelveMonths = 12, EighteenMonths = 18, TwentyFourMonths = 24
    }
    public enum PaymentDue
    {
        Monthly = 1, EveryTwoMonths = 2, Quarterly = 3
    }
    public enum DeliveryCarTime
    {
        Immediate = 1, OneMonth = 2, ThreeMonths = 3, SixMonths = 4, OneYear = 5
    }
    public class CarListing
    {
        public long Id { get; set; }
        //Catalog
        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; } = null!;
        public int ProductionYear { get; set; }
        public int? TrimId { get; set; }
        public Trim? Trim { get; set; }
        //Vehicle Status =Usage / Status
        public CarUsageStatus UsageStatus { get; set; }
        public int? Mileage { get; set; }
        public DeliveryTime? DeliveryTime { get; set; }
        // Body
        public int ExteriorColorId { get; set; }
        public Color ExteriorColor { get; set; } = null!;
        public int? InteriorColorId { get; set; }
        public Color? InteriorColor { get; set; }
        public int BodyConditionId { get; set; }
        public BodyCondition BodyCondition { get; set; } = null!;
        //Inspection Location
        public int LocationId { get; set; } //LocationId مربوط به District را ذخیره می‌شود.
        public Location Location { get; set; } = null!;
        //Price
        public PriceType PriceType { get; set; }
        public decimal? CashAmount { get; set; }
        public decimal? FirstDownPayment { get; set; }
        public decimal? SecondDownPayment { get; set; }
        public decimal? InstallmentAmount { get; set; }
        public InstallmentCount? InstallmentCount { get; set; }
        public PaymentDue? PaymentDue { get; set; }
        public DeliveryTime? DeliveryCarTime { get; set; }
        public bool FreeZonePlate { get; set; }
        // Description
        [MaxLength(1000)]
        public string? Description { get; set; }
        // Media
        public ICollection<ListingMedia> ListingMedias { get; set; }= new List<ListingMedia>();
        //listing Package
        public int PackageId { get; set; }
        public Package Package { get; set; } = null!;
         // Audit
        public DateTime CreatedAt { get; set; }

    }
}