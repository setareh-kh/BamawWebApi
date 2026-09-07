using BamawWebApi.Models.Catalog;
using Microsoft.EntityFrameworkCore;

namespace BamawWebApi.Models
{
    public class SqlContext:DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options):base(options)
        {}
        public DbSet<Brand> Brands  => Set<Brand>();
        public DbSet<BrandVehicleType> BrandVehicleTypes => Set<BrandVehicleType>();
        public DbSet<Generation> Generations => Set<Generation>();
        public DbSet<Trim> Trims => Set<Trim>();
        public DbSet<VehicleModel> VehicleModels => Set<VehicleModel>();
        public DbSet<VehicleType> VehicleTypes => Set<VehicleType>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BrandVehicleType>()
                        .HasKey(a=> new {a.BrandId, a.VehicleTypeId});

            //modelBuilder.Entity<VehicleType>()
              //          .HasIndex(a=>a.Code).IsUnique();

            modelBuilder.Entity<VehicleModel>()
                        .HasOne(x=>x.BrandVehicleType)
                        .WithMany(a=>a.VehicleModels)
                        .HasForeignKey(x=>new {x.BrandId, x.VehicleTypeId})
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}