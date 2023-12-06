using TimeOperationsDemo.Services;

namespace TimeOperationsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeOperationsService service1 = new TimeOperationsService(5000);
            Console.WriteLine("Saat: " + service1.CalculateTime());
            Console.WriteLine("Dakika: " + service1.CalculateTime(false));

            TimeOperationsService service2 = new TimeOperationsService("01:23:30");
            Console.WriteLine("Süre (saniye): " + service2.CalculateDuration());

            Test();

        }

        static void Test()
        {
            TimeOperationsService service;
            string time;
            int duration;
            bool error = false;

            for(int i = 1; i <= 5000 && !error; i++)
            {
                service = new TimeOperationsService(i);
                time = service.CalculateTime();
                Console.WriteLine("Time: " + time + ", Duration: " + i + " seconds");
                service = new TimeOperationsService(time);
                duration = service.CalculateDuration();
                if(duration != i)
                    error = true;
            }

            Console.WriteLine(error ? "Calculation error!" : "No calculation errors");
        }
    }
}
