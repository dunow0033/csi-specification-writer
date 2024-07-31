namespace DocumentGenerator.Service.Models.Step4
{
    public class Step4Model
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public BattingMultiSportThrowCagesModel? BattingMultiSportThrowCagesModel { get; set; }
        public List<BattingMultiSportThrowCagesModel>? BattingMultiSportThrowCagesList { get; set; }
    }
}
