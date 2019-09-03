using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Globalization;
using System.ComponentModel;

using BobbaFun.Controls;
using BobbaFun.Properties;

using Sulakore.Protocol;
using Sulakore.Communication;
using System.Collections.Generic;
using System.Resources;
using System.Linq;


namespace BobbaFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class ChatPage : ObservablePage
    {



        //private bool _antiBobbaFilter;
        //public bool AntiBobbaFilter
        //{
        //    get => _antiBobbaFilter;
        //    set
        //    {
        //        _antiBobbaFilter = value;
        //        RaiseOnPropertyChanged();
        //    }
        //}

        //private bool _useSelectedBubble;
        //public bool UseSelectedBubble
        //{
        //    get => _useSelectedBubble;
        //    set
        //    {
        //        _useSelectedBubble = value;
        //        RaiseOnPropertyChanged();
        //    }
        //}

        //private bool _hideSpeakingBubble;
        //public bool HideSpeakingBubble
        //{
        //    get => _hideSpeakingBubble;
        //    set
        //    {
        //        _hideSpeakingBubble = value;
        //        RaiseOnPropertyChanged();
        //    }
        


        public DicePage()
        {
            InitializeComponent();

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomUserTalk, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserShout, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserWhisper, RoomUserStartSpeaking);
                Triggers.OutAttach(Out.RoomUserStartTyping, RoomUserStartTyping);
            }
        }
















    }
}