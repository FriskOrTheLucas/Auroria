using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AuroriaResources
{
    public static class CustomizationHelper
    {
        public static string AvatarHat1
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetHat1))
                {
                    return "";
                }
                else
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetHat1}";
                }
            }
        }

        public static string AvatarHat2
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetHat2))
                {
                    return "";
                }
                else
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetHat2}";
                }
            }
        }

        public static string AvatarHat3
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetHat3))
                {
                    return "";
                }
                else
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetHat3}";
                }
            }
        }
    }
}
