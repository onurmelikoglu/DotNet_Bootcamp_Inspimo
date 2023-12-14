namespace StaticDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Database.Name);
            Database.SetNameAndLanguage("MS SQL", "T-SQL");
            Console.WriteLine(Database.Name);
            Console.WriteLine(Database.Language);

            Database db = new Database();
            db.Log("select * from products");
        }
    }

    class Database
    {
        public static string Name { get; set; }
        public static string Language { get; set; }

        static Database()
        {
            Name = "Oracle";
            Language = "PL/SQL";
        }

        public static void SetNameAndLanguage(string name, string language)
        {
            Name = name;
            Language = language;
        }

        public void Log(string sql)
        {
            Console.WriteLine($"\"{sql}\" logged.");
        }

    }
}
