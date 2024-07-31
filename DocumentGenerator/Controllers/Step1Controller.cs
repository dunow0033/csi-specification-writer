using DocumentGenerator.Service.Interfaces.Step1;
using DocumentGenerator.Service.Models.Step1;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class Step1Controller : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;

        private readonly IStep1 _step1Service;

        public Step1Controller(IWebHostEnvironment webHostEnvironment, IStep1 step1Service)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step1.xlsx";

            _step1Service = step1Service;
        }

        [HttpGet]
        public ActionResult Index()
        {
            Step1Model step1Model = new();

            string? idString = HttpContext.Request.Cookies["id"];
            if (int.TryParse(idString, out int id))
            {
                step1Model = _step1Service.GetById(_excelPath, id);
            }

            return View(step1Model);
        }

        [HttpPost]
        public ActionResult Next(Step1Model step1Model)
        {
            //string? idString = HttpContext.Request.Cookies["id"];
            //if (int.TryParse(idString, out int id))
            //{
            //    step1Model.Id = id;
            //}

            // int newId = _step1Service.Process(0, _excelPath, step1Model);

            // var cookieOpt = new CookieOptions()
            // {
            //     Path = "/",
            //     Expires = DateTimeOffset.UtcNow.AddDays(30),
            //     IsEssential = true,
            //     HttpOnly = false,
            //     Secure = false,
            // };
            // HttpContext.Response.Cookies.Append("id", newId.ToString(), cookieOpt);

            return RedirectToAction("Index", "Step2");
        }


    }
}

