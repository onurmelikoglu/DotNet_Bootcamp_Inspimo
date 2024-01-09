using DependecyInjection2.Logging.Bases;

namespace DependecyInjection2.Repositories
{
    public class StoreRepo
    {
        public void GetList(ILogger logger) 
        {
            Console.WriteLine("Mağazalar listelendi.");
            logger.Log();
        }

        public void GetDetails(ILogger logger)
        {
            Console.WriteLine("Mağaza detayı listelendi.");
            logger.Log();
        }
    }
}
