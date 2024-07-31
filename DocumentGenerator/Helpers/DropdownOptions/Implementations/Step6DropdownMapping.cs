using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step6;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Implementations
{
    public class Step6DropdownMapping : IStep6DropdownMapping
    {
        public readonly IStep6DropdownOptions _step6DropdownService;

        public Step6DropdownMapping(IStep6DropdownOptions step6DropdownService)
        {
            _step6DropdownService = step6DropdownService;
        }

        public List<SelectListItem> GetAttachmentOptions()
        {
            return _step6DropdownService.GetAttachmentOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetCourtSizeOptions()
        {
            return _step6DropdownService.GetCourtSizeOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetFloorCoverTypeOptions()
        {
            return _step6DropdownService.GetFloorCoverTypeOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetJudesStandOptions()
        {
            return _step6DropdownService.GetJudesStandOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetMultiSportOptions()
        {
            return _step6DropdownService.GetMultiSportOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetProtectivePaddingOptions()
        {
            return _step6DropdownService.GetProtectivePaddingOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetStorageEquipmentOptions()
        {
            return _step6DropdownService.GetStorageEquipmentOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetTelescopingOptions()
        {
            return _step6DropdownService.GetTelescopingOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetTypeOfSystemOptions()
        {
            return _step6DropdownService.GetTypeOfSystemOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }
    }
}
