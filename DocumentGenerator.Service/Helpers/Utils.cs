using FastExcel;

namespace DocumentGenerator.Service.Helpers
{
    public static class Utils
    {
        public static int GetNextId(List<Row> rows)
        {
            List<int> ints = new();
            rows.ForEach(row =>
            {
                Cell idCell = row.GetCellByColumnName("A");

                string? idValue = idCell.Value.ToString();
                if (!int.TryParse(idValue, out int id))
                {
                    return;
                }
                ints.Add(id);
            });
            return ints.Count > 0 ? ints.Max() + 1 : 1;
        }
    }
}
