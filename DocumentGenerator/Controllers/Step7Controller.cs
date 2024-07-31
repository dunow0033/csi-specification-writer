using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step4;
using DocumentGenerator.Service.Interfaces.Step7;
using DocumentGenerator.Service.Models.Step2;
using DocumentGenerator.Service.Models.Step7;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class Step7Controller : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;
        private readonly IStep7 _step7Service;

        private readonly IStep7DropdownMapping _dropdownOptions;

        public Step7Controller(IWebHostEnvironment webHostEnvironment, IStep7DropdownMapping dropdownOptions, IStep7 step7Service)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step7.xlsx";

            _dropdownOptions = dropdownOptions;
            _step7Service = step7Service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            Step7Model step7Model = new();

            string? idString = HttpContext.Request.Cookies["id"];
            if (int.TryParse(idString, out int id))
            {
                step7Model = _step7Service.GetById(_excelPath, id);
            }

            ViewBag.TypeOfSystemOptions = _dropdownOptions.GetTypeOfSystemOptions();
            ViewBag.SizeOptions = _dropdownOptions.GetSizeOptions();
            ViewBag.TravelDirectionOptions = _dropdownOptions.GetTravelDirectionOptions();
            ViewBag.AttachmentOptions = _dropdownOptions.GetAttachmentOptions();
            ViewBag.LoadBarsOptions = _dropdownOptions.GetLoadBarsOptions();
            ViewBag.MatStorageSaftySystemOptions = _dropdownOptions.GetMatStorageSaftySystemOptions();
            ViewBag.VoltageOptions = _dropdownOptions.GetVoltageOptions();
            ViewBag.PhaseOptions = _dropdownOptions.GetPhaseOptions();

            return View(step7Model);
        }

        [HttpPost]
        public ActionResult Create(Step7Model step7Model)
        {
            _step7Service.Create(_excelPath, step7Model);
            return RedirectToAction("Index", "Review");
        }
    }
}

