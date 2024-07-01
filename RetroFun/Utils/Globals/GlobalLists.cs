using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun.Globals
{
    public class GlobalLists
    {
        public class EntityWhisper 
        {
            public HEntity entity; 
            public int bubbleid = 0;

            public EntityWhisper(HEntity ent, int bubble)
            {
                entity = ent;
                bubbleid = bubble;
            }
        }

        public class FurniTypeIDFixer
        {
            public HFloorItem FloorFurni;
            public int originalTypeID = 0;
            public double Z { get; set; }

            public FurniTypeIDFixer(HFloorItem furni, int OriginalTypeID, double originalZ)
            {
                FloorFurni = furni;
                originalTypeID = OriginalTypeID;
                Z = originalZ;
            }
        }

        public static List<EntityWhisper> whisperfix = new List<EntityWhisper>();
        public static List<FurniTypeIDFixer> furnifix = new List<FurniTypeIDFixer>();

        public static List<HEntity> UsersInRoom = new List<HEntity>();
        public static List<HEntity> ConvertedUsersToPets = new List<HEntity>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public static List<HEntity> UserLeftRoom = new List<HEntity>();


        public static readonly List<int> BobbaParticularRares = new List<int> { 2757, 3014, 2734, 3055, 1967, 1966, 1738, 2969, 2975, 1977, 1764, 1979, 285, 2520, 3896, 1980, 4542, 285, 1971, 3191, 2374, 285, 3191, 285, 3091 };
    }


}
