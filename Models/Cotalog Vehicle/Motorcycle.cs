namespace BamawWebApi.Models
{
    public class Motorcycle
    {
        public int Id { get; set; }
        public MotorcycleTechnicalSpecifications technicalSpecifications { get; set; }=new();
        //...
        //fk
        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; }= null!;
    }
}