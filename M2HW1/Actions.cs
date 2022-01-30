using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs
{
    public static class Actions
    {
        public static Result Fun1()
        {
            Logger logger = Logger.Instance;
            logger.AddLog(DateTime.Now, TypesOfLogs.Info, "Start method: Fun1");
            return new Result(true, "None");
        }

        public static Result Fun2()
        {
            Logger logger = Logger.Instance;
            logger.AddLog(DateTime.Now, TypesOfLogs.Warning, "Skipped logic in method: Fun2");
            return new Result(true, "None");
        }

        public static Result Fun3()
        {
            Logger logger = Logger.Instance;
            logger.AddLog(DateTime.Now, TypesOfLogs.Error, "I broke a logic: Fun3");
            return new Result(false, "I broke a logic");
        }
    }
}
