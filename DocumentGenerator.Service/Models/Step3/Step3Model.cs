namespace DocumentGenerator.Service.Models.Step3
{
    public class Step3Model
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public CurtainModel? CurtainModel { get; set; }
        public List<CurtainModel>? CurtainList { get; set; }
    }
}
