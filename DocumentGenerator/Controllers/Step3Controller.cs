using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step2;
using DocumentGenerator.Service.Interfaces.Step3;
using DocumentGenerator.Service.Interfaces.Step7;
using DocumentGenerator.Service.Models.Step3;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class Step3Controller : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;
        private readonly IStep3 _step3Service;

        private readonly IStep3DropdownMapping _dropdownOptions;

        public Step3Controller(IWebHostEnvironment webHostEnvironment, IStep3DropdownMapping dropdownOptions, IStep3 step3Service)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step6.xlsx";

            _dropdownOptions = dropdownOptions;
            _step3Service = step3Service;
        }

        [HttpGet]
        public ActionResult Index(Step3Model step3Model)
        {
            //Step3Model step3Model2 = new()
            //{
            //    CurtainList = new List<CurtainModel>
            //{
            //    new CurtainModel
            //    {
            //        DividerCurtain = new DividerCurtain(),
            //        CurtainAccessories = new CurtainAccessories()
            //    }
            //}
            //};

            ViewBag.StructureOptions = _dropdownOptions.GetStructureOptions();
            ViewBag.AttachmentOptions = _dropdownOptions.GetAttachmentOptions();
            ViewBag.VinylWeightOptions = _dropdownOptions.GetVinylWeightOptions();
            ViewBag.OperationOptions = _dropdownOptions.GetOperationOptions();
            ViewBag.CurtainLockOptions = _dropdownOptions.GetCurtainLockOptions();

            return View(step3Model);
        }

        [HttpPost]
        public ActionResult Create(CurtainModel curtainModel)
        {
            // start here

            // we need to get the step3 model
            // then add this one to the list
            // then return it to the screen



            //Process(step2Model);
            //_step3Service.Create(_excelPath, curtainModel);
            return View(curtainModel);
        }

        [HttpPut]
        public ActionResult Edit(Step3Model step3Model)
        {
            //Process(step2Model);
            return RedirectToAction("Index", "Step4");
        }

        [HttpDelete]
        public ActionResult Delete(Step3Model step3Model)
        {
            //Process(step2Model);
            return RedirectToAction("Index", "Step4");
        }

        [HttpPost]
        public ActionResult Navigate(Step3Model step3Model)
        {
            //Process(step2Model);
            return RedirectToAction("Index", "Step4");
        }
    }
}

