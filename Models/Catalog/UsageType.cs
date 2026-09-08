using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class UsageType
    {
        public int Id { get; set; }
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; } = null!;
        //[MaxLength(250)]
       // public string Code { get; set; } = null!;
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        [MaxLength(500)]
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<Trim> Trims { get; set; }=new List<Trim>();
    }
}