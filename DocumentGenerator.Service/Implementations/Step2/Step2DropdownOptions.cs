using DocumentGenerator.Service.Interfaces.Step2;
using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Implementations.Step2
{
    public class Step2DropdownOptions : IStep2DropdownOptions
    {
        public Step2DropdownOptions()
        {
        }

        public List<SelectListOption> GetAccessoriesOperationOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Manual", Value = "1" },
                new SelectListOption { Text = "Electric Keyswitch", Value = "2" },
                new SelectListOption { Text = "Electric Remote", Value = "3" },
                new SelectListOption { Text = "Total System Control", Value = "4" }
            };
        }

        public List<SelectListOption> GetBackboardOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Rectangular Glass Backboard Alum Frame", Value = "1" },
                new SelectListOption { Text = "Rectangular Backboard Steele Frame", Value = "2" },
                new SelectListOption { Text = "1342B Rectangular Fiberglass", Value = "3" },
                new SelectListOption { Text = "1342-B FIBA Rectangular Fiberglass Backboard", Value = "4" },
                new SelectListOption { Text = "1272B Rectangular Steel Backboard", Value = "5" }
            };
        }

        public List<SelectListOption> GetBracedTypeOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Rear Braced", Value = "1" },
                new SelectListOption { Text = "Front Braced", Value = "2" },
                new SelectListOption { Text = "Side Braced", Value = "3" },
                new SelectListOption { Text = "Rolling", Value = "4" }
            };
        }

        public List<SelectListOption> GetDescriptionOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Main Court", Value = "1" },
                new SelectListOption { Text = "Side Court", Value = "2" },
                new SelectListOption { Text = "Aux Court", Value = "3" },
                new SelectListOption { Text = "Practice Court", Value = "4" }
            };
        }

        public List<SelectListOption> GetEdgePaddingOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Glue On", Value = "1" },
                new SelectListOption { Text = "Peel & Stick", Value = "2" },
                new SelectListOption { Text = "Bolt On", Value = "3" }
            };
        }

        public List<SelectListOption> GetExtensionLengthOptionsForPortable()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "10' - 8\"", Value = "1" },
                new SelectListOption { Text = "8\"", Value = "2" },
                new SelectListOption { Text = "5\"", Value = "3" }
            };
        }

        public List<SelectListOption> GetExtensionLengthOptionsForWallmount()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "2' - 3'", Value = "1" },
                new SelectListOption { Text = "3' - 4'", Value = "2" },
                new SelectListOption { Text = "4' - 6'", Value = "3" },
                new SelectListOption { Text = "6' - 9'", Value = "4" },
                new SelectListOption { Text = "9' - 12'", Value = "5" }
            };
        }

        public List<SelectListOption> GetFoldingDirectionOptionsForCeilingSuspendedUnit()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Stationary", Value = "1" },
                new SelectListOption { Text = "Forward Folding", Value = "2" },
                new SelectListOption { Text = "Side Folding", Value = "3" },
                new SelectListOption { Text = "Rear Folding", Value = "4" }
            };
        }

        public List<SelectListOption> GetFoldingDirectionOptionsForWallmount()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Stationary", Value = "1" },
                new SelectListOption { Text = "Fold Up", Value = "2" },
                new SelectListOption { Text = "Side Fold", Value = "3" }
            };
        }

        public List<SelectListOption> GetHeightAdjusterOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetLevelOfUseOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "FIBA", Value = "1", },
                new SelectListOption { Text = "IBL", Value = "2" },
                new SelectListOption { Text = "IOC", Value = "3" },
                new SelectListOption { Text = "NBA", Value = "4" },
                new SelectListOption { Text = "NCAA", Value = "5" },
                new SelectListOption { Text = "NFHS", Value = "6" },
                new SelectListOption { Text = "NAIA", Value = "7" },
                new SelectListOption { Text = "AAU", Value = "8" }
            };
        }

        public List<SelectListOption> GetOperationOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Spring Operation", Value = "1" },
                new SelectListOption { Text = "Hydraulic Operation", Value = "2" }
            };
        }

        public List<SelectListOption> GetOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0" },
                new SelectListOption { Text = "Portable", Value = "1" },
                new SelectListOption { Text = "Wall Mounted", Value = "2" },
                new SelectListOption { Text = "Ceiling Suspended", Value = "3", Selected = true }
            };
        }

        public List<SelectListOption> GetRimOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "3500", Value = "1" },
                new SelectListOption { Text = "2500", Value = "2" },
                new SelectListOption { Text = "2000+", Value = "3" },
                new SelectListOption { Text = "1000", Value = "4" },
                new SelectListOption { Text = "39WO", Value = "5" }
            };
        }

        public List<SelectListOption> GetSafeStopOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetTypeOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "4 Point", Value = "1" },
                new SelectListOption { Text = "3 Point", Value = "2" }
            };
        }
    }
}
