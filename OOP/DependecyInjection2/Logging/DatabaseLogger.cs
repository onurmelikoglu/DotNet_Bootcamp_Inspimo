

using DependecyInjection2.Logging.Bases;

namespace DependecyInjection2.Logging
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosya db ye loglandı");
        }
    }
}
