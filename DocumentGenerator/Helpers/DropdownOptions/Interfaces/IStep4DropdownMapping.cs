using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Interfaces
{
    public interface IStep4DropdownMapping
    {
        // Batting Multisport Throw Cages
        List<SelectListItem> GetStructureOptions();
        List<SelectListItem> GetAttachmentOptions();
        List<SelectListItem> GetLiftStyleOptions();
        List<SelectListItem> GetOperationOptions();
        List<SelectListItem> GetCurtainLockOptions();
    }
}
