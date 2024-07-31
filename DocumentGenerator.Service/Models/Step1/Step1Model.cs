namespace DocumentGenerator.Service.Models.Step1
{
    public class Step1Model
    {
        public int Id { get; set; } // A
        public DateTime? CreatedOn { get; set; } // B
        public DateTime? DeletedOn { get; set; } // C
        public ProjectInformation? ProjectInformation { get; set; }
        public ArchitectInformation? ArchitectInformation { get; set; }
        public GpsDistributor? GpsDistributor { get; set; }
    }
}

