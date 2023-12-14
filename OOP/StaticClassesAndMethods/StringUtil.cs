using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace StaticClassesAndMethods
{
    public class StringUtil
    {
        public int GetLength(string value) => value.Length;

        public static bool IsEmpty(string value, bool trim = true)
        {
            if (value is null)
                return true;

            if(trim)
            {
                // if(value.Trim() == string.Empty)
                // if(value.Trim().Equals(string.Empty))
                if (string.IsNullOrEmpty(value))
                    return true;
            }
            else
            {
                // if(value.Equals(""))
                if (string.IsNullOrEmpty(value))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsNumeric(string value, out double number, string culture = "tr-TR")
        {
            return double.TryParse(value,NumberStyles.Number, new CultureInfo(culture), out number);
        }
    }
}
