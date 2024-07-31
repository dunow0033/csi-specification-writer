using System;
using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step4;
using DocumentGenerator.Service.Models.Step4;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step4
{
    public class BattingMultisportThrowCagesModel : IBattingMultisportThrowCagesModel
    {
        private readonly string BATTING_MULTISPORT_THROW_CAGES_MODEL = "BattingMultiSportThrowCagesModel";

        private readonly IExcel _excel;
        private readonly IBattingMultisportThrowCages _battingMultisportThrowCages;
        private readonly IBattingMultisportThrowCagesAccessories _battingMultisportThrowCagesAccessories;

        public BattingMultisportThrowCagesModel(
            IExcel excel,
            IBattingMultisportThrowCages battingMultisportThrowCages,
            IBattingMultisportThrowCagesAccessories battingMultisportThrowCagesAccessories
            )
        {
            _excel = excel;
            _battingMultisportThrowCages = battingMultisportThrowCages;
            _battingMultisportThrowCagesAccessories = battingMultisportThrowCagesAccessories;
        }

        public int Create(string path, BattingMultiSportThrowCagesModel battingMultiSportThrowCagesModel)
        {
            int maxId;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet workSheet = fastExcel.Read(BATTING_MULTISPORT_THROW_CAGES_MODEL);
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

                fastExcel.Write(workSheet, BATTING_MULTISPORT_THROW_CAGES_MODEL);
            }

            return maxId;
        }

        public BattingMultiSportThrowCagesModel? GetByRow(Row row, FastExcel.FastExcel fastExcel)
        {
            BattingMultiSportThrowCagesModel model = new()
            {
                BattingMultiSportThrowCages = new(),
                BattingMultiSportThrowCagesAccessories = new()
            };

            Cell idCell = row.GetCellByColumnName("A");
            if (idCell == null) return null;
            int? id = _excel.GetInt(idCell);
            if (id == null) return null;

            model.Id = (int)id;

            Cell battingMultisportThrowCagesIdCell = row.GetCellByColumnName("B");
            int? battingMultisportThrowCagesIdCellId = _excel.GetInt(battingMultisportThrowCagesIdCell);

            Cell battingMultisportThrowCageAccessoriesIdCell = row.GetCellByColumnName("C");
            int? battingMultisportThrowCageAccessoriesIdCellId = _excel.GetInt(battingMultisportThrowCageAccessoriesIdCell);

            if (battingMultisportThrowCagesIdCellId != null && battingMultisportThrowCageAccessoriesIdCellId != null)
            {
                model.BattingMultiSportThrowCages = _battingMultisportThrowCages.GetByRow(row);
                model.BattingMultiSportThrowCagesAccessories = _battingMultisportThrowCagesAccessories.GetByRow(row);
            }

            return model;
        }

        public int Update(string path, BattingMultiSportThrowCagesModel battingMultiSportThrowCagesModel)
        {
            throw new NotImplementedException();
        }
    }
}

