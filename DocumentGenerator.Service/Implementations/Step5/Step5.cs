using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step5;
using DocumentGenerator.Service.Models.Step5;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step5
{
    public class Step5 : IStep5
    {
        private readonly string STEP = "Step5";
        private readonly string PROTECTIVE_PADDING = "ProtectivePadding";
        private readonly string PROTECTIVE_PADDING_ACCESSORIES = "ProtectivePaddingAccessories";

        private readonly IExcel _excel;
        private readonly IProtectivePadding _protectivePadding;
        private readonly IProtectivePaddingAccessories _protectivePaddingAccessories;

        public Step5(
            IExcel excel,
            IProtectivePadding protectivePadding,
            IProtectivePaddingAccessories protectivePaddingAccessories
            )
        {
            _excel = excel;
            _protectivePadding = protectivePadding;
            _protectivePaddingAccessories = protectivePaddingAccessories;
        }

        public int Create(string path, Step5Model step5Model)
        {
            int newId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet stepWorkSheet = fastExcel.Read(STEP);
                int stepRowCount = stepWorkSheet.Rows.Count();
                List<Row> rows = stepWorkSheet.Rows.ToList();

                newId = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();
                Cell id = new(1, newId.ToString());
                Cell createdOn = new(2, DateTime.Now.ToShortDateString());

                newCells.Add(id);
                newCells.Add(createdOn);

                Row newRow = new(stepRowCount + 1, newCells);
                rows.Add(newRow);
                stepWorkSheet.Rows = rows;

                fastExcel.Write(stepWorkSheet, STEP);
            }

            step5Model.ProtectivePadding.ParentId = newId;
            _protectivePadding.Create(path, step5Model.ProtectivePadding);

            step5Model.ProtectivePaddingAccessories.ParentId = newId;
            _protectivePaddingAccessories.Create(path, step5Model.ProtectivePaddingAccessories);

            return newId;
        }

        public Step5Model GetById(string path, int id)
        {
            Step5Model step = new();
            List<Step5Model> list = new();

            using (FastExcel.FastExcel fastExcel = new(new FileInfo(path), true))
            {
                Worksheet stepWorkSheet = fastExcel.Read(STEP);
                int stepRowCount = stepWorkSheet.Rows.Count();
                List<Row> rows = stepWorkSheet.Rows.ToList();

                for (int rowNumber = 1; rowNumber < stepRowCount; rowNumber++)
                {
                    Row row = rows[rowNumber];
                    Step5Model? stepModel = GetStepInfo(row);
                    if (stepModel == null) continue;
                    if (stepModel.Id != id) continue;

                    step.Id = stepModel.Id;
                    step.CreatedOn = stepModel.CreatedOn;
                    step.DeletedOn = stepModel.DeletedOn;

                    Worksheet protectivePaddingWorkSheet = fastExcel.Read(PROTECTIVE_PADDING);
                    int protectivePaddingRowCount = protectivePaddingWorkSheet.Rows.Count();
                    List<Row> protectivePaddingRows = protectivePaddingWorkSheet.Rows.ToList();

                    for (int protectivePaddingRowNumber = 1; protectivePaddingRowNumber < protectivePaddingRowCount; protectivePaddingRowNumber++)
                    {
                        Row protectivePaddingRow = protectivePaddingRows[protectivePaddingRowNumber];
                        Cell parentIdCell = protectivePaddingRow.GetCellByColumnName("L");
                        if (parentIdCell == null) continue;

                        int? parentId = _excel.GetInt(parentIdCell);
                        if (parentId == null) continue;
                        if (parentId != stepModel.Id) continue;

                        Models.Step5.ProtectivePadding? protectivePadding =
                            _protectivePadding.GetByRow(protectivePaddingRow);
                        if (protectivePadding == null) continue;

                        step.ProtectivePadding = protectivePadding;
                    }

                    Worksheet protectivePaddingAccessoriesWorkSheet = fastExcel.Read(PROTECTIVE_PADDING_ACCESSORIES);
                    int protectivePaddingAccessoriesRowCount = protectivePaddingAccessoriesWorkSheet.Rows.Count();
                    List<Row> protectivePaddingAccessoriesRows = protectivePaddingAccessoriesWorkSheet.Rows.ToList();

                    for (int protectivePaddingAccessoriesRowNumber = 1; protectivePaddingAccessoriesRowNumber < protectivePaddingAccessoriesRowCount; protectivePaddingAccessoriesRowNumber++)
                    {
                        Row protectivePaddingAccessoriesRow = protectivePaddingAccessoriesRows[protectivePaddingAccessoriesRowNumber];
                        Cell parentIdCell = protectivePaddingAccessoriesRow.GetCellByColumnName("D");
                        if (parentIdCell == null) continue;

                        int? parentId = _excel.GetInt(parentIdCell);
                        if (parentId == null) continue;
                        if (parentId != stepModel.Id) continue;

                        Models.Step5.ProtectivePaddingAccessories? protectivePaddingAccessories =
                            _protectivePaddingAccessories.GetByRow(protectivePaddingAccessoriesRow);
                        if (protectivePaddingAccessories == null) continue;

                        step.ProtectivePaddingAccessories = protectivePaddingAccessories;
                    }
                }
            }

            return step;
        }

        private Step5Model? GetStepInfo(Row row)
        {
            Step5Model stepModel = new();
            Cell idCell = row.GetCellByColumnName("A");

            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;
            stepModel.Id = (int)id;

            Cell createdOnCell = row.GetCellByColumnName("B");
            stepModel.CreatedOn = _excel.GetDateTime(createdOnCell);

            Cell deletedOnCell = row.GetCellByColumnName("C");
            stepModel.DeletedOn = _excel.GetDateTime(deletedOnCell);

            return stepModel;
        }

        public int Update(string path, Step5Model step5Model)
        {
            throw new NotImplementedException();
        }
    }
}

