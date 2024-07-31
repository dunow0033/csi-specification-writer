namespace DocumentGenerator.Service.Models.Step3
{
    public class CurtainModel
    {
        public int Id { get; set; }
        public DividerCurtain? DividerCurtain { get; set; }
        public CurtainAccessories? CurtainAccessories { get; set; }
        public int ParentId { get; set; }
    }
}
