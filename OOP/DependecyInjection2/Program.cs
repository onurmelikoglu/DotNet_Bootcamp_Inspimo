using DependecyInjection2.Logging;
using DependecyInjection2.Logging.Bases;
using DependecyInjection2.Repositories;

namespace DependecyInjection2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new FileLogger(); // DatabaseLogger() 
            ProductRepo productRepo = new ProductRepo(logger);
            productRepo.Add();
            productRepo.Delete();

            CategoryRepo categoryRepo = new CategoryRepo()
            {
                Logger = logger
            };
            categoryRepo.Update();

            StoreRepo storeRepo = new StoreRepo();
            storeRepo.GetList(logger);
            storeRepo.GetDetails(new DatabaseLogger());
        }
    }
}
