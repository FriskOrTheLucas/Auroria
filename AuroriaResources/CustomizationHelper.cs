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
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetHat1) || ClientSettings.Appearance.SupportsAccessory == false)
                {
                    return "";
                }
                else if (ClientSettings.Ability.WillDieOnRedirect)
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetHat1}";
                }
                else
                {
                    return "_" + PlayerSettings.GetHat1;
                }
            }
        }

        public static string AvatarHat2
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetHat2) || ClientSettings.Appearance.SupportsAccessory == false)
                {
                    return "";
                }
                else if (ClientSettings.Ability.WillDieOnRedirect)
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetHat2}";
                }
                else
                {
                    return "_" + PlayerSettings.GetHat2;
                }
            }
        }

        public static string AvatarHat3
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetHat3) || ClientSettings.Appearance.SupportsAccessory == false)
                {
                    return "";
                }
                else if (ClientSettings.Ability.WillDieOnRedirect)
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetHat3}";
                }
                else
                {
                    return "_" + PlayerSettings.GetHat3;
                }
            }
        }

        public static string Shirt
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetShirt) || ClientSettings.Appearance.SupportsShirts == false)
                {
                    return "";
                }
                else if (ClientSettings.Ability.WillDieOnRedirect)
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetShirt}";
                }
                else
                {
                    return "_" + PlayerSettings.GetShirt;
                }
            }
        }

        public static string Tshirt
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetTShirt) || ClientSettings.Appearance.SupportsTShirts == false)
                {
                    return "";
                }
                else if (ClientSettings.Ability.WillDieOnRedirect)
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetTShirt}";
                }
                else
                {
                    return "_" + PlayerSettings.GetTShirt;
                }
            }
        }

        public static string Pants
        {
            get
            {
                if (string.IsNullOrWhiteSpace(PlayerSettings.GetPants) || ClientSettings.Appearance.SupportsPants == false)
                {
                    return "";
                }
                else if (ClientSettings.Ability.WillDieOnRedirect)
                {
                    return $";http://www.roblox.com/asset/?id={PlayerSettings.GetPants}";
                }
                else
                {
                    return "_" + PlayerSettings.GetPants;
                }
            }
        }
    }
}
