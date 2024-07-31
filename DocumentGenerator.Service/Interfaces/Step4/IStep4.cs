using System;
using DocumentGenerator.Service.Models.Step3;
using DocumentGenerator.Service.Models.Step4;

namespace DocumentGenerator.Service.Interfaces.Step4
{
    public interface IStep4
    {
        Step3Model GetById(string path, int id);
        int Create(string path, Step4Model step4Model);
        int Update(string path, Step4Model step4Model);
    }
}

