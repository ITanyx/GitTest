using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation.Tencent.Logger
{
    public class Log4NetProvider : ILoggerProvider
    {
        private ILog _logger;
        public Log4NetProvider(LoggerProviderElement config)
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, config.ConfigFile);
            XmlConfigurator.Configure(new FileInfo(fileName));
            this._logger = LogManager.GetLogger(typeof(Log4NetProvider));
        }
        public virtual void Write(Exception exp, LogLevel level = LogLevel.ERROR)
        {
            this.Write(exp, exp.Message, level);
        }
        public virtual void Write(object message, LogLevel level)
        {
            switch (level)
            {
                case LogLevel.FATAL:
                    {
                        this._logger.Fatal(message);
                        return;
                    }
                case LogLevel.ERROR:
                    {
                        this._logger.Error(message);
                        return;
                    }
                case LogLevel.WARN:
                    {
                        this._logger.Warn(message);
                        return;
                    }
                case LogLevel.INFO:
                    {
                        this._logger.Info(message);
                        return;
                    }
                case LogLevel.DEBUG:
                    {
                        this._logger.Debug(message);
                        return;
                    }
                default:
                    {
                        return;
                    }
            }
        }
        public virtual void Write(Exception exception, object message, LogLevel level)
        {
            switch (level)
            {
                case LogLevel.FATAL:
                    {
                        this._logger.Fatal(message, exception);
                        return;
                    }
                case LogLevel.ERROR:
                    {
                        this._logger.Error(message, exception);
                        return;
                    }
                case LogLevel.WARN:
                    {
                        this._logger.Warn(message, exception);
                        return;
                    }
                case LogLevel.INFO:
                    {
                        this._logger.Info(message, exception);
                        return;
                    }
                case LogLevel.DEBUG:
                    {
                        this._logger.Debug(message, exception);
                        return;
                    }
                default:
                    {
                        return;
                    }
            }
        }
    }
}
