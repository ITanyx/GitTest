using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestFirstConsole
{
    public static class EnumExtendClass
    {
        public static string EnumExtendMethod(this Enum enumValue)
        {
            Type enumType = enumValue.GetType();
            FieldInfo fieldInfo = enumType.GetField(enumValue.ToString());
            if (fieldInfo.IsDefined(typeof(DescrptionAttribute),true))
            {
                DescrptionAttribute attr = fieldInfo.GetCustomAttribute(typeof(DescrptionAttribute),true) as DescrptionAttribute;
                return attr.Descrption;
            }
            return string.Empty;
        }
    }

    public enum EnumExtend
    {
        [DescrptionAttribute("不可用")]
        Deleted = 1,

        [DescrptionAttribute("可用")]
        Live = 2,
        
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class DescrptionAttribute : Attribute
    {
        private string descrption;
        public DescrptionAttribute(string desc)
        {
            this.descrption = desc;
        }

        public string Descrption
        {
            get { return this.descrption; }
            private set { this.descrption = value; }
        }
    }
}
