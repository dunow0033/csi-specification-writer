using System.Reflection;
using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step1;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step1;

public class Section
{
    public Section(string name, string parentId)
    {
        Name = name;
        ParentId = parentId;
    }
    public string Name { get; set; } = string.Empty;
    public string ParentId { get; set; } = string.Empty;
}

public class Get : IGet
{
    private readonly IExcel _excel;
    private readonly IProjectInformation _projectInformation;

    public Get(IExcel excel, IProjectInformation projectInformation)
    {
        _excel = excel;
        _projectInformation = projectInformation;
    }

    public T GetById<T>(string STEP, string path, int id, List<Section> sections) where T : new()
    {
        T step = new();
        List<T> list = new();
        List<string> propertiesOfT = GetPropertiesNameOfClass(step);

        using (FastExcel.FastExcel fastExcel = new(new FileInfo(path), true))
        {
            Worksheet workSheet = fastExcel.Read(STEP);
            int rowCount = workSheet.Rows.Count();
            List<Row> rows = workSheet.Rows.ToList();

            for (int rowNumber = 1; rowNumber < rowCount; rowNumber++)
            {
                Row row = rows[rowNumber];
                T? stepModel = GetStepInfo<T>(row);
                if (stepModel == null) continue;

                int stepModelId = GetPropertyValue<int>(stepModel, "Id");
                if (stepModelId == 0 || stepModelId != id) continue;
                TrySetProperty(step, "Id", stepModelId);

                DateTime stepModelCreatedOn = GetPropertyValue<DateTime>(stepModel, "CreatedOn");
                TrySetProperty(step, "CreatedOn", stepModelCreatedOn);

                DateTime stepModelDeletedOn = GetPropertyValue<DateTime>(stepModel, "DeletedOn");
                TrySetProperty(step, "DeletedOn", stepModelDeletedOn);

                sections.ForEach(section =>
                {
                    Worksheet sectionWorkSheet = fastExcel.Read(section.Name);
                    int sectionRowCount = sectionWorkSheet.Rows.Count();
                    List<Row> sectionRows = sectionWorkSheet.Rows.ToList();

                    for (int sectionRowNumber = 1; sectionRowNumber < sectionRowCount; sectionRowNumber++)
                    {
                        Row sectionRow = sectionRows[sectionRowNumber];
                        Cell parentIdCell = sectionRow.GetCellByColumnName(section.ParentId);
                        if (parentIdCell == null) continue;

                        int? parentId = _excel.GetInt(parentIdCell);
                        if (parentId == null) continue;

                        int sectionParentId = GetPropertyValue<int>(stepModel, "Id");
                        if (parentId != sectionParentId) continue;



                        // start here
                        // we need to use build out the ancelary builders
                        // var data =
                        //     _projectInformation.GetByRow(sectionRow);
                        // if (data == null) continue;

                        // TrySetProperty(step, section.Name, data);
                    }
                });


            }
        }

        return step;
    }

    private T? GetStepInfo<T>(Row row) where T : new()
    {
        T stepModel = new();
        Cell idCell = row.GetCellByColumnName("A");

        if (idCell == null) return default(T);
        int? id = _excel.GetInt(idCell);
        if (id == null) return default(T);

        TrySetProperty(stepModel, "Id", (int)id);

        Cell createdOnCell = row.GetCellByColumnName("B");
        TrySetProperty(stepModel, "CreatedOn", _excel.GetDateTime(createdOnCell));

        Cell deletedOnCell = row.GetCellByColumnName("C");
        TrySetProperty(stepModel, "DeletedOn", _excel.GetDateTime(deletedOnCell));

        return stepModel;
    }

    public static bool TrySetProperty(object obj, string property, object value)
    {
        var prop = obj.GetType().GetProperty(property, BindingFlags.Public | BindingFlags.Instance);
        if (prop != null && prop.CanWrite)
        {
            prop.SetValue(obj, value, null);
            return true;
        }
        return false;
    }

    public static List<string> GetPropertiesNameOfClass(object pObject)
    {
        List<string> propertyList = new List<string>();
        if (pObject != null)
        {
            foreach (var prop in pObject.GetType().GetProperties())
            {
                propertyList.Add(prop.Name);
            }
        }
        return propertyList;
    }

    public static T GetPropertyValue<T>(object obj, string propName)
    {
        return (T)obj.GetType().GetProperty(propName).GetValue(obj, null);
    }

}
