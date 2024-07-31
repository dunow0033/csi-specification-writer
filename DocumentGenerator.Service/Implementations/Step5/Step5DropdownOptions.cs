using DocumentGenerator.Service.Interfaces.Step5;
using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Implementations.Step5
{
    public class Step5DropdownOptions : IStep5DropdownOptions
    {
        public Step5DropdownOptions()
        {
        }

        public List<SelectListOption> GetAttachmentOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Direct Attached Parallel", Value = "1" },
                new SelectListOption { Text = "Direct Attached Perpendicular", Value = "2" },
                new SelectListOption { Text = "Between Trusses Parallel", Value = "3" },
                new SelectListOption { Text = "Between Trusses Perpendicular", Value = "4" }
            };
        }

        public List<SelectListOption> GetConstructionOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Standard", Value = "1" },
                new SelectListOption { Text = "Sewn", Value = "2" }
            };
        }

        public List<SelectListOption> GetCutOutRequiredOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Single", Value = "1" },
                new SelectListOption { Text = "Double", Value = "2" },
                new SelectListOption { Text = "Custom", Value = "3" }
            };
        }

        public List<SelectListOption> GetFireRatingOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Class \"A\" Entire Pad", Value = "1" },
                new SelectListOption { Text = "Class \"A\" Vinyl", Value = "2" },
                new SelectListOption { Text = "No Fire Rating", Value = "3" }
            };
        }

        public List<SelectListOption> GetGraphicsOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetImpactRatingOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "ASTM F2440", Value = "1" },
                new SelectListOption { Text = "No Rating", Value = "2" }
            };
        }
    }
}
