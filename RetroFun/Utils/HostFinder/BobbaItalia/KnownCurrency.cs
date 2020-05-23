using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.HostFinder.BobbaItalia
{
    public class KnownCurrency
    {

        public static readonly List<int> Bobba_CrystalCambio = new List<int> { 5193, 5197, 5196, 5195, 5194 };
        public static readonly List<int> Bobba_BoBBaCambio = new List<int> { 2522, 2525, 2067, 2066, 2065, 2064, 2063, 2521, 2524 };

        public static bool isCrystals(HFloorItem furni)
        {
            if(Bobba_CrystalCambio.Contains(furni.TypeId))
            {
                return true;
            }
            return false;
        }

        public static bool isCredits(HFloorItem furni)
        {
            if (Bobba_BoBBaCambio.Contains(furni.TypeId))
            {
                return true;
            }
            return false;
        }


    }
}
