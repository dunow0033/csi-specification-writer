using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Interfaces.Step7
{
    public interface IStep7DropdownOptions
    {
        // Mat Storage Systems
        List<SelectListOption> GetTypeOfSystemOptions();
        List<SelectListOption> GetSizeOptions();
        List<SelectListOption> GetTravelDirectionOptions();
        List<SelectListOption> GetAttachmentOptions();

        List<SelectListOption> GetLoadBarsOptions();
        List<SelectListOption> GetMatStorageSaftySystemOptions();
        List<SelectListOption> GetVoltageOptions();
        List<SelectListOption> GetPhaseOptions();
    }
}
