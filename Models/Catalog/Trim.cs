using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class Trim
    {
        public int Id { get; set; }
        public int GenerationId { get; set; }
        public Generation Generation { get; set; } = null!;
        [MaxLength(250)]
        public  string Name { get; set; }= null!;
        public bool IsActive { get; set; } = true;
    }
}