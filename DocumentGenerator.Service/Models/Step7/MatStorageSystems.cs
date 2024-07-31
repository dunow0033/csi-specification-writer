namespace DocumentGenerator.Service.Models.Step7
{
    public class MatStorageSystems
    {
        public int Id { get; set; }
        public string? TypeOfSystem { get; set; }
        public string? Size { get; set; }
        public string? TravelDirection { get; set; }
        public string? Quantity { get; set; }
        public string? Attachment { get; set; }
        public string? TrussHeightFt { get; set; }
        public string? TrussHeightIn { get; set; }
        public string? TrussSpacingFt { get; set; }
        public string? TrussSpacingIn { get; set; }
        public bool SameTypeAndAttachment { get; set; } = false;
        public int ParentId { get; set; }
    }
}
