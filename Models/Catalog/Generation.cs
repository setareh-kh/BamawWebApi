using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class Generation
    {
        public int Id { get; set; }
        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; } = null!;
        [MaxLength(250)]
        public required string Name { get; set; } = null!;
        public int StartYear { get; set; }
        public int? EndYear { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Trim>? Trims { get; set; }

    }
}