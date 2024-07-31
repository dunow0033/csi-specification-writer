using DocumentGenerator.Service.Models.Step6;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step6
{
    public interface IVolleyballEquipment
    {
        int Create(string path, VolleyballEquipment volleyballEquipment);
        int Update(string path, VolleyballEquipment volleyballEquipment);
        VolleyballEquipment? GetByRow(Row row);
    }
}
