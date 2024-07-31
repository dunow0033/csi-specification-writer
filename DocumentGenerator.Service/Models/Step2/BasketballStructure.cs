namespace DocumentGenerator.Service.Models.Step2
{
    public class BasketballStructure
    {
        public int Id { get; set; }
        public string? BasketBallStructure { get; set; }
        public string? Quantity { get; set; }
        public string? Description { get; set; }
        public string? ExtensionLength { get; set; }
        public string? Operation { get; set; }
        public string? LevelOfUse { get; set; }
        public string? Type { get; set; }
        public string? FoldingDirection { get; set; }
        public string? TrussHeightFeet { get; set; }
        public string? TrussHeightInches { get; set; }
        public string? BracedType { get; set; }
        public int ParentId { get; set; }
    }
}
