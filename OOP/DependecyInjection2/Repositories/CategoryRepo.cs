

using DependecyInjection2.Logging.Bases;

namespace DependecyInjection2.Repositories
{
    public class CategoryRepo
    {
        public ILogger Logger { get; set; }

        public void Update()
        {
            Console.WriteLine("Kategori güncellendi.");
            Logger.Log();
        }
    }
}
