using DocumentGenerator.Service.Models.Step6;

namespace DocumentGenerator.Service.Interfaces.Step6
{
    public interface IStep6
    {
        Step6Model GetById(string path, int id);
        int Create(string path, Step6Model step6Model);
        int Update(string path, Step6Model step6Model);
    }
}
