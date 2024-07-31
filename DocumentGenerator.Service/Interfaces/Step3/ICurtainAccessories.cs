using System;
using DocumentGenerator.Service.Models.Step3;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step3
{
    public interface ICurtainAccessories
    {
        int Create(string path, CurtainAccessories curtainAccessories);
        int Update(string path, CurtainAccessories curtainAccessories);
        CurtainAccessories? GetByRow(Row row);
    }
}

