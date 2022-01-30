using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logs
{
    public class Result
    {
        public Result(bool status, string message)
        {
            Status = status;
            Message = message;
        }

        public bool Status { get; private set; }
        public string Message { get; private set; }
    }
}
