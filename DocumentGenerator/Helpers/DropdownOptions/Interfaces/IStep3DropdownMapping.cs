using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Interfaces
{
    public interface IStep3DropdownMapping
    {
        // Divider Curtain
        List<SelectListItem> GetStructureOptions();
        List<SelectListItem> GetAttachmentOptions();
        List<SelectListItem> GetVinylWeightOptions();
        List<SelectListItem> GetOperationOptions();
        List<SelectListItem> GetCurtainLockOptions();
    }
}
