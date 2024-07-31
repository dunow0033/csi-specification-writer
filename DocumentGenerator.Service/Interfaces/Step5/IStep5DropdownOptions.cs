using System;
using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Interfaces.Step5
{
    public interface IStep5DropdownOptions
    {
        // Protective Padding
        List<SelectListOption> GetFireRatingOptions();
        List<SelectListOption> GetImpactRatingOptions();
        List<SelectListOption> GetConstructionOptions();
        List<SelectListOption> GetAttachmentOptions();
        List<SelectListOption> GetGraphicsOptions();
        List<SelectListOption> GetCutOutRequiredOptions();
    }
}
