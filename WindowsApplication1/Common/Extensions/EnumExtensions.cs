using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GonpaPasaportOtomasyonu
{
    internal static class EnumExtensions
    {
        public static string GetDescription<T>(this T enumValue)
             where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                return null;

            var description = enumValue.ToString();
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

            if (fieldInfo != null)
            {
                var attrs = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), true);
                if (attrs != null && attrs.Length > 0)
                {
                    description = ((DisplayAttribute)attrs[0]).Description;
                }
            }

            return description;
        }
    }
}
