namespace BamawWebApi.Models
{
    public class Car
    {
        public int Id { get; set; }
        public CarTechnicalSpecifications technicalSpecifications { get; set; }=new();
        //...

        //fk
        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; }= null!;
    }
}