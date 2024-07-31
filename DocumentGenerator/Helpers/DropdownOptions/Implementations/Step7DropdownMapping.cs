using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step7;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Implementations
{
    public class Step7DropdownMapping : IStep7DropdownMapping
    {
        public readonly IStep7DropdownOptions _step7DropdownService;

        public Step7DropdownMapping(IStep7DropdownOptions step7DropdownService)
        {
            _step7DropdownService = step7DropdownService;
        }

        public List<SelectListItem> GetAttachmentOptions()
        {
            return _step7DropdownService.GetAttachmentOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetLoadBarsOptions()
        {
            return _step7DropdownService.GetLoadBarsOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetMatStorageSaftySystemOptions()
        {
            return _step7DropdownService.GetMatStorageSaftySystemOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetPhaseOptions()
        {
            return _step7DropdownService.GetPhaseOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetSizeOptions()
        {
            return _step7DropdownService.GetSizeOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetTravelDirectionOptions()
        {
            return _step7DropdownService.GetTravelDirectionOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetTypeOfSystemOptions()
        {
            return _step7DropdownService.GetTypeOfSystemOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetVoltageOptions()
        {
            return _step7DropdownService.GetVoltageOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }
    }
}
