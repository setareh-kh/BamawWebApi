using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models
{
    public class BodyType
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public required string Name { get; set; }
        public required VehicleType Type { get; set; }       


    }
}