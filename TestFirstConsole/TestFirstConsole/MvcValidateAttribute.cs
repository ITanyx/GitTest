using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole
{
    /// <summary>
    /// 范围验证特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class RangeValidateAttribute : ValidateBaseAttribute
    {
        private long _lMin = 0;
        private long _lMax = 0;
        private string errorMsg;

        public RangeValidateAttribute(long lMin,long lMax, string errorMessage)
        {
            this._lMax = lMax;
            this._lMin = lMin;
            this.errorMsg = errorMessage;
        }

        public override string ErrorMessage
        {
            protected set
            {
                this.errorMsg = value;
            }
            get
            {
                return this.errorMsg;
            }
        }

        public override bool Validate(object oValue)
        {
            if (oValue == null)
            {
                return false;
            }

            long lCurrent = 0;
            if (!long.TryParse(oValue.ToString(),out lCurrent))
            {
                return false;
            }

            return lCurrent > _lMin && lCurrent < _lMax;
        }
    }

    /// <summary>
    /// 非空验证
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : ValidateBaseAttribute
    {
        public RequiredAttribute(string errorMessage,bool isAllow = false)
        {
            this.isAllowEmpty = isAllow;
            this.errorMsg = errorMessage;
        }

        private bool isAllowEmpty;
        private string errorMsg;

        public override string ErrorMessage
        {
            protected set
            {
                this.errorMsg = value;
            }
            get
            {
                return this.errorMsg;
            }
        }

        public override bool Validate(object lCurrent)
        {
            if (isAllowEmpty)
            {
                return true;
            }

            if (lCurrent == null 
                || string.IsNullOrWhiteSpace(lCurrent.ToString()))
            {
                return false;
            }

            return true;
        }
    }

    public abstract class ValidateBaseAttribute : Attribute
    {
        public abstract string ErrorMessage { get; protected set; }
        public abstract bool Validate(object lCurrent);
    }

    public class Student
    {
        [RangeValidateAttribute(1000, 99999999999, "数据超出了范围,请检查")]
        public long QQ { get; set; }

        public long Id { get; set; }

        [RequiredAttribute("名称不能为空")]
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class DateValidateModel
    {
        private Dictionary<string, string> errorDictionary = new Dictionary<string, string>();
        public Dictionary<string, string> ErrorDictionary
        {
            get
            {
                return this.errorDictionary;
            }
            private set
            {
                this.errorDictionary = value;
            }
        }
        public bool Validate<T>(T t)
        {
            Type type = typeof(T);
            foreach (var item in type.GetProperties())
            {
                if (!item.IsDefined(typeof(ValidateBaseAttribute),true))
                {
                    continue;
                }

                ValidateBaseAttribute attribute = item.GetCustomAttributes(typeof(ValidateBaseAttribute), true)[0] as ValidateBaseAttribute;
                if (!attribute.Validate(item.GetValue(t)))
                {
                    errorDictionary.Add(item.Name, attribute.ErrorMessage);
                    continue;
                }
            }

            if (this.errorDictionary.Count > 0)
            {
                return false;
            }
            return true;
        }
    }
}
