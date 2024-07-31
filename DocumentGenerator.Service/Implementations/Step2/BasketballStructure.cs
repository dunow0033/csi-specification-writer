using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step2;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step2
{
    public class BasketballStructure : IBasketballStructure
    {
        private readonly string BASKETBALL_STRUCTURE = "BasketballStructure";

        private readonly IExcel _excel;

        public BasketballStructure(IExcel excel)
        {
            _excel = excel;
        }

        public int Create(string path, Models.Step2.BasketballStructure basketballStructure)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(BASKETBALL_STRUCTURE);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId);
                newCells.Add(id);

                Cell basketballStructureCell =
                    new(2, basketballStructure.BasketBallStructure ?? string.Empty);
                newCells.Add(basketballStructureCell);

                Cell quantity =
                    new(3, basketballStructure.Quantity ?? string.Empty);
                newCells.Add(quantity);

                Cell description =
                    new(4, basketballStructure.Description ?? string.Empty);
                newCells.Add(description);

                Cell extensionLength =
                    new(5, basketballStructure.ExtensionLength ?? string.Empty);
                newCells.Add(extensionLength);

                Cell operation =
                    new(6, basketballStructure.Operation ?? string.Empty);
                newCells.Add(operation);

                Cell levelOfUse =
                    new(7, basketballStructure.LevelOfUse ?? string.Empty);
                newCells.Add(levelOfUse);

                Cell type =
                    new(8, basketballStructure.Type ?? string.Empty);
                newCells.Add(type);

                Cell foldingDirection =
                    new(9, basketballStructure.FoldingDirection ?? string.Empty);
                newCells.Add(foldingDirection);

                Cell trussHeightFt =
                    new(10, basketballStructure.TrussHeightFeet ?? string.Empty);
                newCells.Add(trussHeightFt);

                Cell trussHeightIn =
                    new(11, basketballStructure.TrussHeightInches ?? string.Empty);
                newCells.Add(trussHeightIn);

                Cell bracedType =
                    new(12, basketballStructure.BracedType ?? string.Empty);
                newCells.Add(bracedType);

                Cell parentId =
                    new(13, basketballStructure.ParentId);
                newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, BASKETBALL_STRUCTURE);
            }

            return maxId;
        }

        public Models.Step2.BasketballStructure? GetByRow(Row row)
        {
            Models.Step2.BasketballStructure item = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            item.Id = (int)id;

            Cell basketballStrucureCell = row.GetCellByColumnName("B");
            item.BasketBallStructure = _excel.GetString(basketballStrucureCell);

            Cell quantityCell = row.GetCellByColumnName("C");
            item.Quantity = _excel.GetString(quantityCell);

            Cell descriptionCell = row.GetCellByColumnName("D");
            item.Description = _excel.GetString(descriptionCell);

            Cell extensionLengthCell = row.GetCellByColumnName("E");
            item.ExtensionLength = _excel.GetString(extensionLengthCell);

            Cell operationCell = row.GetCellByColumnName("F");
            item.Operation = _excel.GetString(operationCell);

            Cell levelOfUseCell = row.GetCellByColumnName("G");
            item.LevelOfUse = _excel.GetString(levelOfUseCell);

            Cell typeCell = row.GetCellByColumnName("H");
            item.Type = _excel.GetString(typeCell);

            Cell foldingDirectionCell = row.GetCellByColumnName("I");
            item.FoldingDirection = _excel.GetString(foldingDirectionCell);

            Cell trussHeightFeetCell = row.GetCellByColumnName("J");
            item.TrussHeightFeet = _excel.GetString(trussHeightFeetCell);

            Cell trussHeightInchCell = row.GetCellByColumnName("K");
            item.TrussHeightInches = _excel.GetString(trussHeightInchCell);

            Cell bracedTypeCell = row.GetCellByColumnName("L");
            item.BracedType = _excel.GetString(bracedTypeCell);

            return item;
        }

        public int Update(string path, Models.Step2.BasketballStructure basketballStructure)
        {
            throw new NotImplementedException();
        }
    }
}
