using DocumentGenerator.Service.Models.Step1;
using DocumentGenerator.Service.Models.Step2;
using DocumentGenerator.Service.Models.Step3;
using DocumentGenerator.Service.Models.Step4;
using DocumentGenerator.Service.Models.Step5;
using DocumentGenerator.Service.Models.Step6;
using DocumentGenerator.Service.Models.Step7;

namespace DocumentGenerator.Service.Models
{
    public class FormModel
    {
        public Step1Model? Step1Model { get; set; }

        public Step2Model? Step2Model { get; set; }

        public Step3Model? Step3Model { get; set; }

        public Step4Model? Step4Model { get; set; }

        public Step5Model? Step5Model { get; set; }

        public Step6Model? Step6Model { get; set; }

        public Step7Model? Step7Model { get; set; }
    }
}
