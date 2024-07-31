using DocumentGenerator.Service.Interfaces;
using FastExcel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DocumentGenerator.Service.Implementations
{
    public class Excel : IExcel
    {
        public Excel()
        {
        }

        public bool GetBool(Cell value)
        {
            if (value == null) return false;
            string? boolValue = value.Value.ToString();
            if (boolValue == null)
                return false;

            if (bool.TryParse(boolValue, out bool outValue))
                return outValue;

            return false;
        }

        public DateTime GetDateTime(Cell date)
        {
            if (date == null) return new DateTime();
            string? dateValue = date.Value.ToString();
            if (dateValue == null)
                return new DateTime();

            if (int.TryParse(dateValue, out int parsedDateNumbers))
                return DateTime.FromOADate(parsedDateNumbers);

            if (DateTime.TryParse(dateValue, out DateTime parsedDate))
                return parsedDate;

            return new DateTime();
        }

        public int? GetInt(Cell integer)
        {
            if (integer == null) return null;
            string? integerValue = integer.Value.ToString();

            if (!int.TryParse(integerValue, out int parsedInteger))
                return null;

            return parsedInteger;
        }

        public string? GetString(Cell stringValue)
        {
            if (stringValue == null) return null;
            string? _stringValue = stringValue.Value.ToString();

            if (_stringValue == null)
                return null;

            return _stringValue;
        }
    }
}
