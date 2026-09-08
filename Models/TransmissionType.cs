using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class TransmissionType
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        [MaxLength(500)]
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
    }
}