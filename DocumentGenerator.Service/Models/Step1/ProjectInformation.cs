namespace DocumentGenerator.Service.Models.Step1
{
    public class ProjectInformation
    {
        public int Id { get; set; } // A
        public DateTime Date { get; set; } // B
        public string? DateDisplay { get; set; }
        public string? Number { get; set; } // C
        public string? Name { get; set; } // D
        public string? Address { get; set; } // E
        public string? Country { get; set; } // F
        public string? StateProvidence { get; set; } // G
        public string? ZipPostalCode { get; set; } // H
        public int ParentId { get; set; } // I
    }
}
