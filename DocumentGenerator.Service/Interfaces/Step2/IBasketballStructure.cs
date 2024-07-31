using DocumentGenerator.Service.Models.Step2;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step2
{
    public interface IBasketballStructure
    {
        int Create(string path, BasketballStructure basketballStructure);
        int Update(string path, BasketballStructure basketballStructure);
        BasketballStructure? GetByRow(Row row);
    }
}
