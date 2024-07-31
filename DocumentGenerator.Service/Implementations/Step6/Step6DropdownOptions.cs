using DocumentGenerator.Service.Interfaces.Step6;
using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Implementations.Step6
{
    public class Step6DropdownOptions : IStep6DropdownOptions
    {
        public Step6DropdownOptions()
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

        public List<SelectListOption> GetCourtSizeOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Standard", Value = "1" },
                new SelectListOption { Text = "Non Standard", Value = "2" }
            };
        }

        public List<SelectListOption> GetFloorCoverTypeOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Over Size Brass", Value = "1" },
                new SelectListOption { Text = "Over Size Chrome", Value = "2" },
                new SelectListOption { Text = "Standard Brass", Value = "3" },
                new SelectListOption { Text = "Standard Chrome", Value = "4" }
            };
        }

        public List<SelectListOption> GetJudesStandOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetMultiSportOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetProtectivePaddingOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetStorageEquipmentOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Storage Cart", Value = "1" },
                new SelectListOption { Text = "Upright Wall Bracket", Value = "2" },
                new SelectListOption { Text = "Horizontal Wall Bracket", Value = "3" },
                new SelectListOption { Text = "Upright Single Transporter", Value = "4" },
                new SelectListOption { Text = "Single Net", Value = "5" },
                new SelectListOption { Text = "Double Net", Value = "6" },
                new SelectListOption { Text = "Triple Net", Value = "7" }
            };
        }

        public List<SelectListOption> GetTelescopingOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetTypeOfSystemOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Portable", Value = "1" },
                new SelectListOption { Text = "Ceiling Hung", Value = "2" },
                new SelectListOption { Text = "Floor Mounted", Value = "3" }
            };
        }
    }
}
