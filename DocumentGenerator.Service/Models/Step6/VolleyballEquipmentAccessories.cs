namespace DocumentGenerator.Service.Models.Step6
{
    public class VolleyballEquipmentAccessories
    {
        public int Id { get; set; }
        public string? FloorCoveringType { get; set; }
        public string? ProtectivePadding { get; set; }
        public string? JudgesStand { get; set; }
        public string? StorageEquipment { get; set; }
        public List<string>? StorageEquipmentList { get; set; }
        public int ParentId { get; set; }
    }
}
