using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs
{
    public class Logger
    {
        private static Logger _instance = new Logger();
        private List<string> _logs = new List<string>();
        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public void AddLog(DateTime timeLog, TypesOfLogs typeLog, string message)
        {
            _logs.Add($"{timeLog.ToLongTimeString()} : {typeLog} : {message}");
        }

        public void PrintLogs()
        {
            foreach (var item in _logs)
            {
                Console.WriteLine(item);
            }
        }

        public string ConvertListToString()
        {
            return string.Join('\n', _logs);
        }
    }
}
