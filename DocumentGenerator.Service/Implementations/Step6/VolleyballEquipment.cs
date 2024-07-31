using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step6;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step6
{
    public class VolleyballEquipment : IVolleyballEquipment
    {
        private readonly string VOLLEYBALL_EQUIPMENT = "VolleyballEquipment";

        private readonly IExcel _excel;

        public VolleyballEquipment(IExcel excel)
        {
            _excel = excel;
        }

        public int Create(string path, Models.Step6.VolleyballEquipment volleyballEquipment)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(VOLLEYBALL_EQUIPMENT);
                int rowCount = workSheet.Rows.Count();
                List<Row> rows = workSheet.Rows.ToList();

                maxId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();

                Cell id =
                    new(1, maxId);
                newCells.Add(id);

                Cell typeOfSystem =
                    new(2, volleyballEquipment.TypeOfSystem ?? string.Empty);
                newCells.Add(typeOfSystem);

                Cell telescoping =
                    new(3, volleyballEquipment.Telescoping ?? string.Empty);
                newCells.Add(telescoping);

                Cell multisport =
                    new(4, volleyballEquipment.MultiSport ?? string.Empty);
                newCells.Add(multisport);

                Cell quantity =
                    new(5, volleyballEquipment.Quantity ?? string.Empty);
                newCells.Add(quantity);

                Cell courtSize =
                    new(6, volleyballEquipment.CourtSize ?? string.Empty);
                newCells.Add(courtSize);

                Cell widthFt =
                    new(7, volleyballEquipment.WidthFt ?? string.Empty);
                newCells.Add(widthFt);

                Cell widthIn =
                    new(8, volleyballEquipment.WidthIn ?? string.Empty);
                newCells.Add(widthIn);

                Cell attachment =
                    new(9, volleyballEquipment.Attachment ?? string.Empty);
                newCells.Add(attachment);

                Cell trussHeightFt =
                    new(10, volleyballEquipment.TrussHeightFt ?? string.Empty);
                newCells.Add(trussHeightFt);

                Cell trussHeightIn =
                    new(11, volleyballEquipment.TrussHeightIn ?? string.Empty);
                newCells.Add(trussHeightIn);

                Cell sameTypeAndAttachment =
                    new(12, volleyballEquipment.SameTypeAndAttachment);
                newCells.Add(sameTypeAndAttachment);

                Cell trussSpacingFt =
                    new(13, volleyballEquipment.TrussSpacingFt ?? string.Empty);
                newCells.Add(trussSpacingFt);

                Cell trussSpacingIn =
                    new(14, volleyballEquipment.TrussSpacingIn ?? string.Empty);
                newCells.Add(trussSpacingIn);

                Cell parentId =
                    new(15, volleyballEquipment.ParentId);
                newCells.Add(parentId);

                Row newRow = new(rowCount + 1, newCells);
                rows.Add(newRow);
                workSheet.Rows = rows;

                fastExcel.Write(workSheet, VOLLEYBALL_EQUIPMENT);
            }

            return maxId;
        }

        public Models.Step6.VolleyballEquipment? GetByRow(Row row)
        {
            Models.Step6.VolleyballEquipment item = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            item.Id = (int)id;

            Cell typeOfSystemCell = row.GetCellByColumnName("B");
            item.TypeOfSystem = _excel.GetString(typeOfSystemCell);

            Cell telescopingCell = row.GetCellByColumnName("C");
            item.Telescoping = _excel.GetString(telescopingCell);

            Cell multisportCell = row.GetCellByColumnName("D");
            item.MultiSport = _excel.GetString(multisportCell);

            Cell quantityCell = row.GetCellByColumnName("E");
            item.Quantity = _excel.GetString(quantityCell);

            Cell courtSizeCell = row.GetCellByColumnName("F");
            item.CourtSize = _excel.GetString(courtSizeCell);

            Cell widthFtCell = row.GetCellByColumnName("G");
            item.WidthFt = _excel.GetString(widthFtCell);

            Cell widthInCell = row.GetCellByColumnName("H");
            item.WidthIn = _excel.GetString(widthInCell);

            Cell attachmentCell = row.GetCellByColumnName("I");
            item.Attachment = _excel.GetString(attachmentCell);

            Cell trussHeightFeetCell = row.GetCellByColumnName("J");
            item.TrussHeightFt = _excel.GetString(trussHeightFeetCell);

            Cell trussHeightInchCell = row.GetCellByColumnName("K");
            item.TrussHeightIn = _excel.GetString(trussHeightInchCell);

            Cell sameTypeAndAttachmentCell = row.GetCellByColumnName("L");
            item.SameTypeAndAttachment = _excel.GetBool(sameTypeAndAttachmentCell);

            Cell trussSpacingFtCell = row.GetCellByColumnName("M");
            item.TrussSpacingFt = _excel.GetString(trussSpacingFtCell);

            Cell trussSpacingInCell = row.GetCellByColumnName("N");
            item.TrussSpacingIn = _excel.GetString(trussSpacingInCell);

            return item;
        }

        public int Update(string path, Models.Step6.VolleyballEquipment volleyballEquipment)
        {
            throw new NotImplementedException();
        }
    }
}
