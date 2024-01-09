
using DependecyInjection2.Logging.Bases;

namespace DependecyInjection2.Logging
{
    public class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
