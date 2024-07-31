using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step4;
using DocumentGenerator.Service.Interfaces.Step5;
using DocumentGenerator.Service.Interfaces.Step7;
using DocumentGenerator.Service.Models.Step2;
using DocumentGenerator.Service.Models.Step5;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class Step5Controller : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;
        private readonly IStep5 _step5Service;

        private readonly IStep5DropdownMapping _dropdownOptions;

        public Step5Controller(IWebHostEnvironment webHostEnvironment, IStep5DropdownMapping dropdownOptions, IStep5 step5Service)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step5.xlsx";

            _dropdownOptions = dropdownOptions;
            _step5Service = step5Service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            Step5Model step5Model = new();

            string? idString = HttpContext.Request.Cookies["id"];
            if (int.TryParse(idString, out int id))
            {
                step5Model = _step5Service.GetById(_excelPath, id);
            }

            ViewBag.FireRatingOptions = _dropdownOptions.GetFireRatingOptions();
            ViewBag.ImpactRatingOptions = _dropdownOptions.GetImpactRatingOptions();
            ViewBag.ConstructionOptions = _dropdownOptions.GetConstructionOptions();
            ViewBag.AttachmentOptions = _dropdownOptions.GetAttachmentOptions();
            ViewBag.GraphicsOptions = _dropdownOptions.GetGraphicsOptions();
            ViewBag.CutOutRequiredOptions = _dropdownOptions.GetCutOutRequiredOptions();

            return View(step5Model);
        }

        [HttpPost]
        public ActionResult Create(Step5Model step5Model)
        {
            _step5Service.Create(_excelPath, step5Model);
            return RedirectToAction("Index", "Step6");
        }
    }
}

