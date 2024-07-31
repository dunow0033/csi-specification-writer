namespace DocumentGenerator.Service.Models.Step4
{
    public class BattingMultiSportThrowCages
    {
        public int Id { get; set; }
        public string? Structure { get; set; }
        public string? Quantity { get; set; }
        public string? HeightFt { get; set; }
        public string? HeightIn { get; set; }
        public string? WidthFt { get; set; }
        public string? WidthIn { get; set; }
        public string? LengthFt { get; set; }
        public string? LengthIn { get; set; }
        public bool SameTypeAndAttachment { get; set; } = false;
        public string? Attachment { get; set; }
        public string? TrussHeightFt { get; set; }
        public string? TrussHeightIn { get; set; }
        public string? TrussSpacingFt { get; set; }
        public string? TrussSpacingIn { get; set; }
        public int ParentId { get; set; }
    }
}
