using System;
using Logs;
namespace M2HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger logger = Logger.Instance;
            Starter.Run();
            logger.PrintLogs();
        }
    }
}
