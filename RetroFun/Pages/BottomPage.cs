using Microsoft.Office.Interop.Excel;
using RetroFun.Globals;
using RetroFun.Helpers;
using RetroFun.Subscribers;
using RetroFun.Utils.Globals;
using Sulakore.Communication;
using Sulakore.Habbo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class BottomPage:  ObservablePage
    {

        private Dictionary<int, HEntity> Dictionaryusers { get => GlobalDictionaries.Dictionary_UsersPresentInRoom; set { GlobalDictionaries.Dictionary_UsersPresentInRoom = value; } }
        private Dictionary<string, HEntity> removedEntities { get => GlobalDictionaries.removedEntities; set { GlobalDictionaries.removedEntities = value; } }
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<HEntity> CurrentRoomUsers { get => GlobalLists.UsersInRoom; set { GlobalLists.UsersInRoom = value; RaiseOnPropertyChanged(); } }
        public string Own_look { get => GlobalStrings.UserDetails_Look; set { GlobalStrings.UserDetails_Look = value; RaiseOnPropertyChanged(); } }

        public int Own_index { get => GlobalInts.OwnUser_index; set { GlobalInts.OwnUser_index = value; RaiseOnPropertyChanged(); } }


        public bool FreezeUser
        {
            get => Global_bools.FreezeUserMovement;
            set
            {
                Global_bools.FreezeUserMovement = value;
                RaiseOnPropertyChanged();
            }
        }

        public string OwnUsername { get => GlobalStrings.UserDetails_Username; set { GlobalStrings.UserDetails_Username = value; RaiseOnPropertyChanged(); } }


        public BottomPage()
        {
            InitializeComponent();

            Bind(FreezeMovementCheck, "Checked", nameof(FreezeUser));
            Bind(UsernameTextBox, "Text", nameof(OwnUsername));
        }

        private void Speak(string text)
        {
                SendToClient(In.RoomUserWhisper, 0, "[RetroFun Init]: " + text, 0, 34, 0, -1);
        }


        public override async void Out_LatencyTest(DataInterceptedEventArgs obj)
        {
            if (OwnUsername == null)
            {
                    await AwaitSendToServer(Out.RequestUserData);
            }
            if (!KnownDomains.isDomainRecognized)
            {
                KnownDomains.RecognizeHostBool(Connection.Host);
                if (KnownDomains.isAKnownHost(Connection.Host))
                {
                    Speak("This is a Known host : " + KnownDomains.GetHostName(Connection.Host));
                    Speak("Setting RetroFun for this known host!");
                }
                else
                {
                    Speak("Setting RetroFun for Unknown Host!");
                    Speak("Some features won't work here Server-side, please contact the developer on discord in case there's a problem with this host : " + GlobalStrings.DeveloperDiscord);
                }
         }
            UpdateMainFrmTitle();
        }

        public override void Out_Username(DataInterceptedEventArgs obj)
        {
            string username = obj.Packet.ReadString();

            if (OwnUsername == null)
            {
                OwnUsername = username;
                UpdateMainFrmTitle();
            }
        }


        public override void In_RoomUsers(DataInterceptedEventArgs obj)
        {
                    HEntity[] array = HEntity.Parse(obj.Packet);
                    if (array.Length != 0)
                    {
                        foreach (HEntity hentity in array)
                        {
                            if (!Dictionaryusers.ContainsKey(hentity.Id))
                            {
                                Dictionaryusers.Add(hentity.Id, hentity);
                            }
                            if (!CurrentRoomUsers.Contains(hentity))
                            {
                                CurrentRoomUsers.Add(hentity);
                            }
                            if (OwnUsername != null)
                            {
                                if (hentity.Name == OwnUsername)
                                {
                                    Own_index = hentity.Index;
                                    Own_look = hentity.FigureId;
                                }
                            }
                        }
                    }


            UpdateUsersInRoom();
        }



        private void UpdateUsersInRoom()
        {
            Invoke((MethodInvoker)delegate
            {
                UsersInRoomLbl.Text = "Users In Room : " + CurrentRoomUsers.Count;
            });
        }


        private void UpdateMainFrmTitle()
        {
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    if (MainFrm.ActiveForm != null)
                    {
                        MainFrm.ActiveForm.Text = "RetroFun  [Host : " + KnownDomains.GetHostName(Connection.Host) + " ]" +
                        "  " +
                        "[IsKnownHost : " + KnownDomains.isAKnownHost(Connection.Host).ToString() + " ]" +
                        "  " +
                        "[Username : " + OwnUsername + " ]";
                    }
                });
            }
            catch (Exception) { }
        }


        public  override void In_RoomUserRemove(DataInterceptedEventArgs e)
        {
            int index = int.Parse(e.Packet.ReadString());
            var entity1 = HentityUtils.FindEntityByIndex(index);
            var entity2 = HentityUtils.FindEntityByIndexDictionary(index);
            if (entity1 != null)
            {
                CurrentRoomUsers.Remove(entity1);
            }
            if (entity2 != null)
            {
                Dictionaryusers.Remove(entity2.Id);
            }
            UpdateUsersInRoom();
        }


        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            Dictionaryusers.Clear();
            removedEntities.Clear();
            CurrentRoomUsers.Clear();
            UpdateUsersInRoom();
        }

        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            Dictionaryusers.Clear();
            removedEntities.Clear();
            CurrentRoomUsers.Clear();
            UpdateUsersInRoom();


        }
        public override void Out_RoomUserWalk(DataInterceptedEventArgs e)
        {
            if(FreezeUser)
            {
                e.IsBlocked = true;
            }
        }
    }
}
