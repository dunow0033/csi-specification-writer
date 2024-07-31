
using DocumentGenerator.Service.Models.Step4;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step4
{
    public interface IBattingMultisportThrowCagesModel
    {
        BattingMultiSportThrowCagesModel? GetByRow(Row row, FastExcel.FastExcel fastExcel);
        int Create(string path, BattingMultiSportThrowCagesModel battingMultiSportThrowCagesModel);
        int Update(string path, BattingMultiSportThrowCagesModel battingMultiSportThrowCagesModel);
    }
}

