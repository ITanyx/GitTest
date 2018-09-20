using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CalculateWcfService
{
    /// <summary>
    /// 定义服务契约：通过接口实现契约
    /// </summary>
    [ServiceContract(Name = "CalculateService")]
    public interface ICalculateService
    {
        /// <summary>
        /// 定义操作契约
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [OperationContract(Name = "AddOperation")]
        double AddOperation(double num1, double num2);

        /// <summary>
        /// 定义操作契约
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [OperationContract(Name = "SubOperation")]
        double SubOperation(double num1, double num2);

        /// <summary>
        /// 定义操作契约
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [OperationContract(Name = "MulOperation")]
        double MulOperation(double num1, double num2);

        /// <summary>
        /// 定义操作契约
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [OperationContract(Name = "DivOperation")]
        double DivOperation(double num1, double num2);
    }
}
