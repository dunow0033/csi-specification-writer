using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step7;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step7
{
    public class MatStorageSystems : IMatStorageSystems
    {
        private readonly string MAT_STORAGE_SYSTEMS = "MatStorageSystems";

        private readonly IExcel _excel;

        public MatStorageSystems(IExcel excel)
        {
            _excel = excel;
        }

        public int Create(string path, Models.Step7.MatStorageSystems matStorageSystems)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(MAT_STORAGE_SYSTEMS);
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

                fastExcel.Write(workSheet, MAT_STORAGE_SYSTEMS);
            }

            return maxId;
        }

        public Models.Step7.MatStorageSystems? GetByRow(Row row)
        {
            Models.Step7.MatStorageSystems item = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            item.Id = (int)id;

            //Cell basketballStrucureCell = row.GetCellByColumnName("B");
            //item.BasketBallStructure = _excel.GetString(basketballStrucureCell);

            //Cell quantityCell = row.GetCellByColumnName("C");
            //item.Quantity = _excel.GetString(quantityCell);

            //Cell descriptionCell = row.GetCellByColumnName("D");
            //item.Description = _excel.GetString(descriptionCell);

            //Cell extensionLengthCell = row.GetCellByColumnName("E");
            //item.ExtensionLength = _excel.GetString(extensionLengthCell);

            //Cell operationCell = row.GetCellByColumnName("F");
            //item.Operation = _excel.GetString(operationCell);

            //Cell levelOfUseCell = row.GetCellByColumnName("G");
            //item.LevelOfUse = _excel.GetString(levelOfUseCell);

            //Cell typeCell = row.GetCellByColumnName("H");
            //item.Type = _excel.GetString(typeCell);

            //Cell foldingDirectionCell = row.GetCellByColumnName("I");
            //item.FoldingDirection = _excel.GetString(foldingDirectionCell);

            //Cell trussHeightFeetCell = row.GetCellByColumnName("J");
            //item.TrussHeightFeet = _excel.GetString(trussHeightFeetCell);

            //Cell trussHeightInchCell = row.GetCellByColumnName("K");
            //item.TrussHeightInches = _excel.GetString(trussHeightInchCell);

            //Cell bracedTypeCell = row.GetCellByColumnName("L");
            //item.BracedType = _excel.GetString(bracedTypeCell);

            return item;
        }

        public int Update(string path, Models.Step7.MatStorageSystems matStorageSystems)
        {
            throw new NotImplementedException();
        }
    }
}
