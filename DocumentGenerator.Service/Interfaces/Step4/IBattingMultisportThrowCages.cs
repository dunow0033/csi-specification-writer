using DocumentGenerator.Service.Models.Step4;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step4
{
    public interface IBattingMultisportThrowCages
    {
        int Create(string path, BattingMultiSportThrowCages battingMultiSportThrowCages);
        int Update(string path, BattingMultiSportThrowCages battingMultiSportThrowCages);
        BattingMultiSportThrowCages? GetByRow(Row row);
    }
}
