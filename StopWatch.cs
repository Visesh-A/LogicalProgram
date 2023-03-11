using System;
namespace LogicalProgram
{
    public class StopWatch
    {
        public void Run()
        {
            const string Start = "start", Stop = "stop";
            Console.WriteLine("Enter start to run the stop watch");
            string start = Console.ReadLine();
            DateTime timeSpan = DateTime.Now;
            {
                int hour1 = timeSpan.Hour;
                int min1 = timeSpan.Minute;
                int sec1 = timeSpan.Second;
                int milli1 = timeSpan.Millisecond;
                Console.WriteLine("Enter stop to end the stop watch");
                string stop = Console.ReadLine();
                if (stop.Equals(stop))
                {
                    DateTime timeSpan1 = DateTime.Now;
                    int hour2 = timeSpan1.Hour;
                    int min2 = timeSpan1.Minute;
                    int sec2 = timeSpan1.Second;
                    int milli2 = timeSpan1.Millisecond;
                    Console.WriteLine("stop watch time " + (hour2 - hour1) + " " + (min2 - min1) + " " + (sec2 - sec1) + " " + (milli2 - milli1));
                }
            }
        }
    }
}