namespace DocumentGenerator.Service.Models.Step6
{
    public class Step6Model
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public VolleyballEquipment? VolleyballEquipment { get; set; }
        public VolleyballEquipmentAccessories? VolleyballEquipmentAccessories { get; set; }
    }
}
