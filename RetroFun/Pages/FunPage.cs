using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;

using Geode.Network;

using System.Threading;
using RetroFun.Subscribers;

using RetroFun.Helpers;
using System.Runtime.CompilerServices;
using RetroFun.Globals;
using System.Drawing;
using System.Text;
using System.IO;
using Geode.Habbo;
using Geode.Habbo.Packages;
using Sulakore.Components;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class FunPage : ObservablePage
    {
        private ColorDialog CD;
        private bool isLiveEnableEdit;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<HEntity> ConvertedUsersToPets { get => GlobalLists.ConvertedUsersToPets; set { GlobalLists.ConvertedUsersToPets = value; } }

        private bool isStaticEffectThreadStarted;
        private bool GiveEnableEffectToUser;
        private bool GiveAllUsersEnable;
        private bool RandomHeadTurnMode;
        private bool TransformAllUsersToPets = false;

        private readonly PetsIds[] _Pets = new[]
        {
                new PetsIds("Cat ", 1),
                new PetsIds("Crocodile ", 2),
                new PetsIds("Terrier ", 3),
                new PetsIds("Bear ", 4),
                new PetsIds("Pig ", 5),
                new PetsIds("Lion ", 6),
                new PetsIds("Rino ", 7),
                new PetsIds("Spider ", 8),
                new PetsIds("Turtle ", 9),
                new PetsIds("Chicken ", 10),
                new PetsIds("Frog ", 11),
                new PetsIds("Dragon ", 12),
                new PetsIds("Box ", 13),
                new PetsIds("Monkey ", 14),
                new PetsIds("Horse ", 15),
                new PetsIds("Monster Plant ", 16),
                new PetsIds("Bunny ", 17),
                new PetsIds("Bunny ", 18),
                new PetsIds("Bunny ", 19),
                new PetsIds("Bunny ", 20),
                new PetsIds("Chicken ", 21),
                new PetsIds("Chicken ", 22),
                new PetsIds("Monkey ", 23),
                new PetsIds("Little Bear ", 24),
                new PetsIds("Little Terrier ", 25),
                new PetsIds("Gnome ", 26),
                new PetsIds("Gnome ", 27),
                new PetsIds("Little Cat ", 28),
                new PetsIds("Little Dog ", 29),
                new PetsIds("Little Pig ", 30),
                new PetsIds("Gnome 2 ", 31),
                new PetsIds("Stone ", 32),
                new PetsIds("Pterodactyl ", 33),
                new PetsIds("Dino ", 34),
        };

        private bool isServerSideEffect = false;

        private int _EffectNumber = 0;
        public int EffectNumber
        {
            get => _EffectNumber;
            set
            {
                _EffectNumber = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _UseSelectedColor;
        public bool UseSelectedColor
        {
            get => _UseSelectedColor;
            set
            {
                _UseSelectedColor = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _tellWhatEnable;
        public bool tellWhatEnable
        {
            get => _tellWhatEnable;
            set
            {
                _tellWhatEnable = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _UseSelectedPet;
        public bool UseSelectedPet
        {
            get => _UseSelectedPet;
            set
            {
                _UseSelectedPet = value;
                RaiseOnPropertyChanged();
            }
        }
        private string _PetColor = "FFFFFF";
        public string PetColor
        {
            get => _PetColor;
            set
            {
                _PetColor = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _PetTypeID = 0;
        public int PetTypeID
        {
            get => _PetTypeID;
            set
            {
                _PetTypeID = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _PetID = 0;
        public int PetID
        {
            get => _PetID;
            set
            {
                _PetID = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _CooldownEffectLoop;

        public int CooldownEffectLoop
        {
            get => _CooldownEffectLoop;
            set
            {
                _CooldownEffectLoop = value;
                RaiseOnPropertyChanged();
            }
        }
        public FunPage()
        {
            InitializeComponent();
            KnownPetsCmbx.Items.AddRange(_Pets);
            KnownPetsCmbx.SelectedIndex = 0;

            CD = new ColorDialog();

            Bind(PetTypeIdNbx, "Value", nameof(PetTypeID));
            Bind(PetIdNbx, "Value", nameof(PetID));

            Bind(PetIDChbx, "Checked", nameof(UseSelectedPet));
            Bind(PetColorChbx, "Checked", nameof(UseSelectedColor));
            Bind(EnableTellerChbx, "Checked", nameof(tellWhatEnable));

            Bind(PetColorTxb, "Text", nameof(PetColor));

            Bind(EnableNbx, "Value", nameof(EffectNumber));
            Bind(CooldownEffectNbx, "Value", nameof(CooldownEffectLoop));
        }

        private void Speak(string text)
        {
            _ = SendToClient(In.RoomUserWhisper, 0, "[FUN]: " + text, 0, 34, 0, -1);
        }
        private void Speak(string text, int bubble)
        {
            _ = SendToClient(In.RoomUserWhisper, 0, "[FUN]: " + text, 0, bubble, 0, -1);
        }

        public override void In_RoomUsers(DataInterceptedEventArgs e)
        {
            if (TransformAllUsersToPets)
            {
                int petid = 0;
                int Pettypeid = 0;
                string petcolor = "";

                HEntity[] array = HEntity.Parse(e.Packet);
                foreach (HEntity entity in array)
                {
                    if (!ConvertedUsersToPets.Contains(entity))
                    {
                        ConvertedUsersToPets.Add(entity);
                    }
                }
                int num = e.Packet.ReadInt32(0);
                HMessage hmessage = new HMessage(In.RoomUsers, Array.Empty<object>());
                hmessage.WriteInteger(num);
                for (int i = 0; i < num; i++)
                {
                    Thread.Sleep(25);
                    if (!UseSelectedColor)
                    {
                        petcolor = string.Format("#{0:X6}", new Random().Next(16777216)).Substring(1);
                    }
                    else
                    {
                        petcolor = PetColor;
                    }
                    if (!UseSelectedPet)
                    {
                        petid = new Random().Next(1, 36);
                    }
                    else
                    {
                        petid = PetID;
                    }
                    hmessage.WriteInteger(array[i].Id);
                    hmessage.WriteString(array[i].Name);
                    hmessage.WriteString(array[i].Motto);
                    hmessage.WriteString(string.Concat(new object[]
                    {
                                petid,
                                " ",
                                PetTypeID,
                                " ",
                                petcolor
                    }));
                    hmessage.WriteInteger(array[i].Index);
                    hmessage.WriteInteger(array[i].Tile.X);
                    hmessage.WriteInteger(array[i].Tile.Y);
                    hmessage.WriteString("0.0");
                    hmessage.WriteInteger(0);
                    hmessage.WriteInteger(2);
                    hmessage.WriteInteger(0);
                    hmessage.WriteInteger(array[i].Id);
                    hmessage.WriteString(array[i].Name);
                    hmessage.WriteBoolean(false);
                    hmessage.WriteInteger(0);
                    hmessage.WriteInteger(0);
                    hmessage.WriteBoolean(false);
                    hmessage.WriteInteger(0);
                    hmessage.WriteString("std");
                }
                e.Packet = hmessage;
                DisableTransformAllUsers();
            }
        }

        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }

        public override void Out_RequestWearingBadges(DataInterceptedEventArgs e)
        {
            int Userid = e.Packet.ReadInt32();
            HEntity entity = HentityUtils.FindEntityByUserID(Userid);
            if (entity != null)
            {
                if (GiveEnableEffectToUser)
                {
                    AssignClientEffectToUser(entity, EffectNumber);
                }
            }
        }

        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            ConvertedUsersToPets.Clear();
        }

        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            ConvertedUsersToPets.Clear();
        }

        private async void SendServerEnableBobba(int effect)
        {
            if (KnownDomains.isBobbaHotel)
            {
                await Task.Delay(500);
                await SendToServer(Out.RoomUserTalk, ":enable " + effect, GlobalInts.Selected_bubble_ID);
            }
            else if (KnownDomains.isHartico)
            {
                await Task.Delay(500);
                await SendToServer(Out.RoomUserTalk, ":enable " + effect, GlobalInts.Selected_bubble_ID);
            }
            else if (KnownDomains.isBSSHotel)
            {
                await Task.Delay(500);
                await SendToServer(Out.RoomUserTalk, ":enable " + effect, GlobalInts.Selected_bubble_ID);
            }
            else if (KnownDomains.UnknownHost)
            {
                await Task.Delay(500);
                await SendToServer(Out.RoomUserTalk, ":enable " + effect, GlobalInts.Selected_bubble_ID);
            }
        }

        private async void AssignClientEffectToMyself(int Effect)
        {
            await SendToClient(In.RoomUserEffect, GlobalInts.OwnUser_index, Effect, 0);
        }

        private async void AssignClientEffectToUser(HEntity Entity, int Effect)
        {
            if (Entity != null)
            {
                await SendToClient(In.RoomUserEffect, Entity.Index, Effect, 0);
            }
        }

        private void RemoveEntityFromRoom(HEntity entity)
        {
            _ = SendToClient(In.RoomUserRemove, entity.Index);
        }

        private void DisableTransformAllUsers()
        {
            TransformAllUsersToPets = false;
            WriteToButton(TransformAllUserIntoPetsBtn, "Transform All users In Pets : OFF");
        }

        private void GiveAllEffectsToUsers(int effect)
        {
            try
            {
                if (GlobalLists.UsersInRoom.Count != 0 && GlobalLists.UsersInRoom != null)
                {
                    foreach (HEntity user in GlobalLists.UsersInRoom)
                    {
                        Thread.Sleep(50);
                        AssignClientEffectToUser(user, effect);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void SetPetColorBtn_Click(object sender, EventArgs e)
        {
            CD.ShowDialog();
            Color color = CD.Color;
            PetColor = color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
        }

        private void LiveEditBtn_Click(object sender, EventArgs e)
        {
            if (isLiveEnableEdit)
            {
                WriteToButton(LiveEditBtn, "Live Edit : OFF");
                isLiveEnableEdit = false;
            }
            else
            {
                WriteToButton(LiveEditBtn, "Live Edit : ON");
                isLiveEnableEdit = true;
            }
        }
        private void StartStaticEffectThread()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (isStaticEffectThreadStarted)
                        {
                            if (isServerSideEffect)
                            {

                                SendServerEnableBobba(EffectNumber);
                                Thread.Sleep(CooldownEffectLoop);
                                SendServerEnableBobba(0);
                            }
                            else
                            {
                                AssignClientEffectToMyself(EffectNumber);
                                Thread.Sleep(CooldownEffectLoop);
                                AssignClientEffectToMyself(0);
                            }
                        }
                    }
                    catch (Exception e)
                    {

                    }

                } while (isStaticEffectThreadStarted);
            }).Start();
        }

        private void EnableOnLoopBtn_Click(object sender, EventArgs e)
        {
            if (isStaticEffectThreadStarted)
            {
                WriteToButton(EnableOnLoopBtn, "Enable Effect On loop : OFF");
                isStaticEffectThreadStarted = false;
            }
            else
            {
                WriteToButton(EnableOnLoopBtn, "Enable Effect On loop : ON");
                isStaticEffectThreadStarted = true;
                StartStaticEffectThread();
            }
        }

        private void EnableNbx_ValueChanged(object sender, EventArgs e)
        {
            if (GiveAllUsersEnable)
            {
                GiveAllUsersEffect();
            }

            if (isLiveEnableEdit && isServerSideEffect)
            {
                SendServerEnableBobba(EffectNumber);
                return;
            }
            else if (isLiveEnableEdit)
            {
                AssignClientEffectToMyself(EffectNumber);
                return;
            }
        }

        private void EnableSub1Btn_Click(object sender, EventArgs e)
        {
            EffectNumber--;
            if (isLiveEnableEdit && isServerSideEffect)
            {
                SendServerEnableBobba(EffectNumber);
                return;
            }
            else if (isLiveEnableEdit)
            {
                AssignClientEffectToMyself(EffectNumber);
                return;
            }
        }

        private void EnableAdd1Btn_Click(object sender, EventArgs e)
        {
            EffectNumber++;
            if (isLiveEnableEdit && isServerSideEffect)
            {
                SendServerEnableBobba(EffectNumber);
                return;
            }
            else if (isLiveEnableEdit)
            {
                AssignClientEffectToMyself(EffectNumber);
                return;
            }
        }

        private void SetEnableBtn_Click(object sender, EventArgs e)
        {
            if (isServerSideEffect)
            {
                SendServerEnableBobba(EffectNumber);
            }
            else
            {
                AssignClientEffectToMyself(EffectNumber);
            }
        }

        private void IsServerSideBtn_Click(object sender, EventArgs e)
        {

            if (isServerSideEffect)
            {
                WriteToButton(IsServerSideBtn, "Server Side : OFF");
                isServerSideEffect = false;
            }
            else
            {
                WriteToButton(IsServerSideBtn, "Server Side : ON");
                isServerSideEffect = true;
            }
        }

        private void GiveEffectToAllUsersBtn_Click(object sender, EventArgs e)
        {
            GiveAllEffectsToUsers(EffectNumber);
        }

        public override void Out_RequestPetInfo(DataInterceptedEventArgs e)
        {
            int userid = e.Packet.ReadInt32();
            if (HentityUtils.FindConvertedUserToPetByID(userid) != null)
            {
                ReplaceUserPacketInfo(userid);
                e.IsBlocked = true;
            }
        }

        private async void ReplaceUserPacketInfo(int userid)
        {
            await SendToServer(Out.RequestWearingBadges, userid);
            await Task.Delay(150);
            await SendToServer(Out.RequestProfileFriends, userid);

        }

        private void SetEffectToClickedUserbtn_Click(object sender, EventArgs e)
        {
            if (GiveEnableEffectToUser)
            {
                WriteToButton(SetEffectToClickedUserbtn, "Give Effect To Clicked User : OFF");
                GiveEnableEffectToUser = false;
            }
            else
            {
                WriteToButton(SetEffectToClickedUserbtn, "Give Effect To Clicked User : ON");
                GiveEnableEffectToUser = true;
            }
        }

        private class PetsIds
        {
            public string Name { get; }

            public int ID { get; }

            public PetsIds(string name, int id)
            {
                Name = name;
                ID = id;
            }

            public override string ToString() => $"{Name} [ID: {ID}]";
        }

        private void TransformAllUserIntoPetsBtn_Click(object sender, EventArgs e)
        {
            if (TransformAllUsersToPets)
            {
                WriteToButton(TransformAllUserIntoPetsBtn, "Transform All users In Pets : OFF");
                TransformAllUsersToPets = false;
            }
            else
            {
                WriteToButton(TransformAllUserIntoPetsBtn, "Transform All users In Pets : ON");
                TransformAllUsersToPets = true;
                Speak("Re-enter the room to convert all users to pets!");
            }
        }

        private void KnownPetsCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            PetID = ((PetsIds)KnownPetsCmbx.SelectedItem).ID;
        }

        private void RestoreUsersBtn_Click(object sender, EventArgs e)
        {
            if (ConvertedUsersToPets.Count != 0 && ConvertedUsersToPets != null)
            {
                foreach (HEntity user in ConvertedUsersToPets)
                {
                    Thread.Sleep(50);
                    RemoveEntityFromRoom(user);
                }
                _ = SendToClient(HentityUtils.PacketBuilder(ConvertedUsersToPets, In.Users));
                ConvertedUsersToPets.Clear();
            }
        }

        private void GiveAllEffectToUserBtn_Click(object sender, EventArgs e)
        {
            if (GiveAllUsersEnable)
            {
                GiveAllUsersEnable = false;
                WriteToButton(GiveAllEffectToUserBtn, "Give Effect To All Users  : OFF");
            }
            else
            {
                WriteToButton(GiveAllEffectToUserBtn, "Give Effect To All Users  : ON");
                GiveAllUsersEnable = true;
            }

        }

        private void GiveAllUsersEffect()
        {
            if (GlobalLists.UsersInRoom.Count != 0 && GlobalLists.UsersInRoom != null)
            {
                foreach (HEntity user in GlobalLists.UsersInRoom)
                {
                    AssignClientEffectToUser(user, EffectNumber);
                }
            }
        }

        public override void In_RoomUserEffect(DataInterceptedEventArgs e)
        {
            int UserIndex = e.Packet.ReadInt32();
            int enableeffect = e.Packet.ReadInt32();
            if (tellWhatEnable)
            {
                Speak(HentityUtils.FindEntityByIndex(UserIndex).Name + " is using this effect : " + enableeffect);
                EffectNumber = enableeffect;
            }
        }

        private void RandomHeadTurn()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        SendLookAtPoint(1000, -10000);   //NE
                        Thread.Sleep(100);
                        SendLookAtPoint(10000, -1000);   //E
                        Thread.Sleep(150);
                        SendLookAtPoint(10000, 1000);   //SE
                        Thread.Sleep(200);
                        SendLookAtPoint(1000, 10000);   //S
                        Thread.Sleep(250);
                        SendLookAtPoint(-1000, 10000);   //SW
                        Thread.Sleep(300);
                        SendLookAtPoint(-10000, 1000);   //W
                        Thread.Sleep(350);
                        SendLookAtPoint(-10000, -1000);   //NW
                        Thread.Sleep(400);
                        SendLookAtPoint(-1000, -10000);   //N

                    }
                    catch (Exception e)
                    {

                    }
                } while (RandomHeadTurnMode);

            }).Start();
        }

        private void SendLookAtPoint(int one, int two)
        {
            if (RandomHeadTurnMode)
            {
                _ = SendToServer(Out.LookTo, one, two);
            }
        }
        private void HeadturnBtn_Click(object sender, EventArgs e)
        {
            if (RandomHeadTurnMode)
            {
                WriteToButton(HeadturnBtn, "Random Head Turn : OFF");
                RandomHeadTurnMode = false;
            }
            else
            {
                WriteToButton(HeadturnBtn, "Random Head Turn : ON");
                RandomHeadTurnMode = true;
                RandomHeadTurn();
            }
        }
    }
}
