using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class Trim
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public  string Name { get; set; }= null!;
        public bool IsActive { get; set; } = true;
        public int BodyTypId { get; set; }
        public BodyType BodyType { get; set; } = null!;
        public int UsageTypeId { get; set; }
        public UsageType? UsageType { get; set; }
        public ICollection<MarketPeriodTrim> MarketPeriodTrims { get; set; }
            =new List<MarketPeriodTrim>();
        

    }
}