using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class VehicleType
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Code { get; set; } = null!;
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        public ICollection<BrandVehicleType> BrandVehicleTypes { get; set; } = new List<BrandVehicleType>();
        public ICollection<BodyType> BodyTypes { get; set; } = new List<BodyType>();
        public ICollection<UsageType> UsageTypes { get; set; } = new List<UsageType>();

    }
}