using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Translation.Tencent.Api.Models.Response;

namespace Translation.Tencent.Api.Controllers
{
    public class TestController : BaseApiController
    {
        [HttpGet]
        public HttpResponseMessage GetTestList()
        {
            ApiResultModel model = new ApiResultModel();
            model.StatusCode = 400;
            model.Message = "OK";
            model.Data = "this is a GET request!";
            return ToJson(model);
        }
    }
}
