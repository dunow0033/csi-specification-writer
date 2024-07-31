using System;
using DocumentGenerator.Service.Models;

namespace DocumentGenerator.Service.Interfaces.Step4
{
    public interface IStep4DropdownOptions
    {
        // Batting Multisport Throw Cages
        List<SelectListOption> GetStructureOptions();
        List<SelectListOption> GetAttachmentOptions();
        List<SelectListOption> GetLiftStyleOptions();
        List<SelectListOption> GetOperationOptions();
        List<SelectListOption> GetCurtainLockOptions();
    }
}

