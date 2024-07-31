namespace DocumentGenerator.Service.Models.Step1
{
    public class ArchitectInformation
    {
        public int Id { get; set; } // A
        public string? Name { get; set; } // B
        public string? Country { get; set; } // C
        public string? StateProvidence { get; set; } // D
        public string? ZipPostalCode { get; set; } // E
        public int ParentId { get; set; } // F
    }
}
