using DocumentGenerator.Service.Interfaces.Step1;
using DocumentGenerator.Service.Models;
using DocumentGenerator.Service.Models.Step1;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;

        private readonly IStep1 _step1Service;

        public ReviewController(IWebHostEnvironment webHostEnvironment, IStep1 step1Service)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step1.xlsx";

            _step1Service = step1Service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            FormModel formModel = new();

            string? idString = HttpContext.Request.Cookies["id"];
            if (int.TryParse(idString, out int id))
            {
                Step1Model step1Model = _step1Service.GetById(_excelPath, id);
                formModel.Step1Model = step1Model;
            }

            return View(formModel);
        }

        [HttpPost]
        public ActionResult Create()
        {
            //Process(step1Model);
            return RedirectToAction("Index", "Complete");
        }
    }
}

