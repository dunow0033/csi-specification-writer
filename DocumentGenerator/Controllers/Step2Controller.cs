using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step2;
using DocumentGenerator.Service.Models.Step2;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class Step2Controller : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;
        private readonly IStep2DropdownMapping _dropdownOptions;
        private readonly IStep2 _step2Service;


        public Step2Controller(IWebHostEnvironment webHostEnvironment, IStep2DropdownMapping dropdownOptions, IStep2 step2Service)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step2.xlsx";

            _dropdownOptions = dropdownOptions;
            _step2Service = step2Service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            Step2Model step2Model = new();

            string? idString = HttpContext.Request.Cookies["id"];
            if (int.TryParse(idString, out int id))
            {
                step2Model = _step2Service.GetById(_excelPath, id);
            }

            ViewBag.Options = _dropdownOptions.GetOptions();
            ViewBag.DescriptionOptions = _dropdownOptions.GetDescriptionOptions();
            ViewBag.ExtensionLengthOptionsForPortable = _dropdownOptions.GetExtensionLengthOptionsForPortable();
            ViewBag.ExtensionLengthOptionsForWallmount = _dropdownOptions.GetExtensionLengthOptionsForWallmount();
            ViewBag.OperationOptions = _dropdownOptions.GetOperationOptions();
            ViewBag.LevelOfUseOptions = _dropdownOptions.GetLevelOfUseOptions();
            ViewBag.TypeOptions = _dropdownOptions.GetTypeOptions();
            ViewBag.FoldingDirectionOptionsForWallmount = _dropdownOptions.GetFoldingDirectionOptionsForWallmount();
            ViewBag.FoldingDirectionOptionsForCeilingSuspendedUnit = _dropdownOptions.GetFoldingDirectionOptionsForCeilingSuspendedUnit();
            ViewBag.BracedTypeOptions = _dropdownOptions.GetBracedTypeOptions();
            ViewBag.BackboardOptions = _dropdownOptions.GetBackboardOptions();
            ViewBag.RimOptions = _dropdownOptions.GetRimOptions();
            ViewBag.EdgePaddingOptions = _dropdownOptions.GetEdgePaddingOptions();
            ViewBag.AccessoriesOperationOptions = _dropdownOptions.GetAccessoriesOperationOptions();
            ViewBag.HeightAdjusterOptions = _dropdownOptions.GetHeightAdjusterOptions();
            ViewBag.SafeStopOptions = _dropdownOptions.GetSafeStopOptions();

            return View(step2Model);
        }

        [HttpPost]
        public ActionResult Create(Step2Model step2Model)
        {
            _step2Service.Create(_excelPath, step2Model);
            return RedirectToAction("Index", "Step3");
        }
    }
}

