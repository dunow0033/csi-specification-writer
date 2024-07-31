using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step3;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step3
{
    public class CurtainAccessories : ICurtainAccessories
    {
        private readonly string CURTAIN_ACCESSORIES = "CurtainAccessories";

        private readonly IExcel _excel;

        public CurtainAccessories(IExcel excel)
        {
            _excel = excel;
        }

        public int Create(string path, Models.Step3.CurtainAccessories curtainAccessories)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(CURTAIN_ACCESSORIES);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId.ToString());
                newCells.Add(id);

                //Cell date =
                //    new(2, projectInformation.Date.ToShortDateString());
                //newCells.Add(date);

                //Cell number =
                //    new(3, projectInformation.Number != null ? projectInformation.Number.ToString() : string.Empty);
                //newCells.Add(number);

                //Cell name =
                //    new(4, projectInformation.Name != null ? projectInformation.Name.ToString() : string.Empty);
                //newCells.Add(name);

                //Cell address =
                //    new(5, projectInformation.Address != null ? projectInformation.Address.ToString() : string.Empty);
                //newCells.Add(address);

                //Cell country =
                //    new(6, projectInformation.Country != null ? projectInformation.Country.ToString() : string.Empty);
                //newCells.Add(country);

                //Cell stateProvidence =
                //    new(7, projectInformation.StateProvidence != null ? projectInformation.StateProvidence.ToString() : string.Empty);
                //newCells.Add(stateProvidence);

                //Cell zipPostalCode =
                //    new(8, projectInformation.ZipPostalCode != null ? projectInformation.ZipPostalCode.ToString() : string.Empty);
                //newCells.Add(zipPostalCode);

                //Cell parentId =
                //    new(9, projectInformation.ParentId.ToString());
                //newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, CURTAIN_ACCESSORIES);
            }

            return maxId;
        }

        public Models.Step3.CurtainAccessories? GetByRow(Row row)
        {
            Models.Step3.CurtainAccessories curtainAccessories = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            curtainAccessories.Id = (int)id;

            Cell vinylHeightCell = row.GetCellByColumnName("B");
            curtainAccessories.VinylHeight = _excel.GetString(vinylHeightCell);

            Cell vinylWeightCell = row.GetCellByColumnName("C");
            curtainAccessories.VinylWeight = _excel.GetString(vinylWeightCell);

            Cell operationCell = row.GetCellByColumnName("D");
            curtainAccessories.Operation = _excel.GetString(operationCell);

            Cell curtainLockCell = row.GetCellByColumnName("E");
            curtainAccessories.Operation = _excel.GetString(curtainLockCell);

            return curtainAccessories;
        }

        public int Update(string path, Models.Step3.CurtainAccessories curtainAccessories)
        {
            throw new NotImplementedException();
        }
    }
}

