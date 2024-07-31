namespace DocumentGenerator.Service.Models.Step1
{
    public class GpsDistributor
    {
        public int Id { get; set; } // A
        public string? Name { get; set; } // B
        public string? Address { get; set; } // C
        public string? City { get; set; } // D
        public string? Country { get; set; } // E
        public string? State { get; set; } // F
        public string? ZipCode { get; set; } // G
        public int ParentId { get; set; } // H
    }
}
