using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Interfaces
{
    public interface IStep6DropdownMapping
    {
        // Volleyball Equipment
        List<SelectListItem> GetTypeOfSystemOptions();
        List<SelectListItem> GetTelescopingOptions();
        List<SelectListItem> GetMultiSportOptions();
        List<SelectListItem> GetCourtSizeOptions();
        List<SelectListItem> GetAttachmentOptions();

        List<SelectListItem> GetFloorCoverTypeOptions();
        List<SelectListItem> GetProtectivePaddingOptions();
        List<SelectListItem> GetJudesStandOptions();
        List<SelectListItem> GetStorageEquipmentOptions();
    }
}
