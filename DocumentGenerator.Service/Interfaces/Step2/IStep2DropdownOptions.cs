using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Interfaces.Step2
{
    public interface IStep2DropdownOptions
    {
        // Basketball
        List<SelectListOption> GetOptions();
        List<SelectListOption> GetDescriptionOptions();
        List<SelectListOption> GetExtensionLengthOptionsForPortable();
        List<SelectListOption> GetExtensionLengthOptionsForWallmount();
        List<SelectListOption> GetOperationOptions();
        List<SelectListOption> GetLevelOfUseOptions();
        List<SelectListOption> GetTypeOptions();
        List<SelectListOption> GetFoldingDirectionOptionsForWallmount();
        List<SelectListOption> GetFoldingDirectionOptionsForCeilingSuspendedUnit();
        List<SelectListOption> GetBracedTypeOptions();

        List<SelectListOption> GetBackboardOptions();
        List<SelectListOption> GetRimOptions();
        List<SelectListOption> GetEdgePaddingOptions();
        List<SelectListOption> GetAccessoriesOperationOptions();
        List<SelectListOption> GetHeightAdjusterOptions();
        List<SelectListOption> GetSafeStopOptions();
    }
}
