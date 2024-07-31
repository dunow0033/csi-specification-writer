using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step3;
using DocumentGenerator.Service.Models.Step3;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step3
{
    public class Step3 : IStep3
    {
        private readonly string STEP = "Step3";
        private readonly string CURTAIN_MODEL = "CurtainModel";
        private readonly string DIVIDER_CURTAIN = "DividerCurtain";
        private readonly string CURTAIN_ACCESSORIES = "CurtainAccessories";

        private readonly IExcel _excel;
        private readonly ICurtainModel _curtainModel;

        public Step3(IExcel excel, ICurtainModel curtainModel)
        {
            _excel = excel;
            _curtainModel = curtainModel;
        }

        public Step3Model GetById(string path, int id)
        {
            try
            {
                Step3Model step = new()
                {
                    CurtainList = new()
                };
                List<Step3Model> list = new();

                using (FastExcel.FastExcel fastExcel = new(new FileInfo(path), true))
                {
                    Worksheet stepWorkSheet = fastExcel.Read(STEP);
                    int stepRowCount = stepWorkSheet.Rows.Count();
                    List<Row> rows = stepWorkSheet.Rows.ToList();

                    for (int rowNumber = 1; rowNumber < stepRowCount; rowNumber++)
                    {
                        Row row = rows[rowNumber];
                        Step3Model? stepModel = GetStep3Info(row);
                        if (stepModel == null) continue;
                        if (stepModel.Id != id) continue;

                        step.Id = stepModel.Id;
                        step.CreatedOn = stepModel.CreatedOn;
                        step.DeletedOn = stepModel.DeletedOn;

                        Worksheet curtainModelWorkSheet = fastExcel.Read(CURTAIN_MODEL);
                        int curtainModelRowCount = curtainModelWorkSheet.Rows.Count();
                        List<Row> curtainModelRows = curtainModelWorkSheet.Rows.ToList();
                        List<Row> associatedCurtainModelRows = new();

                        for (int curtainModelRowNumber = 1; curtainModelRowNumber < curtainModelRowCount; curtainModelRowNumber++)
                        {
                            Row curtainModelRow = curtainModelRows[curtainModelRowNumber];
                            Cell parentIdCell = curtainModelRow.GetCellByColumnName("D");
                            if (parentIdCell == null) continue;

                            int? parentId = _excel.GetInt(parentIdCell);
                            if (parentId == null) continue;
                            if (parentId != stepModel.Id) continue;

                            Models.Step3.CurtainModel? curtainModel = _curtainModel.GetByRow(curtainModelRow, fastExcel);
                            if (curtainModel == null) continue;

                            step.CurtainList.Add(curtainModel);
                        }
                    }
                }

                return step;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Step3Model? GetStep3Info(Row row)
        {
            Step3Model stepModel = new();
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

        public int Update(string path, Models.Step3.CurtainModel curtainModel)
        {
            throw new NotImplementedException();
        }

        public int Create(string path, Step3Model step3Model)
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

            //step1Model.ProjectInformation.ParentId = newId;
            //_projectInformation.Create(path, step1Model.ProjectInformation);
            //step1Model.ArchitectInformation.ParentId = newId;
            //_architectInformation.Create(path, step1Model.ArchitectInformation);
            //step1Model.GpsDistributor.ParentId = newId;
            //_gpsDistributor.Create(path, step1Model.GpsDistributor);

            return newId;
        }

        public int Update(string path, Step3Model step3Model)
        {
            throw new NotImplementedException();
        }
    }
}
