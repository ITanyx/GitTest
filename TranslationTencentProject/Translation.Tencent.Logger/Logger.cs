using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation.Tencent.Logger
{
    public class Logger
    {
        private static object _syncLockObject = new object();
        private static Logger _defaultLogger;
        private static Dictionary<string, Logger> _loggers = new Dictionary<string, Logger>();
        private ILoggerProvider _currentProvider;
        public Logger this[string providerName]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(providerName))
                {
                    return Logger.DefaultLogger;
                }
                return Logger.GetLogger(providerName);
            }
        }
        public static Logger DefaultLogger
        {
            get
            {
                if (Logger._defaultLogger == null)
                {
                    lock (Logger._syncLockObject)
                    {
                        if (Logger._defaultLogger == null)
                        {
                            try
                            {
                                Logger._defaultLogger = new Logger();
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    }
                }
                return Logger._defaultLogger;
            }
        }
        private Logger(string providerName)
        {
            this._currentProvider = LoggerProviderFactory.GetLoggerProvider(providerName);
        }
        private Logger()
        {
            this._currentProvider = LoggerProviderFactory.GetLoggerProvider();
        }
        public void Error(Exception exception)
        {
            this._currentProvider.Write(exception, LogLevel.ERROR);
        }
        public void Error(object message)
        {
            this._currentProvider.Write(message, LogLevel.ERROR);
        }
        public void Error(Exception exception, object message)
        {
            this._currentProvider.Write(exception, message, LogLevel.ERROR);
        }
        [Obsolete]
        public void Error(Exception exception, string message)
        {
            this._currentProvider.Write(exception, message, LogLevel.ERROR);
        }
        [Obsolete]
        public void Error(string message)
        {
            this._currentProvider.Write(message, LogLevel.ERROR);
        }
        public void Fault(Exception exception)
        {
            this._currentProvider.Write(exception, LogLevel.FATAL);
        }
        public void Fault(object message)
        {
            this._currentProvider.Write(message, LogLevel.FATAL);
        }
        public void Fault(Exception exception, object message)
        {
            this._currentProvider.Write(exception, message, LogLevel.FATAL);
        }
        [Obsolete]
        public void Fault(string message)
        {
            this._currentProvider.Write(message, LogLevel.FATAL);
        }
        public void Warn(Exception exception)
        {
            this._currentProvider.Write(exception, LogLevel.WARN);
        }
        public void Warn(object message)
        {
            this._currentProvider.Write(message, LogLevel.WARN);
        }
        public void Warn(Exception exception, object message)
        {
            this._currentProvider.Write(exception, message, LogLevel.WARN);
        }
        [Obsolete]
        public void Warn(string message)
        {
            this._currentProvider.Write(message, LogLevel.WARN);
        }
        public void Info(object message)
        {
            this._currentProvider.Write(message, LogLevel.INFO);
        }
        [Obsolete]
        public void Info(string message)
        {
            this._currentProvider.Write(message, LogLevel.INFO);
        }
        public void Debug(object message)
        {
            this._currentProvider.Write(message, LogLevel.DEBUG);
        }
        [Obsolete]
        public void Debug(string message)
        {
            this._currentProvider.Write(message, LogLevel.DEBUG);
        }
        public void Write(object message, LogLevel level)
        {
            this._currentProvider.Write(message, level);
        }
        public void Write(Exception exception, object message, LogLevel level)
        {
            this._currentProvider.Write(exception, message, level);
        }
        public static void WriteError(Exception exception)
        {
            Logger.DefaultLogger.Error(exception);
        }
        public static void WriteError(Exception exception, object message)
        {
            Logger.DefaultLogger.Error(exception, message);
        }
        public static void WriteError(object message)
        {
            Logger.DefaultLogger.Error(message);
        }
        [Obsolete]
        public static void WriteError(Exception exception, string message)
        {
            Logger.DefaultLogger.Error(exception, message);
        }
        [Obsolete]
        public static void WriteError(string message)
        {
            Logger.DefaultLogger.Error(message);
        }
        public static void WriteFault(object message)
        {
            Logger.DefaultLogger.Fault(message);
        }
        public static void WriteFault(Exception exception)
        {
            Logger.DefaultLogger.Fault(exception);
        }
        public static void WriteFault(Exception exception, object message)
        {
            Logger.DefaultLogger.Fault(exception, message);
        }
        [Obsolete]
        public static void WriteFault(string message)
        {
            Logger.DefaultLogger.Fault(message);
        }
        public static void WriteWarn(object message)
        {
            Logger.DefaultLogger.Warn(message);
        }
        public static void WriteWarn(Exception exception)
        {
            Logger.DefaultLogger.Warn(exception);
        }
        public static void WriteWarn(Exception exception, object message)
        {
            Logger.DefaultLogger.Warn(exception, message);
        }
        [Obsolete]
        public static void WriteWarn(string message)
        {
            Logger.DefaultLogger.Warn(message);
        }
        public static void WriteInfo(object message)
        {
            Logger.DefaultLogger.Info(message);
        }
        [Obsolete]
        public static void WriteInfo(string message)
        {
            Logger.DefaultLogger.Info(message);
        }
        public static void WriteDebug(object message)
        {
            Logger.DefaultLogger.Debug(message);
        }
        [Obsolete]
        public static void WriteDebug(string message)
        {
            Logger.DefaultLogger.Debug(message);
        }
        public static Logger GetLogger(string providerName)
        {
            if (string.IsNullOrWhiteSpace(providerName))
            {
                return Logger.DefaultLogger;
            }
            if (!Logger._loggers.ContainsKey(providerName))
            {
                lock (Logger._syncLockObject)
                {
                    if (!Logger._loggers.ContainsKey(providerName))
                    {
                        Logger._loggers.Add(providerName, new Logger(providerName));
                    }
                }
            }
            return Logger._loggers[providerName];
        }
    }
}
