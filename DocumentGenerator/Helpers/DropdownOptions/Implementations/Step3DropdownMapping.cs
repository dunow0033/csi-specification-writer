using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step3;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Implementations
{
    public class Step3DropdownMapping : IStep3DropdownMapping
    {
        public readonly IStep3DropdownOptions _step3DropdownService;

        public Step3DropdownMapping(IStep3DropdownOptions step3DropdownService)
        {
            _step3DropdownService = step3DropdownService;
        }

        public List<SelectListItem> GetAttachmentOptions()
        {
            return _step3DropdownService.GetAttachmentOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetCurtainLockOptions()
        {
            return _step3DropdownService.GetCurtainLockOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetOperationOptions()
        {
            return _step3DropdownService.GetOperationOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetStructureOptions()
        {
            return _step3DropdownService.GetStructureOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetVinylWeightOptions()
        {
            return _step3DropdownService.GetVinylWeightOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }
    }
}
