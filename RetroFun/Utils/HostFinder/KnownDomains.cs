using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace RetroFun.Helpers
{
    public static class KnownDomains
    {
        public static string GetHostName(string host)
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

        public static void RecognizeHostBool(string host)
        {
            if (!isDomainRecognized)
            {
                if (host == "217.182.58.18")
                {
                    isHartico = false;
                    isBobbaHotel = true;
                    UnknownHost = false;
                    isDomainRecognized = true;
                }
                else if (host == "192.95.19.75")
                {
                    isBobbaHotel = false;
                    isHartico = true;
                    UnknownHost = false;
                    isDomainRecognized = true;
                }
                else
                {
                    isBobbaHotel = false;
                    isHartico = false;
                    UnknownHost = true;
                    isDomainRecognized = true;
                }
            }
            return;
        }

        public static bool isAKnownHost(string host)
        {
            if(GetHostName(host) == bobbaitalia)
            {
                return true;
            }
            else if(GetHostName(host) == hartico)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static readonly string bobbaitalia = "bobbaitalia.it";

        public static readonly string hartico = "hartico.com";

        private static bool _isHartico = false;
        public static bool isHartico
        {
            get => _isHartico;
            set
            {
                if (!isDomainRecognized)
                {
                    _isHartico = value;
                }
            }
        }

        private static bool _isBobbaHotel = false;
        public static bool isBobbaHotel
        {
            get => _isBobbaHotel;
            set
            {
                if (!isDomainRecognized)
                {
                    _isBobbaHotel = value;
                }
            }
        }


        private static bool _UnknownHost = false;
        public static bool UnknownHost
        {
            get => _UnknownHost;
            set
            {
                if (!isDomainRecognized)
                {
                    _UnknownHost = value;
                }
            }
        }

        private static bool _isDomainRecognized = false;
        public static bool isDomainRecognized
        {
            get => _isDomainRecognized;
            set
            {
                if (!isDomainRecognized)
                {
                    _isDomainRecognized = value;
                }
            }
        }




    }
}
