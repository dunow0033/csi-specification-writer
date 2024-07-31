using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step5;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step5
{
    public class ProtectivePadding : IProtectivePadding
    {
        private readonly string PROTECTIVE_PADDING = "ProtectivePadding";

        private readonly IExcel _excel;

        public ProtectivePadding(IExcel excel)
        {
            _excel = excel;
        }

        public int Create(string path, Models.Step5.ProtectivePadding protectivePadding)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(PROTECTIVE_PADDING);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId);
                newCells.Add(id);

                Cell fireRating =
                    new(2, protectivePadding.FireRating ?? string.Empty);
                newCells.Add(fireRating);

                Cell impactRating =
                    new(3, protectivePadding.ImpactRating ?? string.Empty);
                newCells.Add(impactRating);

                Cell construction =
                    new(4, protectivePadding.Construction ?? string.Empty);
                newCells.Add(construction);

                Cell quantity =
                    new(5, protectivePadding.Quantity ?? string.Empty);
                newCells.Add(quantity);

                Cell heightFt =
                    new(6, protectivePadding.HeightFt ?? string.Empty);
                newCells.Add(heightFt);

                Cell heightIn =
                    new(7, protectivePadding.HeightIn ?? string.Empty);
                newCells.Add(heightIn);

                Cell widthFt =
                    new(8, protectivePadding.WidthFt ?? string.Empty);
                newCells.Add(widthFt);

                Cell widthIn =
                    new(9, protectivePadding.WidthIn ?? string.Empty);
                newCells.Add(widthIn);

                Cell sameTypeAndAttachment =
                    new(10, protectivePadding.SameTypeAndAttachment);
                newCells.Add(sameTypeAndAttachment);

                Cell attachment =
                    new(11, protectivePadding.Attachment ?? string.Empty);
                newCells.Add(attachment);

                Cell parentId =
                    new(12, protectivePadding.ParentId);
                newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, PROTECTIVE_PADDING);
            }

            return maxId;
        }

        public Models.Step5.ProtectivePadding? GetByRow(Row row)
        {
            Models.Step5.ProtectivePadding item = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            item.Id = (int)id;

            Cell fireRatingCell = row.GetCellByColumnName("B");
            item.FireRating = _excel.GetString(fireRatingCell);

            Cell impactRatingCell = row.GetCellByColumnName("C");
            item.ImpactRating = _excel.GetString(impactRatingCell);

            Cell constructionCell = row.GetCellByColumnName("D");
            item.Construction = _excel.GetString(constructionCell);

            Cell quantityCell = row.GetCellByColumnName("E");
            item.Quantity = _excel.GetString(quantityCell);

            Cell heightFtCell = row.GetCellByColumnName("F");
            item.HeightFt = _excel.GetString(heightFtCell);

            Cell heightInCell = row.GetCellByColumnName("G");
            item.HeightIn = _excel.GetString(heightInCell);

            Cell widthFtCell = row.GetCellByColumnName("H");
            item.WidthFt = _excel.GetString(widthFtCell);

            Cell widthInCell = row.GetCellByColumnName("I");
            item.WidthIn = _excel.GetString(widthInCell);

            Cell sameTypeAndAttachmentCell = row.GetCellByColumnName("J");
            item.SameTypeAndAttachment = _excel.GetBool(sameTypeAndAttachmentCell);

            Cell attachmentCell = row.GetCellByColumnName("K");
            item.Attachment = _excel.GetString(attachmentCell);

            return item;
        }

        public int Update(string path, Models.Step5.ProtectivePadding protectivePadding)
        {
            throw new NotImplementedException();
        }
    }
}
