using DocumentGenerator.Service.Models.Step1;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step1
{
    public interface IStep1
    {
        Step1Model GetById(string path, int id);
        int Process(int? idValue, string path, Step1Model step1Model);
    }
}
