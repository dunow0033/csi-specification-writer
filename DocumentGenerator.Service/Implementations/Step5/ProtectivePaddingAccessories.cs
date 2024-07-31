using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step5;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step5
{
    public class ProtectivePaddingAccessories : IProtectivePaddingAccessories
    {
        private readonly string PROTECTIVE_PADDING_ACCESSORIES = "ProtectivePaddingAccessories";

        private readonly IExcel _excel;

        public ProtectivePaddingAccessories(IExcel excel)
        {
            _excel = excel;
        }

        public int Create(string path, Models.Step5.ProtectivePaddingAccessories protectivePaddingAccessories)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(PROTECTIVE_PADDING_ACCESSORIES);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId);
                newCells.Add(id);

                Cell graphics =
                    new(2, protectivePaddingAccessories.Graphics ?? string.Empty);
                newCells.Add(graphics);

                Cell cutOutRequired =
                    new(3, protectivePaddingAccessories.CutOutRequired ?? string.Empty);
                newCells.Add(cutOutRequired);

                Cell parentId =
                    new(4, protectivePaddingAccessories.ParentId);
                newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, PROTECTIVE_PADDING_ACCESSORIES);
            }

            return maxId;
        }

        public Models.Step5.ProtectivePaddingAccessories? GetByRow(Row row)
        {
            Models.Step5.ProtectivePaddingAccessories item = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            item.Id = (int)id;

            Cell graphicsCell = row.GetCellByColumnName("B");
            item.Graphics = _excel.GetString(graphicsCell);

            Cell cutOutRequiredCell = row.GetCellByColumnName("C");
            item.CutOutRequired = _excel.GetString(cutOutRequiredCell);

            return item;
        }

        public int Update(string path, Models.Step5.ProtectivePaddingAccessories protectivePaddingAccessories)
        {
            throw new NotImplementedException();
        }
    }
}
