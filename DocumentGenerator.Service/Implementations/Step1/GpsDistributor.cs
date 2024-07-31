using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step1;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step1
{
    public class GpsDistributor : IGpsDistributor
    {
        private readonly string GPS_DISTRIBUTOR = "GpsDistributor";

        private readonly IExcel _excel;

        public GpsDistributor(IExcel excel)
        {
            _excel = excel;
        }

        public int CreateOrUpdate(int? idValue, string path, Models.Step1.GpsDistributor gpsDistributor)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(GPS_DISTRIBUTOR);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId);
                newCells.Add(id);

                Cell name =
                    new(2, gpsDistributor.Name ?? string.Empty);
                newCells.Add(name);

                Cell address =
                    new(3, gpsDistributor.Address ?? string.Empty);
                newCells.Add(address);

                Cell city =
                    new(4, gpsDistributor.Country ?? string.Empty);
                newCells.Add(city);

                Cell country =
                    new(5, gpsDistributor.Country ?? string.Empty);
                newCells.Add(country);

                Cell stateProvidence =
                    new(6, gpsDistributor.State ?? string.Empty);
                newCells.Add(stateProvidence);

                Cell zipPostalCode =
                    new(7, gpsDistributor.ZipCode ?? string.Empty);
                newCells.Add(zipPostalCode);

                Cell parentId =
                    new(8, gpsDistributor.ParentId);
                newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, GPS_DISTRIBUTOR);
            }

            return maxId;
        }

        public Models.Step1.GpsDistributor? GetByRow(Row row)
        {
            Models.Step1.GpsDistributor gpsDistributor = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            gpsDistributor.Id = (int)id;

            Cell nameCell = row.GetCellByColumnName("B");
            gpsDistributor.Name = _excel.GetString(nameCell);

            Cell addressCell = row.GetCellByColumnName("C");
            gpsDistributor.Address = _excel.GetString(addressCell);

            Cell cityCell = row.GetCellByColumnName("D");
            gpsDistributor.City = _excel.GetString(cityCell);

            Cell countryCell = row.GetCellByColumnName("E");
            gpsDistributor.Country = _excel.GetString(countryCell);

            Cell stateProvidenceCell = row.GetCellByColumnName("F");
            gpsDistributor.State = _excel.GetString(stateProvidenceCell);

            Cell zipPostalCodeCell = row.GetCellByColumnName("G");
            gpsDistributor.ZipCode = _excel.GetString(zipPostalCodeCell);

            return gpsDistributor;
        }

    }
}
