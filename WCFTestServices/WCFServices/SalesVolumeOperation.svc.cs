using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServices
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“SalesVolumeOperation”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 SalesVolumeOperation.svc 或 SalesVolumeOperation.svc.cs，然后开始调试。
    public class SalesVolumeOperation : ISalesVolumeOperation
    {
        public string ShowSalesVolume()
        {
            //DataSet ds = new DataSet();
            //SqlConnection con = new SqlConnection("data source=.;initial catalog=SalesLibrary;user id=sa;password=sa123");
            //string sql = "proc_ShowSalesVolume";      //存储过程名称
            //using (SqlCommand cmd = new SqlCommand(sql, con))
            //{
            //    con.Open();
            //    cmd.CommandType = CommandType.StoredProcedure;

            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(ds);
            //}
            //return ds.Tables[0];

            return "hello world-123";
        }
    }
}
