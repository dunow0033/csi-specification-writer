using DocumentGenerator.Service.Models.Step3;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step3
{
    public interface IDividerCurtain
    {
        int Create(string path, DividerCurtain dividerCurtain);
        int Update(string path, DividerCurtain dividerCurtain);
        DividerCurtain? GetByRow(Row row);
    }
}

