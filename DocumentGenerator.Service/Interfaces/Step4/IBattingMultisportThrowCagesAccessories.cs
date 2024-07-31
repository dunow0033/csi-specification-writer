using System;
using DocumentGenerator.Service.Models.Step4;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step4
{
    public interface IBattingMultisportThrowCagesAccessories
    {
        int Create(string path, BattingMultiSportThrowCagesAccessories battingMultiSportThrowCagesAccessories);
        int Update(string path, BattingMultiSportThrowCagesAccessories battingMultiSportThrowCagesAccessories);
        BattingMultiSportThrowCagesAccessories? GetByRow(Row row);
    }
}

