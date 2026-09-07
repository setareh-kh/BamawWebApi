using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int VehicleTypeId { get; set; }
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        public BrandVehicleType BrandVehicleType { get; set; } = null!;
        public bool IsActive { get; set; } = true;
        [MaxLength(500)]
        public string? Description { get; set; }

        public ICollection<Generation> Generations { get; set; } = new List<Generation>();

        //public List<string>? Images { get; set; }



    }
}