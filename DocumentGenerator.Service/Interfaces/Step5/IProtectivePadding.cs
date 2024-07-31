using DocumentGenerator.Service.Models.Step5;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step5
{
    public interface IProtectivePadding
    {
        int Create(string path, ProtectivePadding protectivePadding);
        int Update(string path, ProtectivePadding protectivePadding);
        ProtectivePadding? GetByRow(Row row);
    }
}
