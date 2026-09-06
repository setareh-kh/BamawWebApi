namespace BamawWebApi.Models
{
    public class CarTechnicalSpecifications
    {
        public string EngineType { get; set; } = "";
        public int CylinderCount { get; set; }
        public decimal EngineDisplacement { get; set; }
        public string FuelType { get; set; } = "";
    }
}