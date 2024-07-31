using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step1;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step1
{
    public class ArchitectInformation : IArchitectInformation
    {
        private readonly string ARCHITECT_INFORMATION = "ArchitectInformation";

        private readonly IExcel _excel;

        public ArchitectInformation(IExcel excel)
        {
            _excel = excel;
        }

        public int CreateOrUpdate(int? idValue, string path, Models.Step1.ArchitectInformation architectInformation)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(ARCHITECT_INFORMATION);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId);
                newCells.Add(id);

                Cell name =
                    new(2, architectInformation.Name ?? string.Empty);
                newCells.Add(name);

                Cell country =
                    new(3, architectInformation.Country ?? string.Empty);
                newCells.Add(country);

                Cell stateProvidence =
                    new(4, architectInformation.StateProvidence ?? string.Empty);
                newCells.Add(stateProvidence);

                Cell zipPostalCode =
                    new(5, architectInformation.ZipPostalCode ?? string.Empty);
                newCells.Add(zipPostalCode);

                Cell parentId =
                    new(6, architectInformation.ParentId);
                newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, ARCHITECT_INFORMATION);
            }

            return maxId;
        }

        public Models.Step1.ArchitectInformation? GetByRow(Row row)
        {
            Models.Step1.ArchitectInformation architectInformation = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            architectInformation.Id = (int)id;

            Cell nameCell = row.GetCellByColumnName("B");
            architectInformation.Name = _excel.GetString(nameCell);

            Cell countryCell = row.GetCellByColumnName("C");
            architectInformation.Country = _excel.GetString(countryCell);

            Cell stateProvidenceCell = row.GetCellByColumnName("D");
            architectInformation.StateProvidence = _excel.GetString(stateProvidenceCell);

            Cell zipPostalCodeCell = row.GetCellByColumnName("E");
            architectInformation.ZipPostalCode = _excel.GetString(zipPostalCodeCell);

            return architectInformation;
        }

    }
}
