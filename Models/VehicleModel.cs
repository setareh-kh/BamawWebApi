namespace BamawWebApi.Models
{
    public enum VehicleType
    {
        Car=1, Motorcycle=2, Heavy=3
    }
    public class VehicleModel
    {
        public int Id { get; set; }
        public VehicleType Type { get; set; }
        public int BrandId { get; set; }
        public string ModelName { get; set; } = "";
        public string Title => Brand.Name + " " + ModelName + " " + ProductionYear;
        public Brand Brand { get; set; } = null!;
        public int ProductionYear { get; set; }
        public string? Description { get; set; }
        public required DateTime CreatedAt { get; set; }
        public ICollection<Generation> Generations { get; set; } = new List<Generation>();
        //public List<string>? Images { get; set; }
        //Fk
        public int BodyTypeId { get; set; }
        public BodyType BodyType { get; set; } = null!;
        public Car? Car { get; set; }
        public Motorcycle? Motorcycle { get; set; }
        public Heavy? Heavy { get; set; }


    }
}