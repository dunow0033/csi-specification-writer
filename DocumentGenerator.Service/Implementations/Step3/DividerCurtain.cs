using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step3;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step3
{
    public class DividerCurtain : IDividerCurtain
    {
        private readonly string DIVIDER_CURTAIN = "DividerCurtain";

        private readonly IExcel _excel;

        public DividerCurtain(IExcel excel)
        {
            _excel = excel;
        }

        public int Create(string path, Models.Step3.DividerCurtain dividerCurtain)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(DIVIDER_CURTAIN);
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

                fastExcel.Write(workSheet, DIVIDER_CURTAIN);
            }

            return maxId;
        }

        public Models.Step3.DividerCurtain? GetByRow(Row row)
        {
            Models.Step3.DividerCurtain dividerCurtain = new();

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            dividerCurtain.Id = (int)id;

            Cell curtainStrucureCell = row.GetCellByColumnName("B");
            dividerCurtain.CurtainStructure = _excel.GetString(curtainStrucureCell);

            Cell quantityCell = row.GetCellByColumnName("C");
            dividerCurtain.Quantity = _excel.GetString(quantityCell);

            Cell allTheSameTypeAndAttachmentCell = row.GetCellByColumnName("D");
            dividerCurtain.AllTheSameTypeAndAttachment = _excel.GetBool(allTheSameTypeAndAttachmentCell);

            Cell heightFtCell = row.GetCellByColumnName("E");
            dividerCurtain.HeightFt = _excel.GetString(heightFtCell);

            Cell heightInCell = row.GetCellByColumnName("F");
            dividerCurtain.HeightIn = _excel.GetString(heightInCell);

            Cell widthFtCell = row.GetCellByColumnName("G");
            dividerCurtain.WidthFt = _excel.GetString(widthFtCell);

            Cell widthInCell = row.GetCellByColumnName("H");
            dividerCurtain.WidthIn = _excel.GetString(widthInCell);

            Cell attachmentCell = row.GetCellByColumnName("I");
            dividerCurtain.Attachment = _excel.GetString(attachmentCell);

            Cell trussHeightFeetCell = row.GetCellByColumnName("J");
            dividerCurtain.TrussHeightFt = _excel.GetString(trussHeightFeetCell);

            Cell trussHeightInchCell = row.GetCellByColumnName("K");
            dividerCurtain.TrussHeightIn = _excel.GetString(trussHeightInchCell);

            Cell trussSpacingFeetCell = row.GetCellByColumnName("L");
            dividerCurtain.TrussSpacingFt = _excel.GetString(trussSpacingFeetCell);

            Cell trussSpacingInchCell = row.GetCellByColumnName("M");
            dividerCurtain.TrussSpacingIn = _excel.GetString(trussSpacingInchCell);

            return dividerCurtain;
        }

        public int Update(string path, Models.Step3.DividerCurtain dividerCurtain)
        {
            throw new NotImplementedException();
        }
    }
}

