namespace DocumentGenerator.Service.Models.Step5
{
    public class Step5Model
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public ProtectivePadding? ProtectivePadding { get; set; }
        public ProtectivePaddingAccessories? ProtectivePaddingAccessories { get; set; }
    }
}
