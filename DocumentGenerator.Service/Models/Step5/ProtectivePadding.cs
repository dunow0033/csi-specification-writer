namespace DocumentGenerator.Service.Models.Step5
{
    public class ProtectivePadding
    {
        public int Id { get; set; }
        public string? FireRating { get; set; }
        public string? ImpactRating { get; set; }
        public string? Construction { get; set; }
        public string? Quantity { get; set; }
        public string? HeightFt { get; set; }
        public string? HeightIn { get; set; }
        public string? WidthFt { get; set; }
        public string? WidthIn { get; set; }
        public bool SameTypeAndAttachment { get; set; } = false;
        public string? Attachment { get; set; }
        public int ParentId { get; set; }
    }
}
