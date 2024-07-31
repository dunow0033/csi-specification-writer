using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace DocumentGenerator.Service.Models.Step3
{
    public class DividerCurtain
    {
        public int Id { get; set; }

        [Display(Name = "Curtain Structure")]
        public string? CurtainStructure { get; set; }

        public string? Quantity { get; set; }

        public bool AllTheSameTypeAndAttachment { get; set; } = false;
        public string? HeightFt { get; set; }
        public string? HeightIn { get; set; }
        public string? WidthFt { get; set; }
        public string? WidthIn { get; set; }
        public string? Attachment { get; set; }
        public string? TrussHeightFt { get; set; }
        public string? TrussHeightIn { get; set; }
        public string? TrussSpacingFt { get; set; }
        public string? TrussSpacingIn { get; set; }
        public int ParentId { get; set; }
    }
}
