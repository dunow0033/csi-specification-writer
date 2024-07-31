using System.Runtime.Intrinsics.X86;
using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step1;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step1
{
    public class ProjectInformation : IProjectInformation
    {
        private readonly string PROJECT_INFORMATION = "ProjectInformation";

        private readonly IExcel _excel;

        public ProjectInformation(IExcel excel)
        {
            _excel = excel;
        }

        public int CreateOrUpdate(int? idValue, string path, Models.Step1.ProjectInformation projectInformation)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(PROJECT_INFORMATION);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId);
                newCells.Add(id);

                Cell date =
                    new(2, projectInformation.Date.ToShortDateString());
                newCells.Add(date);

                Cell number =
                    new(3, projectInformation.Number ?? string.Empty);
                newCells.Add(number);

                Cell name =
                    new(4, projectInformation.Name ?? string.Empty);
                newCells.Add(name);

                Cell address =
                    new(5, projectInformation.Address ?? string.Empty);
                newCells.Add(address);

                Cell country =
                    new(6, projectInformation.Country ?? string.Empty);
                newCells.Add(country);

                Cell stateProvidence =
                    new(7, projectInformation.StateProvidence ?? string.Empty);
                newCells.Add(stateProvidence);

                Cell zipPostalCode =
                    new(8, projectInformation.ZipPostalCode ?? string.Empty);
                newCells.Add(zipPostalCode);

                Cell parentId =
                    new(9, projectInformation.ParentId);
                newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, PROJECT_INFORMATION);
            }

            return maxId;
        }

        public Models.Step1.ProjectInformation? GetByRow(Row row)
        {
            Models.Step1.ProjectInformation projectInformation = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            projectInformation.Id = (int)id;

            Cell dateCell = row.GetCellByColumnName("B");
            projectInformation.Date = _excel.GetDateTime(dateCell);

            Cell numberCell = row.GetCellByColumnName("C");
            projectInformation.Number = _excel.GetString(numberCell);

            Cell nameCell = row.GetCellByColumnName("D");
            projectInformation.Name = _excel.GetString(nameCell);

            Cell addressCell = row.GetCellByColumnName("E");
            projectInformation.Address = _excel.GetString(addressCell);

            Cell countryCell = row.GetCellByColumnName("F");
            projectInformation.Country = _excel.GetString(countryCell);

            Cell stateProvidenceCell = row.GetCellByColumnName("G");
            projectInformation.StateProvidence = _excel.GetString(stateProvidenceCell);

            Cell zipPostalCodeCell = row.GetCellByColumnName("H");
            projectInformation.ZipPostalCode = _excel.GetString(zipPostalCodeCell);

            return projectInformation;
        }
    }
}
