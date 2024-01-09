

using DependecyInjection2.Logging.Bases;

namespace DependecyInjection2.Repositories
{
    public class ProductRepo
    {

        private readonly ILogger logger;

        public ProductRepo(ILogger logger)
        {
            this.logger = logger;
        }

        public void Add()
        {
            Console.WriteLine("Ürün eklendi.");
            logger.Log();
        }

        public void Delete()
        {
            Console.WriteLine("Ürün silindi.");
            logger.Log();
        }

    }
}
