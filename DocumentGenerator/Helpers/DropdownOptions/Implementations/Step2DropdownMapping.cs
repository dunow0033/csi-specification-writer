using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step2;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DocumentGenerator.Helpers.DropdownOptions.Implementations
{
    public class Step2DropdownMapping : IStep2DropdownMapping
    {
        public readonly IStep2DropdownOptions _step2DropdownService;

        public Step2DropdownMapping(IStep2DropdownOptions step2DropdownService)
        {
            _step2DropdownService = step2DropdownService;
        }

        public List<SelectListItem> GetAccessoriesOperationOptions()
        {
            return _step2DropdownService.GetAccessoriesOperationOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetBackboardOptions()
        {
            return _step2DropdownService.GetBackboardOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetBracedTypeOptions()
        {
            return _step2DropdownService.GetBracedTypeOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetDescriptionOptions()
        {
            return _step2DropdownService.GetDescriptionOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetEdgePaddingOptions()
        {
            return _step2DropdownService.GetEdgePaddingOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetExtensionLengthOptionsForPortable()
        {
            return _step2DropdownService.GetExtensionLengthOptionsForPortable().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetExtensionLengthOptionsForWallmount()
        {
            return _step2DropdownService.GetExtensionLengthOptionsForWallmount().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetFoldingDirectionOptionsForCeilingSuspendedUnit()
        {
            return _step2DropdownService.GetFoldingDirectionOptionsForCeilingSuspendedUnit().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetFoldingDirectionOptionsForWallmount()
        {
            return _step2DropdownService.GetFoldingDirectionOptionsForWallmount().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetHeightAdjusterOptions()
        {
            return _step2DropdownService.GetHeightAdjusterOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetLevelOfUseOptions()
        {
            return _step2DropdownService.GetLevelOfUseOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetOperationOptions()
        {
            return _step2DropdownService.GetOperationOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetOptions()
        {
            return _step2DropdownService.GetOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetRimOptions()
        {
            return _step2DropdownService.GetRimOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetSafeStopOptions()
        {
            return _step2DropdownService.GetSafeStopOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }

        public List<SelectListItem> GetTypeOptions()
        {
            return _step2DropdownService.GetTypeOptions().Select(x => new SelectListItem()
            {
                Text = x.Text,
                Value = x.Value,
                Selected = x.Selected
            }).ToList();
        }
    }
}
