using DocumentGenerator.Service.Interfaces.Step4;
using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Implementations.Step4
{
    public class Step4DropdownOptions : IStep4DropdownOptions
    {
        public Step4DropdownOptions()
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

        public List<SelectListOption> GetLiftStyleOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Standard", Value = "1" },
                new SelectListOption { Text = "Bottom Lift", Value = "2" }
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
                new SelectListOption { Text = "Multisport Cage", Value = "1" },
                new SelectListOption { Text = "Throwing Cage", Value = "2" }
            };
        }
    }
}
