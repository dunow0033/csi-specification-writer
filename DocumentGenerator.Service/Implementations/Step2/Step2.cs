using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step2;
using DocumentGenerator.Service.Models.Step2;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step2
{
    public class Step2 : IStep2
    {
        private readonly string STEP = "Step2";
        private readonly string BASKETBALL_STRUCTURE = "BasketballStructure";
        private readonly string BASKETBALL_ACCESSORIES = "BasketballAccessories";

        private readonly IExcel _excel;
        private readonly IBasketballStructure _basketballStructure;
        private readonly IBasketballAccessories _basketballAccessories;

        public Step2(IExcel excel, IBasketballStructure basketballStructure, IBasketballAccessories basketballAccessories)
        {
            _excel = excel;
            _basketballStructure = basketballStructure;
            _basketballAccessories = basketballAccessories;
        }

        public int Create(string path, Step2Model step2Model)
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

            step2Model.BasketballStructure.ParentId = newId;
            _basketballStructure.Create(path, step2Model.BasketballStructure);

            step2Model.BasketballAccessories.ParentId = newId;
            _basketballAccessories.Create(path, step2Model.BasketballAccessories);

            return newId;
        }

        public Step2Model GetById(string path, int id)
        {
            Step2Model step2 = new();
            List<Step2Model> list = new();

            using (FastExcel.FastExcel fastExcel = new(new FileInfo(path), true))
            {
                Worksheet step2WorkSheet = fastExcel.Read(STEP);
                int step2RowCount = step2WorkSheet.Rows.Count();
                List<Row> rows = step2WorkSheet.Rows.ToList();

                for (int rowNumber = 1; rowNumber < step2RowCount; rowNumber++)
                {
                    Row row = rows[rowNumber];
                    Step2Model? step2Model = GetStep2Info(row);
                    if (step2Model == null) continue;
                    if (step2Model.Id != id) continue;

                    step2.Id = step2Model.Id;
                    step2.CreatedOn = step2Model.CreatedOn;
                    step2.DeletedOn = step2Model.DeletedOn;

                    Worksheet basketballStructureWorkSheet = fastExcel.Read(BASKETBALL_STRUCTURE);
                    int basketballStructureRowCount = basketballStructureWorkSheet.Rows.Count();
                    List<Row> basketballStructureRows = basketballStructureWorkSheet.Rows.ToList();

                    for (int basketballStructureRowNumber = 1; basketballStructureRowNumber < basketballStructureRowCount; basketballStructureRowNumber++)
                    {
                        Row basketballStructureRow = basketballStructureRows[basketballStructureRowNumber];
                        Cell parentIdCell = basketballStructureRow.GetCellByColumnName("M");
                        if (parentIdCell == null) continue;

                        int? parentId = _excel.GetInt(parentIdCell);
                        if (parentId == null) continue;
                        if (parentId != step2Model.Id) continue;

                        Models.Step2.BasketballStructure? basketballStructure =
                            _basketballStructure.GetByRow(basketballStructureRow);
                        if (basketballStructure == null) continue;

                        step2.BasketballStructure = basketballStructure;
                    }

                    Worksheet basketballAccessoriesWorkSheet = fastExcel.Read(BASKETBALL_ACCESSORIES);
                    int basketballAccessoriesRowCount = basketballAccessoriesWorkSheet.Rows.Count();
                    List<Row> basketballAccessoriesRows = basketballAccessoriesWorkSheet.Rows.ToList();

                    for (int basketballAccessoriesRowNumber = 1; basketballAccessoriesRowNumber < basketballAccessoriesRowCount; basketballAccessoriesRowNumber++)
                    {
                        Row basketballAccessoriesRow = basketballAccessoriesRows[basketballAccessoriesRowNumber];
                        Cell parentIdCell = basketballAccessoriesRow.GetCellByColumnName("I");
                        if (parentIdCell == null) continue;

                        int? parentId = _excel.GetInt(parentIdCell);
                        if (parentId == null) continue;
                        if (parentId != step2Model.Id) continue;

                        Models.Step2.BasketballAccessories? basketballAccessories =
                            _basketballAccessories.GetByRow(basketballAccessoriesRow);
                        if (basketballAccessories == null) continue;

                        step2.BasketballAccessories = basketballAccessories;
                    }
                }
            }

            return step2;
        }

        private Step2Model? GetStep2Info(Row row)
        {
            Step2Model step2Model = new();
            Cell idCell = row.GetCellByColumnName("A");

            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;
            step2Model.Id = (int)id;

            Cell createdOnCell = row.GetCellByColumnName("B");
            step2Model.CreatedOn = _excel.GetDateTime(createdOnCell);

            Cell deletedOnCell = row.GetCellByColumnName("C");
            step2Model.DeletedOn = _excel.GetDateTime(deletedOnCell);

            return step2Model;
        }

        public int Update(string path, Step2Model step2Model)
        {
            throw new NotImplementedException();
        }
    }
}
