using DocumentGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class FormController : Controller
    {
        public ActionResult Index()
        {
            FormModel formModel = new();

            return View(formModel);
        }

        public ActionResult Step1(FormModel formModel)
        {
            Step1Model step1Model = new();
            formModel.Step1Model = step1Model;

            return View(formModel);
        }

        public ActionResult Step2(FormModel formModel)
        {
            Step2Model step2Model = new();
            formModel.Step2Model = step2Model;

            return View(formModel);
        }

        public ActionResult Step3(FormModel formModel)
        {
            Step3Model step3Model = new();
            formModel.Step3Model = step3Model;

            return View(formModel);
        }

        public ActionResult Step4(FormModel formModel)
        {
            Step4Model step4Model = new();
            formModel.Step4Model = step4Model;

            return View(formModel);
        }

        public ActionResult Review(FormModel formModel)
        {
            return View(formModel);
        }

        public ActionResult Complete(FormModel formModel)
        {
            return View();
        }
    }
}