using DocumentGenerator.Service.Interfaces.Step1;
using DocumentGenerator.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class CompleteController : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;

        public CompleteController(IWebHostEnvironment webHostEnvironment)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step1.xlsx";
        }

        [HttpGet]
        public ActionResult Index()
        {
            FormModel formModel = new();

            string? idString = HttpContext.Request.Cookies["id"];
            if (int.TryParse(idString, out int id))
            {
                //step1Model = _step1Service.GetById(_excelPath, id);
            }

            return View();
        }

        [HttpPost]
        public ActionResult Create()
        {
            //Process(step1Model);
            return RedirectToAction("Index", "Complete");
        }
    }
}

