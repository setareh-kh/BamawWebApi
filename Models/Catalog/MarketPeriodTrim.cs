namespace BamawWebApi.Models.Catalog
{
    public class MarketPeriodTrim
    {
        public int ModelMarketPeriodId { get; set; }
        public ModelMarketPeriod ModelMarketPeriod { get; set; } = null!;
        public int TrimId { get; set; }
        public Trim Trim { get; set; } = null!;

    }
}