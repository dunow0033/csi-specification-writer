using DocumentGenerator.Service.Models.Step3;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step3
{
    public interface IStep3
    {
        Step3Model GetById(string path, int id);
        int Create(string path, Step3Model step3Model);
        int Update(string path, Step3Model step3Model);

        //Step3Model? GetStep3Info(Row row);
        //CurtainModel? GetCurtainModel(Row row, FastExcel.FastExcel fastExcel);
        //DividerCurtain? GetDividerCurtain(Row row);
        //CurtainAccessories? GetCurtainAccessories(Row row);
    }
}
