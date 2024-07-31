using DocumentGenerator.Service.Interfaces.Step3;
using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Implementations.Step3
{
    public class Step3DropdownOptions : IStep3DropdownOptions
    {
        public Step3DropdownOptions()
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

        public List<SelectListOption> GetCurtainLockOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetOperationOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Electric Keyswitch", Value = "1" },
                new SelectListOption { Text = "Electric Remote", Value = "2" },
                new SelectListOption { Text = "Total System Control", Value = "3" }
            };
        }

        public List<SelectListOption> GetStructureOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Fold Up", Value = "1" },
                new SelectListOption { Text = "Center Drive", Value = "2" },
                new SelectListOption { Text = "Roll Up", Value = "3" },
                new SelectListOption { Text = "Top Roll", Value = "4" },
                new SelectListOption { Text = "Walk Draw", Value = "5" },
                new SelectListOption { Text = "Peak Fold", Value = "6" },
                new SelectListOption { Text = "Slope Fold", Value = "7" }
            };
        }

        public List<SelectListOption> GetVinylWeightOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "19 oz", Value = "1" },
                new SelectListOption { Text = "22 oz", Value = "2" }
            };
        }
    }
}

