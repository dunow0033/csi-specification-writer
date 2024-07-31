using DocumentGenerator.Service.Models.Step2;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step2
{
    public interface IBasketballAccessories
    {
        int Create(string path, BasketballAccessories basketballAccessories);
        int Update(string path, BasketballAccessories basketballAccessories);
        BasketballAccessories? GetByRow(Row row);
    }
}
