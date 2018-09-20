using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;
using Translation.Tencent.Api.Models.Response;

namespace Translation.Tencent.Api.Controllers
{
    public class BaseApiController : ApiController
    {
        /// <summary>
        /// 将对象转换为Json格式的HttpResponseMessage对象
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static HttpResponseMessage ToJson(ApiResultModel model)
        {
            string str = JsonConvert.SerializeObject(model);
            var result = new HttpResponseMessage
            {
                Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json")
            };
            result.Headers.Add("Access-Control-Expose-Headers", "Access-token");
            //result.Headers.Add("Access-token", model.Token);

            //从Token中获取人员信息
            //TofStaffInfo staff = GetStaffInfoByTransferredToken(model.Token);

            //记录响应结果
            Logger.Logger.WriteInfo("【Api响应日志】Api调用来源（Source）：" + HttpContext.Current.Request.Headers["Source"]
                //+ "，Api调用者：" + staff.FullName
                + "，请求的Api Url：" + HttpContext.Current.Request.Url.AbsoluteUri
                //+ "，Api接口返回的Access-Token：" + model.Token
                + "，Api接口返回的结果：" + JsonConvert.SerializeObject(model));

            return result;
        }
    }
}
