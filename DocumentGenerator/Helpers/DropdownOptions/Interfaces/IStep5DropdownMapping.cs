using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Interfaces
{
    public interface IStep5DropdownMapping
    {
        // Protective Padding
        List<SelectListItem> GetFireRatingOptions();
        List<SelectListItem> GetImpactRatingOptions();
        List<SelectListItem> GetConstructionOptions();
        List<SelectListItem> GetAttachmentOptions();
        List<SelectListItem> GetGraphicsOptions();
        List<SelectListItem> GetCutOutRequiredOptions();
    }
}
