using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step5;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Implementations
{
    public class Step5DropdownMapping : IStep5DropdownMapping
    {
        public readonly IStep5DropdownOptions _step5DropdownService;

        public Step5DropdownMapping(IStep5DropdownOptions step5DropdownService)
        {
            _step5DropdownService = step5DropdownService;
        }

        public List<SelectListItem> GetAttachmentOptions()
        {
            return _step5DropdownService.GetAttachmentOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetConstructionOptions()
        {
            return _step5DropdownService.GetConstructionOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetCutOutRequiredOptions()
        {
            return _step5DropdownService.GetCutOutRequiredOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetFireRatingOptions()
        {
            return _step5DropdownService.GetFireRatingOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetGraphicsOptions()
        {
            return _step5DropdownService.GetGraphicsOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetImpactRatingOptions()
        {
            return _step5DropdownService.GetImpactRatingOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }
    }
}
