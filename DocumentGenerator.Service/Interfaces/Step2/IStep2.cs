using DocumentGenerator.Service.Models.Step2;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step2
{
    public interface IStep2
    {
        Step2Model GetById(string path, int id);
        int Create(string path, Step2Model step2Model);
        int Update(string path, Step2Model step2Model);
    }
}
