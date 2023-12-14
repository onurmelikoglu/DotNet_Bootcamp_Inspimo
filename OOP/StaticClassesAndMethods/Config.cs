using System.Runtime.CompilerServices;

namespace StaticClassesAndMethods
{
    public static class Config
    {
        // public static string connectionString; // field
        public static string  ConnectionString { get; set; } // property

        public static DateTime date;

        public static void SetDate(DateTime date)
        {
            date = date;
        }
    }
}
