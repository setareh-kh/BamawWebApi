namespace BamawWebApi.Models
{
    public class Heavy
    {
        public int Id { get; set; }
        public HeavyTechnicalSpecifications technicalSpecifications { get; set; }=new();
        //...

        //fk
        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; }= null!;
    }
}