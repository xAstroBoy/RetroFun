using Microsoft.Office.Interop.Excel;
using RetroFun.Globals;
using RetroFun.Utils.Globals;
using Geode.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Geode.Habbo;
using Geode.Habbo.Packages;

namespace RetroFun
{
    public class HentityUtils
    {

        public static HEntity FindEntityByIndex(int index)
        {
            return GlobalLists.UsersInRoom.Find(f => f.Index == index);
        }

        public static HEntity FindLeftUserByIndex(int index)
        {
            return GlobalLists.UserLeftRoom.Find(f => f.Index == index);
        }

        public static HEntity FindEntityByUserID(int userid)
        {
            return GlobalLists.UsersInRoom.Find(f => f.Id == userid);
        }

        public static HEntity FindConvertedUserToPetByID(int userid)
        {
            return GlobalLists.ConvertedUsersToPets.Find(f => f.Id == userid);
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

        public static int WhisperFixerInt(HEntity ent)
        {
            if (GlobalLists.whisperfix.Find(f => f.entity == ent) != null)
            {
                return GlobalLists.whisperfix.Find(f => f.entity == ent).bubbleid;
            }
            else
            {
                return 18;
            }
        }

        public static GlobalLists.EntityWhisper WhisperEntityFix(int index)
        {
            try
            {
                if (GlobalLists.whisperfix != null || GlobalLists.whisperfix.Count != 0)
                {
                    var entity = GlobalLists.whisperfix.First(ent => ent.entity.Index == index);
                    if (entity != null)
                    {
                        return entity;
                    }
                    else
                    {
                        return null;
                    }
                }
                return null;
            }
            catch (InvalidOperationException)
            { return null; }
        }

        public static HMessage PacketBuilder(IList<HEntity> Users, ushort header)
        {
            var ret = new HMessage(header);
            ret.WriteInteger(Users.Count());

            foreach (var obj in Users)
            {
                ret.WriteInteger(obj.Id);
                ret.WriteInteger(obj.Index);
                ret.WriteInteger(obj.Tile.X);
                ret.WriteInteger(obj.Tile.Y);
                ret.WriteInteger(0);
                ret.WriteString(obj.Name);
                ret.WriteString(obj.Motto);
                ret.WriteInteger((int)obj.Gender);
                ret.WriteInteger(obj.EntityType);
                ret.WriteString(obj.FigureId);
                ret.WriteString(obj.FavoriteGroup);
                return ret;
            }
            return null;
        }

        public static HMessage MakeEntity(int Id, int Index, int X, int Y, int Z, string name, string motto, HGender gender, int entitytype, string figureid, string FavouriteGroup, ushort header)
        {
            var ret = new HMessage(header);
            ret.WriteInteger(1);
            ret.WriteInteger(Id);
            ret.WriteInteger(Index);
            ret.WriteInteger(X);
            ret.WriteInteger(Y);
            ret.WriteInteger(Z);
            ret.WriteString(name);
            ret.WriteString(motto);
            ret.WriteInteger((int)gender);
            ret.WriteInteger(entitytype);
            ret.WriteString(figureid);
            ret.WriteString(FavouriteGroup);
            return ret;
        }

        public static HMessage TurnEntityToPet(HEntity entity, int petid, int pettypeid, string petcolor, ushort header)
        {
            var ret = new HMessage(header);
            ret.WriteInteger(1);
            ret.WriteInteger(entity.Id);
            ret.WriteString(entity.Name);
            ret.WriteString(entity.Motto);
            ret.WriteString(string.Concat(new object[]
            {
                                petid,
                                " ",
                                pettypeid,
                                " ",
                                petcolor
            }));
            ret.WriteInteger(entity.Index);
            ret.WriteInteger(entity.Tile.X);
            ret.WriteInteger(entity.Tile.Y);
            ret.WriteString("0.0");
            ret.WriteInteger(0);
            ret.WriteInteger(2);
            ret.WriteInteger(0);
            ret.WriteInteger(entity.Id);
            ret.WriteString(entity.Name);
            ret.WriteBoolean(false);
            ret.WriteInteger(0);
            ret.WriteInteger(0);
            ret.WriteBoolean(false);
            ret.WriteInteger(0);
            ret.WriteString("std");
            return ret;
        }

    }
}
