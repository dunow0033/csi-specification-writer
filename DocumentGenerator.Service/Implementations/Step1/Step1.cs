using System.IO;
using DocumentGenerator.Service.Interfaces;
using DocumentGenerator.Service.Interfaces.Step1;
using DocumentGenerator.Service.Models.Step1;
using FastExcel;

namespace DocumentGenerator.Service.Implementations.Step1
{
    public class Step1 : IStep1
    {
        private readonly string STEP = "Step1";
        private readonly string PROJECT_INFORMATION = "ProjectInformation";
        private readonly string ARCHITECT_INFORMATION = "ArchitectInformation";
        private readonly string GPS_DISTRIBUTOR = "GpsDistributor";

        private readonly IExcel _excel;
        private readonly IGet _get;
        // private readonly IProjectInformation _projectInformation;
        // private readonly IGpsDistributor _gpsDistributor;
        // private readonly IArchitectInformation _architectInformation;

        public Step1(
            IExcel excel,
            IGet get
            // IProjectInformation projectInformation,
            // IGpsDistributor gpsDistributor,
            // IArchitectInformation architectInformation
            )
        {
            _excel = excel;
            _get = get;
            // _projectInformation = projectInformation;
            // _gpsDistributor = gpsDistributor;
            // _architectInformation = architectInformation;
        }

        public Step1Model GetById(string path, int id)
        {
            List<Section> sections = new()
            {
                new(PROJECT_INFORMATION, "I"),
                new(STEP, "F"),
                new(STEP, "H")
            };
            return _get.GetById<Step1Model>(STEP, path, id, sections);
        }

        private int Create(string path)
        {
            int id;
            var inputFile = new FileInfo(path);
            using (FastExcel.FastExcel fastExcel = new(inputFile))
            {
                Worksheet stepWorkSheet = fastExcel.Read(STEP);
                int step1RowCount = stepWorkSheet.Rows.Count();
                List<Row> rows = stepWorkSheet.Rows.ToList();

                id = Helpers.Utils.GetNextId(rows);

                List<Cell> newCells = new();
                Cell idCell = new(1, id.ToString());
                Cell createdOnCell = new(2, DateTime.Now.ToShortDateString());

                newCells.Add(idCell);
                newCells.Add(createdOnCell);

                Row newRow = new(step1RowCount + 1, newCells);
                rows.Add(newRow);
                stepWorkSheet.Rows = rows;

                fastExcel.Write(stepWorkSheet, STEP);
                // TODO
                // uncomment line below
                // fastExcel.Dispose();
            }
            return id;
        }

        public int Process(int? idValue, string path, Step1Model stepModel)
        {
            int id = 0;
            // if (idValue != null && idValue != 0 && int.TryParse(idValue.ToString(), out int _id))
            // {
            //     Step1Model model = Update(_id);
            //     id = model.Id;
            // }
            // else
            // {
            //     id = Create(path);
            // }

            // stepModel.ProjectInformation.ParentId = id;
            // _projectInformation.CreateOrUpdate(id, path, stepModel.ProjectInformation);
            // stepModel.ArchitectInformation.ParentId = id;
            // _architectInformation.CreateOrUpdate(id, path, stepModel.ArchitectInformation);
            // stepModel.GpsDistributor.ParentId = id;
            // _gpsDistributor.CreateOrUpdate(id, path, stepModel.GpsDistributor);

            return id;
        }

    }
}
