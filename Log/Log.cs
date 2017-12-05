using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log
{
    public static class Log
    {
        private static Logger objInstance { get; set; }

        public static void LogMessage(Logger objLogger, LogLevel logLevel, string strMessage, string strFunctionName, string strParameters)
        {
            objInstance = objLogger;
            objInstance.Log(logLevel, "Message: {0}. Function: {1}. Parameters: {2}.", strMessage, strFunctionName, strParameters);
        }
    }
}
