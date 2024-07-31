using DocumentGenerator.Helpers.DropdownOptions.Interfaces;
using DocumentGenerator.Service.Interfaces.Step3;
using DocumentGenerator.Service.Interfaces.Step4;
using DocumentGenerator.Service.Interfaces.Step7;
using DocumentGenerator.Service.Models.Step4;
using Microsoft.AspNetCore.Mvc;

namespace DocumentGenerator.Controllers
{
    public class Step4Controller : Controller
    {
        private readonly IWebHostEnvironment _webhostEnvironment;
        private readonly string _excelPath;
        private readonly IStep4 _step4Service;

        private readonly IStep4DropdownMapping _dropdownOptions;

        public Step4Controller(IWebHostEnvironment webHostEnvironment, IStep4DropdownMapping dropdownOptions, IStep4 step4Service)
        {
            _webhostEnvironment = webHostEnvironment;
            _excelPath = $"{_webhostEnvironment.ContentRootPath}.Data/Excel/FormData/Step5.xlsx";

            _dropdownOptions = dropdownOptions;
            _step4Service = step4Service;
        }

        [HttpGet]
        public ActionResult Index(Step4Model step4Model)
        {
            //Step4Model step4Model = new()
            //{
            //    BattingMultiSportThrowCagesList = new List<BattingMultiSportThrowCagesModel>
            //{
            //    new BattingMultiSportThrowCagesModel
            //    {
            //        BattingMultiSportThrowCages = new BattingMultiSportThrowCages(),
            //        BattingMultiSportThrowCagesAccessories = new BattingMultiSportThrowCagesAccessories()
            //    }
            //}
            //};

            ViewBag.StructureOptions = _dropdownOptions.GetStructureOptions();
            ViewBag.AttachmentOptions = _dropdownOptions.GetAttachmentOptions();
            ViewBag.LiftStyleOptions = _dropdownOptions.GetLiftStyleOptions();
            ViewBag.OperationOptions = _dropdownOptions.GetOperationOptions();
            ViewBag.CurtainLockOptions = _dropdownOptions.GetCurtainLockOptions();

            return View(step4Model);
        }

        [HttpPost]
        public ActionResult Create(BattingMultiSportThrowCagesModel battingMultiSportThrowCagesModel)
        {
            //Process(step2Model);
            return View(battingMultiSportThrowCagesModel);
        }

        [HttpPut]
        public ActionResult Edit(Step4Model step4Model)
        {
            //Process(step2Model);
            return RedirectToAction("Index", "Step4");
        }

        [HttpDelete]
        public ActionResult Delete(Step4Model step4Model)
        {
            //Process(step2Model);
            return RedirectToAction("Index", "Step4");
        }

        [HttpPost]
        public ActionResult Navigate(Step4Model step4Model)
        {
            //Process(step2Model);
            return RedirectToAction("Index", "Step5");
        }
    }
}

