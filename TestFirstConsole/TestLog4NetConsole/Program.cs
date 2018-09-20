using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(ConfigFileExtension = "config", Watch = true)]
namespace TestLog4NetConsole
{
    class Program
    {
        static log4net.ILog log = log4net.LogManager.GetLogger("testApp.Logging");//获取一个日志记录器

        static void Main(string[] args)
        {
            log.Info("这是日志信息记录");
            log.Error("这是错误信息");

            Console.Read();
        }
    }
}
