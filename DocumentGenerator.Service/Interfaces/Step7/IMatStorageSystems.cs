using DocumentGenerator.Service.Models.Step7;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step7
{
    public interface IMatStorageSystems
    {
        int Create(string path, MatStorageSystems matStorageSystems);
        int Update(string path, MatStorageSystems matStorageSystems);
        MatStorageSystems? GetByRow(Row row);
    }
}
