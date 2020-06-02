using Microsoft.Office.Interop.Excel;
using RetroFun.Controls;
using RetroFun.Subscribers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RetroFun
{
    public class GlobalInts
    {
        public static int OwnUser_index{ get; set; } = 0;
        public static int Selected_bubble_ID { get; set; } = 18;



        public static int RoomBackground_FurniID { get; set; } = 0;
        public static int RoomBackground_Tonality { get; set; } = 0;
        public static int RoomBackground_Saturation { get; set; } = 0;
        public static int RoomBackground_Light { get; set; } = 0;



        public static int ROOM_ID { get; set; } = 0;
    }
}

