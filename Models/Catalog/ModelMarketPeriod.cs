using System.ComponentModel.DataAnnotations;

namespace BamawWebApi.Models.Catalog
{
    public class ModelMarketPeriod
    {
        public int Id { get; set; }
        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; } = null!;
        public string MarketName{ get; set; } = "Iran";
        public int StartYear { get; set; }
        public int? EndYear { get; set; }
        public bool IsActive { get; set; } = true;
    }
}