using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step4;
using DocumentGenerator.Service.Interfaces.Step6;
using DocumentGenerator.Service.Interfaces.Step7;
using DocumentGenerator.Service.Models.Step2;
using DocumentGenerator.Service.Models.Step6;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class Step6Controller : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;
        private readonly IStep6 _step6Service;

        private readonly IStep6DropdownMapping _dropdownOptions;

        public Step6Controller(IWebHostEnvironment webHostEnvironment, IStep6DropdownMapping dropdownOptions, IStep6 step6Service)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step6.xlsx";

            _dropdownOptions = dropdownOptions;
            _step6Service = step6Service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            Step6Model step6Model = new();

            string? idString = HttpContext.Request.Cookies["id"];
            if (int.TryParse(idString, out int id))
            {
                step6Model = _step6Service.GetById(_excelPath, id);
            }

            ViewBag.TypeOfSystemOptions = _dropdownOptions.GetTypeOfSystemOptions();
            ViewBag.TelescopingOptions = _dropdownOptions.GetTelescopingOptions();
            ViewBag.MultiSportOptions = _dropdownOptions.GetMultiSportOptions();
            ViewBag.CourtSizeOptions = _dropdownOptions.GetCourtSizeOptions();
            ViewBag.AttachmentOptions = _dropdownOptions.GetAttachmentOptions();
            ViewBag.FloorCoverTypeOptions = _dropdownOptions.GetFloorCoverTypeOptions();
            ViewBag.ProtectivePaddingOptions = _dropdownOptions.GetProtectivePaddingOptions();
            ViewBag.JudesStandOptions = _dropdownOptions.GetJudesStandOptions();
            ViewBag.StorageEquipmentOptions = _dropdownOptions.GetStorageEquipmentOptions();

            return View(step6Model);
        }

        [HttpPost]
        public ActionResult Create(Step6Model step6Model)
        {
            _step6Service.Create(_excelPath, step6Model);
            return RedirectToAction("Index", "Step7");
        }
    }
}

