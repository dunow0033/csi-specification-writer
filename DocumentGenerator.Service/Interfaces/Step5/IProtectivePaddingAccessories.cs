using DocumentGenerator.Service.Models.Step5;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step5
{
    public interface IProtectivePaddingAccessories
    {
        int Create(string path, ProtectivePaddingAccessories protectivePaddingAccessories);
        int Update(string path, ProtectivePaddingAccessories protectivePaddingAccessories);
        ProtectivePaddingAccessories? GetByRow(Row row);
    }
}
