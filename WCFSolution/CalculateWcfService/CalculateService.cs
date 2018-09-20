using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateWcfService
{
    public class CalculateService : ICalculateService
    {
        /// <summary>
        /// 加
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double AddOperation(double num1, double num2)
        {
            return num1 + num2;
        }

        /// <summary>
        /// 减
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double SubOperation(double num1, double num2)
        {
            return num1 - num2;
        }

        /// <summary>
        /// 乘
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double MulOperation(double num1, double num2)
        {
            return num1 * num2;
        }

        /// <summary>
        /// 除
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double DivOperation(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
