using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Listing
{
    public class Option
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Code { get; set; } = null!;
        [MaxLength(250)]
        public string Name { get; set; } = null!;
        public ICollection<PackageOption> PackageOptions { get; set; }
            = new List<PackageOption>();
    }
}
