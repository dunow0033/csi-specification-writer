using DocumentGenerator.Service.Models.Step7;

namespace DocumentGenerator.Service.Interfaces.Step7
{
    public interface IStep7
    {
        Step7Model GetById(string path, int id);
        int Create(string path, Step7Model step7Model);
        int Update(string path, Step7Model step7Model);
    }
}
