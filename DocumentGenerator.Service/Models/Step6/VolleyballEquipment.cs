namespace DocumentGenerator.Service.Models.Step6
{
    public class VolleyballEquipment
    {
        public int Id { get; set; }
        public string? TypeOfSystem { get; set; }
        public string? Telescoping { get; set; }
        public string? MultiSport { get; set; }
        public string? Quantity { get; set; }
        public string? CourtSize { get; set; }
        public string? WidthFt { get; set; }
        public string? WidthIn { get; set; }
        public string? Attachment { get; set; }
        public string? TrussHeightFt { get; set; }
        public string? TrussHeightIn { get; set; }
        public string? TrussSpacingFt { get; set; }
        public string? TrussSpacingIn { get; set; }
        public bool SameTypeAndAttachment { get; set; } = false;
        public int ParentId { get; set; }
    }
}
