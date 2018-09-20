using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation.Tencent.Logger
{
    public interface ILoggerProvider
    {
        void Write(Exception exception, LogLevel level = LogLevel.ERROR);
        void Write(Exception exception, object message, LogLevel level = LogLevel.ERROR);
        void Write(object message, LogLevel level);
    }
}
