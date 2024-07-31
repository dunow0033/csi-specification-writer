namespace DocumentGenerator.Service.Models.Step2
{
    public class Step2Model
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public BasketballStructure? BasketballStructure { get; set; }
        public BasketballAccessories? BasketballAccessories { get; set; }
    }
}

