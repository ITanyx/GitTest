using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation.Tencent.Entity.Enum
{
    /// <summary>
    /// API返回的错误编码
    /// </summary>
    public enum ApiStatusCode
    {
        /// <summary>
        /// 参数缺失或无效
        /// </summary>
        ParamInvalid = 1000,

        /// <summary>
        /// 接口请求成功
        /// </summary>
        Success = 2000,

        /// <summary>
        /// 第三方接口异常
        /// </summary>
        ThirdPartyException = 3000,

        /// <summary>
        /// 身份验证失败
        /// </summary>
        AuthInvalid = 4000,

        /// <summary>
        /// 无权访问
        /// </summary>
        NoAccess = 4403,

        /// <summary>
        /// 未找到结果
        /// </summary>
        NotFound = 4404,

        /// <summary>
        /// 系统异常
        /// </summary>
        SystemException = 5000,

        /// <summary>
        /// 操作失败
        /// </summary>
        OperateError = 5500,

    }
}
