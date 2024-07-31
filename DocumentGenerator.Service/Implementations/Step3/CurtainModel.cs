using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step3;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step3
{
    public class CurtainModel : ICurtainModel
    {
        private readonly string CURTAIN_MODEL = "CurtainModel";

        private readonly IExcel _excel;
        private readonly IDividerCurtain _dividerCurtain;
        private readonly ICurtainAccessories _curtainAccessories;

        public CurtainModel(IExcel excel, IDividerCurtain dividerCurtain, ICurtainAccessories curtainAccessories)
        {
            _excel = excel;
            _dividerCurtain = dividerCurtain;
            _curtainAccessories = curtainAccessories;
        }

        public int Create(string path, Models.Step3.CurtainModel curtainModel)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(CURTAIN_MODEL);
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

                fastExcel.Write(workSheet, CURTAIN_MODEL);
            }

            return maxId;
        }

        public Models.Step3.CurtainModel? GetByRow(Row row, FastExcel.FastExcel fastExcel)
        {
            Models.Step3.CurtainModel curtainModel = new()
            {
                DividerCurtain = new(),
                CurtainAccessories = new()
            };

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            curtainModel.Id = (int)id;

            Cell dividerCurtainIdCell = row.GetCellByColumnName("B");
            int? dividerCurtainId = _excel.GetInt(dividerCurtainIdCell);

            Cell curtainAccessoriesIdCell = row.GetCellByColumnName("C");
            int? curtainAccessoriesId = _excel.GetInt(curtainAccessoriesIdCell);

            if (dividerCurtainId != null && curtainAccessoriesId != null)
            {
                curtainModel.DividerCurtain = _dividerCurtain.GetByRow(row);
                curtainModel.CurtainAccessories = _curtainAccessories.GetByRow(row);
            }

            return curtainModel;
        }

        public int Update(string path, Models.Step3.CurtainModel curtainModel)
        {
            throw new NotImplementedException();
        }
    }
}

