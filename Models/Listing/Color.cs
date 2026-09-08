using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Listing
{
    public class Color
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Code { get; set; } = null!;
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; } = true;
    }
}