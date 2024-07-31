using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step2;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step2
{
    public class BasketballAccessories : IBasketballAccessories
    {
        private readonly string BASKETBALL_ACCESSORIES = "BasketballAccessories";

        private readonly IExcel _excel;

        public BasketballAccessories(IExcel excel)
        {
            _excel = excel;
        }

        public int Create(string path, Models.Step2.BasketballAccessories basketballAccessories)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(BASKETBALL_ACCESSORIES);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId);
                newCells.Add(id);

                Cell backboard =
                    new(2, basketballAccessories.Backboard ?? string.Empty);
                newCells.Add(backboard);

                Cell operation1 =
                    new(3, basketballAccessories.Operation1 ?? string.Empty);
                newCells.Add(operation1);

                Cell operation2 =
                    new(4, basketballAccessories.Operation2 ?? string.Empty);
                newCells.Add(operation2);

                Cell rim =
                    new(5, basketballAccessories.Rim ?? string.Empty);
                newCells.Add(rim);

                Cell heightAdjuster =
                    new(6, basketballAccessories.HeightAdjuster ?? string.Empty);
                newCells.Add(heightAdjuster);

                Cell edgePadding =
                    new(7, basketballAccessories.EdgePadding ?? string.Empty);
                newCells.Add(edgePadding);

                Cell safeStop =
                    new(8, basketballAccessories.SafeStop ?? string.Empty);
                newCells.Add(safeStop);

                Cell parentId =
                    new(9, basketballAccessories.ParentId);
                newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, BASKETBALL_ACCESSORIES);
            }

            return maxId;
        }

        public Models.Step2.BasketballAccessories? GetByRow(Row row)
        {
            Models.Step2.BasketballAccessories basketballAccessories = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            basketballAccessories.Id = (int)id;

            Cell backboardCell = row.GetCellByColumnName("B");
            basketballAccessories.Backboard = _excel.GetString(backboardCell);

            Cell operation1Cell = row.GetCellByColumnName("C");
            basketballAccessories.Operation1 = _excel.GetString(operation1Cell);

            Cell operation2Cell = row.GetCellByColumnName("D");
            basketballAccessories.Operation2 = _excel.GetString(operation2Cell);

            Cell rimCell = row.GetCellByColumnName("E");
            basketballAccessories.Rim = _excel.GetString(rimCell);

            Cell heightAdjusterCell = row.GetCellByColumnName("F");
            basketballAccessories.HeightAdjuster = _excel.GetString(heightAdjusterCell);

            Cell edgePaddingCell = row.GetCellByColumnName("G");
            basketballAccessories.EdgePadding = _excel.GetString(edgePaddingCell);

            Cell safeStopCell = row.GetCellByColumnName("H");
            basketballAccessories.SafeStop = _excel.GetString(safeStopCell);

            return basketballAccessories;
        }

        public int Update(string path, Models.Step2.BasketballAccessories basketballAccessories)
        {
            throw new NotImplementedException();
        }
    }
}

