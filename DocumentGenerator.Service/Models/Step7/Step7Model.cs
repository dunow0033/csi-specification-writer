namespace DocumentGenerator.Service.Models.Step7
{
    public class Step7Model
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime DeletedOn { get; set; }
        public MatStorageSystems? MatStorageSystems { get; set; }
        public MatStorageAccessories? MatStorageAccessories { get; set; }
    }
}
