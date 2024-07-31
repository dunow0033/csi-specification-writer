using System;
using DocumentGenerator.Service.Models.Step3;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step3
{
    public interface ICurtainModel
    {
        CurtainModel? GetByRow(Row row, FastExcel.FastExcel fastExcel);
        int Create(string path, CurtainModel curtainModel);
        int Update(string path, CurtainModel curtainModel);
    }
}

