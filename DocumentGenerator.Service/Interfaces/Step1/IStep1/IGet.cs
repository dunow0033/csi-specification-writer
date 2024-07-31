using DocumentGenerator.Service.Implementations.Step1;

namespace DocumentGenerator.Service.Interfaces.Step1;

public interface IGet
{
    public T GetById<T>(string STEP, string path, int id, List<Section> sections) where T : new();
}
