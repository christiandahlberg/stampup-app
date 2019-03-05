using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resources
{
    public class Performance
    {
        private static Stopwatch _watch;
        private static string _methodName;
        
        public static void StartResponseTimer(string methodName)
        {
            _methodName = methodName;
            _watch = new Stopwatch();
            _watch.Start();
        }

        public static void EndResponseTimer()
        {
            _watch.Stop();
            TimeSpan ts = _watch.Elapsed;

            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);

            LogResponseTime(elapsedTime);
        }

        public static void LogResponseTime(string elapsedTime)
        {
            // Include enterprise logic for logging exceptions   
            // Get the absolute path to the log file   
            string logFile = Directory.GetParent(Directory.GetCurrentDirectory())
                .Parent.Parent.FullName + @"\Resources\Resources\ResponseTime.txt";

            // Open the log file for append and write the log  
            StreamWriter sw = new StreamWriter(logFile, true);
            sw.WriteLine("********** {0} **********", DateTime.Now);
            sw.WriteLine("Method: " + _methodName);
            sw.WriteLine("Response Time: " + elapsedTime);
            sw.Close();
        }
    }
}
