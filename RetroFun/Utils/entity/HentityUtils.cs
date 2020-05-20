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
            var entity = GlobalLists.UsersInRoom.Find(f => f.Index == index);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }

        public static HEntity FindEntityByUserID(int userid)
        {
            var entity = GlobalLists.UsersInRoom.Find(f => f.Index == userid);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }

        public static HEntity FindEntityByUsername(string name)
        {
            var entity = GlobalLists.UsersInRoom.Find(f => f.Name == name);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                return null;
            }
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
