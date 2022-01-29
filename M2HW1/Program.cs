using System;
using Logs;
namespace M2HW1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Starter.Run();
            Logger logger = Logger.Instance;
            logger.PrintLogs();
        }
    }
}
