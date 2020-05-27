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
                return bobbaitalia;
            }
            else if (host == "192.95.19.75")
            {
                return hartico;
            }
            else
            {
                return host;
            }
        }


        public static readonly string bobbaitalia = "bobbaitalia.it";

        public static readonly string hartico = "hartico.com";

    }
}
