using System;
using DocumentGenerator.Service.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Interfaces
{
    public interface IStep7DropdownMapping
    {
        // Mat Storage Systems
        List<SelectListItem> GetTypeOfSystemOptions();
        List<SelectListItem> GetSizeOptions();
        List<SelectListItem> GetTravelDirectionOptions();
        List<SelectListItem> GetAttachmentOptions();

        List<SelectListItem> GetLoadBarsOptions();
        List<SelectListItem> GetMatStorageSaftySystemOptions();
        List<SelectListItem> GetVoltageOptions();
        List<SelectListItem> GetPhaseOptions();
    }
}

