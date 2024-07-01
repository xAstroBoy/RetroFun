using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.Globals
{
    public class GlobalDictionaries
    {
        public static Dictionary<string, HEntity> removedEntities = new Dictionary<string, HEntity>();


        public static Dictionary<int, HEntity> Dictionary_UsersPresentInRoom = new Dictionary<int, HEntity>();
        
        public static Dictionary<string, bool> blacklistedEntities = new Dictionary<string, bool>();

        public static Dictionary<int, string> pagenames = new Dictionary<int, string>();


    }
}
