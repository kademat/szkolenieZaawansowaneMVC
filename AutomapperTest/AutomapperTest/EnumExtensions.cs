using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapper
{
    public static class EnumExtensions
    {
        public static string ToDisplayString(this Enum value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value");
            }

            string description = value.ToString();
            FieldInfo fieldInfo = value.GetType().GetField(description);
            DisplayAttribute[] attributes =
               (DisplayAttribute[])
             fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                Type resourceType = attributes[0].ResourceType;

                string name = attributes[0].Name;

                if (resourceType != null && name != null)
                {
                    var property = resourceType.GetProperty(name);
                    if (property != null)
                    {
                        var propertyValue = property.GetValue(null);

                        if (propertyValue != null)
                        {
                            description = propertyValue.ToString();
                        }
                    }
                }
            }
            return description;
        }
    }
}
