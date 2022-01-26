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
            if (host == bobbaitaliaip)
            {
                return bobbaitalia;
            }
            else if (host == bssip)
            {
                return bss;
            }
            else if (host == harticoip)
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
                if (host == bobbaitaliaip)
                {
                    isBobbaHotel = true;
                    isBSSHotel = false;
                    isHartico = false;
                    UnknownHost = false;
                    isDomainRecognized = true;
                }
                else if (host == bssip)
                {
                    isBobbaHotel = false;
                    isBSSHotel = true;
                    isHartico = false;
                    UnknownHost = false;
                    isDomainRecognized = true;
                }
                else if (host == harticoip)
                {
                    isBobbaHotel = false;
                    isBSSHotel = false;
                    isHartico = true;
                    UnknownHost = false;
                    isDomainRecognized = true;
                }
                else
                {
                    isBobbaHotel = false;
                    isBSSHotel = false;
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
            else if (GetHostName(host) == bss)
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

        public static readonly string bss = "bsshotel.it";





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

        private static bool _isBSSHotel = false;
        public static bool isBSSHotel
        {
            get => _isBSSHotel;
            set
            {
                if (!isDomainRecognized)
                {
                    _isBSSHotel = value;
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


        public static readonly string bobbaitaliaip = "217.182.58.18";
        public static readonly string bssip = "217.182.58.17";
        public static readonly string harticoip = "192.95.19.75";


    }
}
