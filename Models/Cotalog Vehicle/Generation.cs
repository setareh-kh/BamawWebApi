using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models
{
    public class Generation
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public required string Name { get; set; }
        public required string StartYear { get; set; }
        public required string EndYear { get; set; }  
        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; }= null!;
        public ICollection<Trim>? Trims { get; set; }

    }
}