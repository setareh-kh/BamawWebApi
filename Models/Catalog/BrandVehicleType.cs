namespace BamawWebApi.Models.Catalog
{
    public class BrandVehicleType
    {
        public int BrandId { get; set; }
        public Brand Brand { get; set; } = null!;
        public int VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; } = null!;
        public ICollection<VehicleModel> VehicleModels { get; set; } = new List<VehicleModel>();
    }
}