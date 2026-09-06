using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public required string Name { get; set; }
       // [MaxLength(250)]
        //public required string LogoUrl { get; set; }
        [MaxLength(250)]
        public required string Country { get; set; }
        [MaxLength(250)]
        public required string Website { get; set; }
        public bool IsActive { get; set; }
        public  required DateTime CreatedAt  { get; set; }
        public ICollection<VehicleModel> VehicleModels { get; set; } = new List<VehicleModel>();


    }
}