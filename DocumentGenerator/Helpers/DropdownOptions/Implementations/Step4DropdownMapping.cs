using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step4;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Implementations
{
    public class Step4DropdownMapping : IStep4DropdownMapping
    {
        public readonly IStep4DropdownOptions _step4DropdownService;

        public Step4DropdownMapping(IStep4DropdownOptions step4DropdownService)
        {
            _step4DropdownService = step4DropdownService;
        }

        public List<SelectListItem> GetAttachmentOptions()
        {
            return _step4DropdownService.GetAttachmentOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetCurtainLockOptions()
        {
            return _step4DropdownService.GetCurtainLockOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetLiftStyleOptions()
        {
            return _step4DropdownService.GetLiftStyleOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetOperationOptions()
        {
            return _step4DropdownService.GetOperationOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetStructureOptions()
        {
            return _step4DropdownService.GetStructureOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }
    }
}
