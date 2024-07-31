using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Interfaces.Step3
{
    public interface IStep3DropdownOptions
    {
        // Divider Curtain
        List<SelectListOption> GetStructureOptions();
        List<SelectListOption> GetAttachmentOptions();
        List<SelectListOption> GetVinylWeightOptions();
        List<SelectListOption> GetOperationOptions();
        List<SelectListOption> GetCurtainLockOptions();
    }
}
