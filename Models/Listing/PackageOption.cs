using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Listing
{
    public class PackageOption
{
    public int PackageId { get; set; }
    public Package Package { get; set; } = null!;
    public int OptionId { get; set; }
    public Option Option { get; set; } = null!;
    public int DisplayOrder { get; set; }
}
}
