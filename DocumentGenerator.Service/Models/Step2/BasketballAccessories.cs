namespace DocumentGenerator.Service.Models.Step2
{
    public class BasketballAccessories
    {
        public int Id { get; set; }
        public string? Backboard { get; set; }
        public string? Operation1 { get; set; }
        public string? Operation2 { get; set; }
        public string? Rim { get; set; }
        public string? HeightAdjuster { get; set; }
        public string? EdgePadding { get; set; }
        public string? SafeStop { get; set; }
        public int ParentId { get; set; }
    }
}
