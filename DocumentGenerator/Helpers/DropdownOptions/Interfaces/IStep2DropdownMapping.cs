using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Interfaces
{
    public interface IStep2DropdownMapping
    {
        // Basketball
        List<SelectListItem> GetOptions();
        List<SelectListItem> GetDescriptionOptions();
        List<SelectListItem> GetExtensionLengthOptionsForPortable();
        List<SelectListItem> GetExtensionLengthOptionsForWallmount();
        List<SelectListItem> GetOperationOptions();
        List<SelectListItem> GetLevelOfUseOptions();
        List<SelectListItem> GetTypeOptions();
        List<SelectListItem> GetFoldingDirectionOptionsForWallmount();
        List<SelectListItem> GetFoldingDirectionOptionsForCeilingSuspendedUnit();
        List<SelectListItem> GetBracedTypeOptions();

        List<SelectListItem> GetBackboardOptions();
        List<SelectListItem> GetRimOptions();
        List<SelectListItem> GetEdgePaddingOptions();
        List<SelectListItem> GetAccessoriesOperationOptions();
        List<SelectListItem> GetHeightAdjusterOptions();
        List<SelectListItem> GetSafeStopOptions();
    }
}

