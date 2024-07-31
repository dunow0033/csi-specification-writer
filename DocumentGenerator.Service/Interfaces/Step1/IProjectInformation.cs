using DocumentGenerator.Service.Models.Step1;
using FastExcel;

namespace DocumentGenerator.Service.Interfaces.Step1
{
    public interface IProjectInformation
    {
        int CreateOrUpdate(int? idValue, string path, ProjectInformation projectInformation);
        ProjectInformation? GetByRow(Row row);
    }
}
