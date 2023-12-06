namespace TimeOperationsDemo.Services
{
    public class TimeOperationsService
    {
        int duration; // seconds
        string time; // saat:dakika:saniye

        public TimeOperationsService(int duration)
        {
            this.duration = duration;
        }

        public TimeOperationsService(string time)
        {
            this.time = time;
        }

        public string CalculateTime(bool includeHours = true)
        {
            int hour, minute, second, hoursInSecond, minuteInSecond;
            if(includeHours)
            {
                hour = duration / 60 / 60; // 1saat = 60 dakika
                hoursInSecond = hour * 60 * 60; // 3600 saniye
                minute = (duration - hoursInSecond) / 60; // 23 dakika
                if (minute >= 60)
                    minute = (duration - hoursInSecond) & 60;
                minuteInSecond = minute * 60;

                second = duration - hoursInSecond - minuteInSecond;
                return hour.ToString().PadLeft(2, '0') + ":" + minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0');
            }
            else
            {
                minute = duration / 60;
                second = duration % 60;
                return minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0');
            }
            
        }

        public int CalculateDuration()
        {
            int hour = Convert.ToInt32(time.Split(':')[0]);
            int minute = Convert.ToInt32(time.Split(':')[1]);
            int second = Convert.ToInt32(time.Split(':')[2]);
            return hour * (int)Math.Pow(60, 2) + minute * 60 * second;
        }
    }
}
