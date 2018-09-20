﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using TenService;

namespace TenHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(UserInfo)))
            {
                host.Opened += delegate { Console.WriteLine("服务已经启动，按任意键终止！"); };
                host.Open();
                Console.Read();
            }
        }
    }
}
