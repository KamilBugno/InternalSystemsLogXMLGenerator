using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    static class ConstantData
    {
        public static int startKey = 1;
        public static string system_key = "1";
        public static string person_key = "1";
        public static string[] action_type = {"successful login", "login failed", "change password", "change email", "logout" };
        public static string[] browser = {"Chrome", "Firefox", "Internet Explorer", "Safari", "Opera"};
        public static string[] chromeVersion = { "64.0.3282.119", "64.0.3282.123", "64.0.3282.112" };
        public static string[] firefoxVersion = { "58.0.1", "52.6.0" };
        public static string[] ieVersion = { "11.0.49", "9.0.8112.16421", "5.00.2013.1312" };
        public static string[] safariVersion = { "11.0.3", "10.1.2", "9.1.3" };
        public static string[] operaVersion = { "12.15", "12.13", "11.64" };


        public static Dictionary<string, string[]> browserVersion = new Dictionary<string, string[]>()
        {
            {"Chrome", chromeVersion},
            {"Firefox", firefoxVersion},
            {"Internet Explorer", ieVersion},
            {"Safari", safariVersion},
            {"Opera", operaVersion}
        };
    }
}
