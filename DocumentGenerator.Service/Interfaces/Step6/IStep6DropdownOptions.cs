using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Interfaces.Step6
{
    public interface IStep6DropdownOptions
    {
        // Volleyball Equipment
        List<SelectListOption> GetTypeOfSystemOptions();
        List<SelectListOption> GetTelescopingOptions();
        List<SelectListOption> GetMultiSportOptions();
        List<SelectListOption> GetCourtSizeOptions();
        List<SelectListOption> GetAttachmentOptions();

        List<SelectListOption> GetFloorCoverTypeOptions();
        List<SelectListOption> GetProtectivePaddingOptions();
        List<SelectListOption> GetJudesStandOptions();
        List<SelectListOption> GetStorageEquipmentOptions();
    }
}
