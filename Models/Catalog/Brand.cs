using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class Brand
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        [MaxLength(250)]
        public string? Country { get; set; }
        [MaxLength(250)]
        public string? Website { get; set; }
        public bool IsActive { get; set; }= true;
        public ICollection<BrandVehicleType> BrandVehicleTypes { get; set; } = new List<BrandVehicleType>();



    }
}