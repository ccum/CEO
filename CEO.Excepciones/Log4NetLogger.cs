using CEO.LoggingInterface;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEO.Excepciones
{
    public class Log4NetLogger : ILogger
    {
        public Log4NetLogger()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public void WriteMessage(string category, LogLevel level, string message)
        {
            ILog log = LogManager.GetLogger(category);
            switch (level)
            {
                case LogLevel.FATAL:
                    if (log.IsFatalEnabled) log.Fatal(message);
                    break;
                case LogLevel.ERROR:
                    if (log.IsErrorEnabled) log.Error(message);
                    break;
                case LogLevel.WARN:
                    if (log.IsWarnEnabled) log.Warn(message);
                    break;
                case LogLevel.INFO:
                    if (log.IsInfoEnabled) log.Info(message);
                    break;
                case LogLevel.VERBOSE:
                    if (log.IsDebugEnabled) log.Debug(message);
                    break;

            }
        }
    }
}
