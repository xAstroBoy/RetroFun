
using Geode.Habbo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Utils.Chatlogger
{
    public enum HChatRecordType : byte
    {
        Default = 0,
        Room,
        Messenger,
        DiscussionThread,
        DiscussionMessage,
        Selfie,
        Photo
    }

    public class HChatlineData
    {
        public string Timestamp { get; set; }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
        public bool IsHighlighted { get; set; }

        public HChatlineData(HMessage packet)
        {
            Timestamp = packet.ReadUTF8();
            Id = packet.ReadInt32();
            Username = packet.ReadUTF8();
            Message = packet.ReadUTF8();
            IsHighlighted = packet.ReadBoolean();
        }
    }
    public class HChatRecordData
    {
        public HChatRecordType Type { get; set; }

        public Dictionary<string, object> Context { get; set; }
        public List<HChatlineData> Chatlogs { get; set; }

        public HChatRecordData(HMessage packet)
        {
            object ReadContextValue(HMessage anotherMessage)
            {
                switch (anotherMessage.ReadShort())
                {
                    case 0: return anotherMessage.ReadBoolean();
                    case 1: return anotherMessage.ReadInt32();
                    case 2: return anotherMessage.ReadUTF8();
                    default: throw new System.Exception("Nothing");
                }
            }

            Type = (HChatRecordType)packet.ReadBytes(1)[0];
            int entryCount = packet.ReadShort();

            Context = new Dictionary<string, object>(entryCount);
            for (int i = 0; i < entryCount; i++)
            {
                Context.Add(packet.ReadUTF8(), ReadContextValue(packet));
            }

            Chatlogs = new List<HChatlineData>(packet.ReadShort());
            for (int i = 0; i < Chatlogs.Capacity; i++)
            {
                Chatlogs.Add(new HChatlineData(packet));
            }
        }

        public int? RoomId => Context["roomId"] as int?;
        public string RoomName => Context["roomName"] as string;
        //groupId, threadId, messageId
    }
}
