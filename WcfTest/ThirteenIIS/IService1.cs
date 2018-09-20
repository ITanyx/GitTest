﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ThirteenIIS
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract(Name = "WcfServiceContract",
            Namespace = "http://wangweimutou.WcfServiceContract",
            SessionMode = SessionMode.Allowed,
            ProtectionLevel = ProtectionLevel.None,
            ConfigurationName = "Service1")]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);
    }
}
