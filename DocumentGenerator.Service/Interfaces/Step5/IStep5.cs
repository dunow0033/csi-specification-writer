using DocumentGenerator.Service.Models.Step5;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step5
{
    public interface IStep5
    {
        Step5Model GetById(string path, int id);
        int Create(string path, Step5Model step5Model);
        int Update(string path, Step5Model step5Model);
    }
}
