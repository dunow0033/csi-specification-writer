using DocumentGenerator.Service.Models.Step7;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step7
{
    public interface IMatStorageAccessories
    {
        int Create(string path, MatStorageAccessories matStorageAccessories);
        int Update(string path, MatStorageAccessories matStorageAccessories);
        MatStorageAccessories? GetByRow(Row row);
    }
}
