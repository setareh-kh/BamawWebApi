using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models
{
    public class Trim
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public required string Name { get; set; }
        public int GenerationId { get; set; }
        public Generation Generation { get; set; }= null!;         

    }
}