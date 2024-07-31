using DocumentGenerator.Service.Interfaces.Step7;
using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Implementations.Step7
{
    public class Step7DropdownOptions : IStep7DropdownOptions
    {
        public Step7DropdownOptions()
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

        public List<SelectListOption> GetLoadBarsOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Single", Value = "1" },
                new SelectListOption { Text = "Double", Value = "2" }
            };
        }

        public List<SelectListOption> GetMatStorageSaftySystemOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Yes", Value = "1" },
                new SelectListOption { Text = "No", Value = "2" }
            };
        }

        public List<SelectListOption> GetPhaseOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Single", Value = "1" },
                new SelectListOption { Text = "Three", Value = "2" }
            };
        }

        public List<SelectListOption> GetSizeOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Standard", Value = "1" },
                new SelectListOption { Text = "Mini", Value = "2" }
            };
        }

        public List<SelectListOption> GetTravelDirectionOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Forward Moving", Value = "1" },
                new SelectListOption { Text = "Side Moving", Value = "2" }
            };
        }

        public List<SelectListOption> GetTypeOfSystemOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "Stationary", Value = "1" },
                new SelectListOption { Text = "Traveling", Value = "2" }
            };
        }

        public List<SelectListOption> GetVoltageOptions()
        {
            return new()
            {
                new SelectListOption { Text = string.Empty, Value = "0", Selected = true },
                new SelectListOption { Text = "208/220V", Value = "1" },
                new SelectListOption { Text = "460/480", Value = "2"}
            };
        }
    }
}
