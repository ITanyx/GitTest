using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Translation.Tencent.Entity.Enum;

namespace Translation.Tencent.Api.Models.Response
{
    public class ApiResultModel
    {
        public ApiResultModel()
        {
            this.StatusCode = (int)ApiStatusCode.Success;
            this.Message = "Success";
        }

        public ApiResultModel(int statusCode, string message, object data)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }

        /// <summary>
        /// 状态码
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// 返回消息描述
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 返回数据
        /// </summary>
        public object Data { get; set; }
    }
}