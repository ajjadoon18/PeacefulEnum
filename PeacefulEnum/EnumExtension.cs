using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PeacefulEnum
{
    public static class EnumExtension
    {
        public static bool IsValid(this Enum enumeration)
        {
            if (enumeration == null)
            {
                return false;
            }

            if (Enum.IsDefined(enumeration.GetType(), enumeration))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsNullOrDefault(this Enum enumeration, int defaultEnumValue = 0)
        {
            if (enumeration == null || (Convert.ToInt32(enumeration) == defaultEnumValue))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Description(this Enum enumeration)
        {
            if(enumeration == null)
            {
                return string.Empty;
            }

            var enumFieldInfo = enumeration.GetType().GetField(enumeration.ToString());
            var customAttributes = enumFieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (customAttributes != null && customAttributes.Length > 0)
            {
                var description = ((DescriptionAttribute)customAttributes[0]).Description;
                return description;
            }

            return string.Empty;
        }
    }

}
