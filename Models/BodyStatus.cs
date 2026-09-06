namespace BamawWebApi.Models
{
    public class BodyStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public VehicleType VehicleType { get; set; }
    }
}