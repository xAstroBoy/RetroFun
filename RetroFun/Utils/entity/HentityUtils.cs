using RetroFun.Globals;
using RetroFun.Utils.Globals;
using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RetroFun
{
    public class HentityUtils
    {

        public static HEntity FindEntityByIndex(int index)
        {
            return  GlobalLists.UsersInRoom.Find(f => f.Index == index);
        }

        public static HEntity FindEntityByUserID(int userid)
        {
            return  GlobalLists.UsersInRoom.Find(f => f.Id == userid);
        }

        public static HEntity FindEntityByUsername(string name)
        {
            return GlobalLists.UsersInRoom.Find(f => f.Name == name);
        }

        public static string FindUsernameByEntity(HEntity entity)
        {
            if (entity != null)
            {
                return entity.Name;
            }
            else
            {
                return null;
            }
        }

        public static int FindUserIndexByUsername(string username)
        {
            if (!String.IsNullOrEmpty(username))
            {
                if (GlobalLists.UsersInRoom.Count != 0)
                {
                    return GlobalLists.UsersInRoom.Find(e => e.Name == username).Index;
                }
            }
            return 0;
        }

        public static HEntity FindEntityByIndexDictionary(int index)
        {
            var entity = GlobalDictionaries.Dictionary_UsersPresentInRoom.Values.FirstOrDefault(ent => ent.Index == index);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }

    }
}
