using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineService
{
    public class ServiceMessage : IServiceMessage
    {
        public string ReturnMessage()
        {
            return "调用服务计算结果如下";
        }
    }
}
