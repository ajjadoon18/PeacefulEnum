using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PeacefulEnum
{
    public static class EnumExtension
    {
        public static bool IsEnumValid(this Enum enumeration)
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

        public static bool IsEnumNullOrDefault(this Enum enumeration, int defaultEnumValue = 0)
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
    }

}
