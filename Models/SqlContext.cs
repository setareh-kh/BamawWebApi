using BamawWebApi.Models.Catalog;
using BamawWebApi.Models.Listing;
using Microsoft.EntityFrameworkCore;

namespace BamawWebApi.Models
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        { }
        public DbSet<Brand> Brands => Set<Brand>();
        public DbSet<BrandVehicleType> BrandVehicleTypes => Set<BrandVehicleType>();
        public DbSet<Trim> Trims => Set<Trim>();
        public DbSet<VehicleModel> VehicleModels => Set<VehicleModel>();
        public DbSet<VehicleType> VehicleTypes => Set<VehicleType>();
        public DbSet<ModelMarketPeriod> ModelMarketPeriods => Set<ModelMarketPeriod>();
        public DbSet<MarketPeriodTrim> MarketPeriodTrims => Set<MarketPeriodTrim>();
        public DbSet<BodyCondition> BodyConditions => Set<BodyCondition>();
        public DbSet<CarListing> CarListings => Set<CarListing>();
        public DbSet<Color> Colors => Set<Color>();
        public DbSet<ListingMedia> ListingMedias => Set<ListingMedia>();
        public DbSet<Location> Locations => Set<Location>();
        public DbSet<Option> Options => Set<Option>();
        public DbSet<Package> Packages => Set<Package>();
        public DbSet<PackageOption> PackageOptions => Set<PackageOption>();
        public DbSet<User> Users => Set<User>();
        public DbSet<OtpVerification> OtpVerifications => Set<OtpVerification>();
        public DbSet<BookmarkFavorite> BookmarkFavorites => Set<BookmarkFavorite>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BrandVehicleType>()
                        .HasKey(a => new { a.BrandId, a.VehicleTypeId });

            //modelBuilder.Entity<VehicleType>()
            //          .HasIndex(a=>a.Code).IsUnique();

            modelBuilder.Entity<VehicleModel>()
                        .HasOne(x => x.BrandVehicleType)
                        .WithMany(a => a.VehicleModels)
                        .HasForeignKey(x => new { x.BrandId, x.VehicleTypeId })
                        .OnDelete(DeleteBehavior.Restrict);
            // 
            modelBuilder.Entity<MarketPeriodTrim>()
                       .HasKey(a => new { a.ModelMarketPeriodId, a.TrimId });
            // 
            modelBuilder.Entity<PackageOption>()
                        .HasKey(a => new { a.PackageId, a.OptionId });
            //
            modelBuilder.Entity<BookmarkFavorite>()
                        .HasKey(a => new { a.UserId, a.CarListingId });
        }
    }
}