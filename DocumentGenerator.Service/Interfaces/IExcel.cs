using FastExcel;

namespace DocumentGenerator.Service.Interfaces
{
    public interface IExcel
    {
        bool GetBool(Cell value);
        string? GetString(Cell value);
        int? GetInt(Cell value);
        DateTime GetDateTime(Cell value);
    }
}
