using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Logs
{
    public static class Starter
    {
        public static void Run()
        {
            Random rand = new Random();
            Result result = null;
            Logger logger = Logger.Instance;
            for (int i = 0; i < 100; i++)
            {
                result = rand.Next(3) switch
                {
                    0 => Actions.Fun1(),
                    1 => Actions.Fun2(),
                    _ => Actions.Fun3()
                };
                if (!result.Status)
                {
                    logger.AddLog(DateTime.Now, TypesOfLogs.Error, $"Action failed by a reason: {result.Message}");
                }
            }

            File.WriteAllText("log.txt", logger.ConvertListToString());
        }
    }
}
