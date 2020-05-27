using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Helpers
{
    public static class KnownDomains
    {
        public static string GetHost(string host)
        {
                if (host == "217.182.58.18")
                {
                    isBobbaHotel = true;
                    return bobbaitalia;
                }
                else if (host == "192.95.19.75")
                {
                    isHartico = true;
                    return hartico;
                }
                else
                {
                    UnknownHost = true;
                    return host;
                }
        }


        public static readonly string bobbaitalia = "bobbaitalia.it";

        public static readonly string hartico = "hartico.com";

        public static bool isHartico { get; set; } = false;

        public static bool isBobbaHotel { get; set; } = false;
        public static bool UnknownHost { get; set; } = false;

        public static bool isDomainRecognized { get; set; } = false;

    }
}
