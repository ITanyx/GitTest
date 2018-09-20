using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translation.Tencent.Logger
{
    public class ConfigurationConverter : ConfigurationConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            string text = (string)value;
            if (string.IsNullOrEmpty(text))
            {
                return null;
            }
            Type type = Type.GetType(text, false);
            if (type == null)
            {
                throw new ArgumentException(string.Format("The type '{0}' cannot be resolved. Please verify the spelling is correct or that the full type name is provided.", text));
            }
            return type;
        }
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (value != null)
            {
                Type type = value as Type;
                if (type == null)
                {
                    throw new ArgumentException(string.Format("The AssemblyQualifiedTypeNameConverter can only convert values of type '{0}'.", typeof(Type).Name));
                }
                if (type != null)
                {
                    return type.AssemblyQualifiedName;
                }
            }
            return null;
        }
    }
}
