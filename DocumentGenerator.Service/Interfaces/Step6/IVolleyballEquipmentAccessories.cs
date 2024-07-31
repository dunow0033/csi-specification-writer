using DocumentGenerator.Service.Models.Step6;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step6
{
    public interface IVolleyballEquipmentAccessories
    {
        int Create(string path, VolleyballEquipmentAccessories volleyballEquipmentAccessories);
        int Update(string path, VolleyballEquipmentAccessories volleyballEquipmentAccessories);
        VolleyballEquipmentAccessories? GetByRow(Row row);
    }
}
