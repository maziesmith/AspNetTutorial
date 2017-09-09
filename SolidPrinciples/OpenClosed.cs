using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class OpenClosed
    {
        public OpenClosed()
        {

        }

        /// <summary>
        /// A class or function can open for development but a code change of 
        /// </summary>
        public void OpenClosedTechnic()
        {

            //We can inject method here * new implement
            LogContext logContext = new LogContext(new EventLog());
            logContext.WriteLogTo();
        }
    }

    public interface ILogger
    {
        string WriteLog();
    }

    public class EventLog : ILogger
    {
        public string WriteLog()
        {
            return "Event Log";
        }
    }

    public class DataBaseLog : ILogger
    {
        public string WriteLog()
        {
            return "DataBase log";
        }
    }

    public class LogContext
    {
        private ILogger _logger;

        public LogContext(ILogger logger)
        {
            this._logger = logger;
        }

        public string WriteLogTo()
        {
            return _logger.WriteLog();
        }
    }
}
