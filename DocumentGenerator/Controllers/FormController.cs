using DocumentGenerator.Service.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class IdObject
    {
        public int Id { get; set; }
    }
    public class FormController : Controller
    {
        public ActionResult Index()
        {
            var cookieOptions = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(30)
            };
            Response.Cookies.Append("id", "1", cookieOptions);

            return View();
        }

        [HttpPost]
        public ActionResult Start([FromBody] IdObject idObject)
        {
            //string? idString = HttpContext.Request.Cookies["id"];
            //if (int.TryParse(idString, out int id))
            //{

            //}

            return RedirectToAction("Index", "Step1");
        }
    }
}