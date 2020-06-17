using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Components;
using System.IO;
using RetroFun.Subscribers;
using RetroFun.Helpers;
using RetroFun.Globals;

namespace RetroFun.Pages
{

    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class ModerationPage : ObservablePage
    {
        private int _selectedUserId;
        private bool newroom = true;
        public int Bubbleused { get => GlobalInts.Selected_bubble_ID; set { GlobalInts.Selected_bubble_ID = value; RaiseOnPropertyChanged(); } }
        public List<HEntity> UserLeftRoom { get => GlobalLists.UserLeftRoom; set { GlobalLists.UserLeftRoom = value; RaiseOnPropertyChanged(); } }


        private RegisteredUsers[] registeredUsers;
        private readonly BanTime[] _BanTime = new[]
        {
            new BanTime(3600, "1 ora"),
            new BanTime(7200, "2 ore,"),
            new BanTime(10800, "3 ore"),
            new BanTime(14400, "4 ore"),
            new BanTime(43200, "12 ore"),
            new BanTime(86400, "1 giorno"),
            new BanTime(259200, "3 giorni"),
            new BanTime(604800, "1 settimana"),
            new BanTime(1209600, "2 settimane"),
            new BanTime(2592000, "1 mese"),
            new BanTime(7776000, "3 mesi"),
            new BanTime(1314000, "1 anno"),
            new BanTime(2628000, "2 anni"),
            new BanTime(360000000, "10 anni"),

        };

        private readonly MuteTime[] _MuteTime = new[]
{
            new MuteTime(60, "1 minuto"),
            new MuteTime(300, "5 minuti,"),
            new MuteTime(600, "10 minuti"),
            new MuteTime(1200, "20 minuti"),
            new MuteTime(1800, "30 minuti"),

        };

        //

        private string _AlertMessage;
        public string AlertMessage
        {
            get => _AlertMessage;
            set
            {
                _AlertMessage = value;
                RaiseOnPropertyChanged();
            }
        }


        private string _BanMessage;
        public string BanMessage
        {
            get => _BanMessage;
            set
            {
                _BanMessage = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _GetUserinfoTargetUser;
        public string GetUserinfoTargetUser
        {
            get => _GetUserinfoTargetUser;
            set
            {
                _GetUserinfoTargetUser = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _selectedIndex;
        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _ManualBanTime;
        public int ManualBanTime
        {
            get => _ManualBanTime;
            set
            {
                _ManualBanTime = value;
                RaiseOnPropertyChanged();
            }
        }
        private int _ManualMuteTime;
        public int ManualMuteTime
        {
            get => _ManualMuteTime;
            set
            {
                _ManualMuteTime = value;
                RaiseOnPropertyChanged();
            }
        }
        private string _userNickname;
        public string UserNickname
        {
            get => _userNickname;
            set
            {
                _userNickname = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _userMotto;
        public string UserMotto
        {
            get => _userMotto;
            set
            {
                _userMotto = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _userLook;

        public string UserLook
        {
            get => _userLook;
            set
            {
                _userLook = value;
                RaiseOnPropertyChanged();
            }
        }





        public ModerationPage()
        {

            InitializeComponent();

            registeredUsers = new RegisteredUsers[] { };

            BantimeCmbx.Items.AddRange(_BanTime);
            BantimeCmbx.SelectedIndex = 0;
            MuteTimeCmbx.Items.AddRange(_MuteTime);
            MuteTimeCmbx.SelectedIndex = 0;

            Bind(UserNameTxbx, "Text", nameof(UserNickname));
            Bind(MottoTxbx, "Text", nameof(UserMotto));
            Bind(LookTxbx, "Text", nameof(UserLook));


            Bind(UsernameForUserinfoTxb, "Text", nameof(GetUserinfoTargetUser));



            Bind(AlertBoxTxb, "Text", nameof(AlertMessage));
            Bind(BanManualReasonTxb, "Text", nameof(BanMessage));

            Bind(MutaUtenteTimerNbx, "Value", nameof(ManualMuteTime));
            Bind(BanTimeManualNbx, "Value", nameof(ManualBanTime));

        }

        private void WriteRegistrationUsers()
        {
            Invoke((MethodInvoker)delegate
            {
                TotUserRegistered.Text = GlobalLists.UsersInRoom.Count().ToString();
            });
        }


        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            UserLeftRoom.Clear();
            Invoke((MethodInvoker)delegate
            {
                UsersCmbx.Items.Clear();
            });
        }

        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            UserLeftRoom.Clear();
            Invoke((MethodInvoker)delegate
            {
                UsersCmbx.Items.Clear();
            });
        }

        private class RegisteredUsers
        {
            public string Name { get; set; }
            public string Motto { get; set; }
            public string Look { get; set; }

            public int ID { get; set; }

            public RegisteredUsers(int id, string name, string motto, string look)
            {
                ID = id;
                Name = name;
                Motto = motto;
                Look = look;
            }
            public override string ToString() => $"{Name} [UserID: {ID}]";
        }




        private class BanTime
        {
            public string Name { get; }

            public int ID { get; }

            public BanTime(int id, string name)
            {
                ID = id;
                Name = name;
            }

            public override string ToString() => $"{Name} [Time: {ID}]";
        }




        private class MuteTime
        {
            public string Name { get; }

            public int ID { get; }

            public MuteTime(int id, string name)
            {
                ID = id;
                Name = name;
            }

            public override string ToString() => $"{Name} [Time: {ID}]";
        }


        public override void In_RoomUserRemove(DataInterceptedEventArgs e)
        {
            var entity = HentityUtils.FindLeftUserByIndex(int.Parse(e.Packet.ReadString()));
            if (entity != null)
            {
                AddUserInCmbx(entity);
            }
            WriteRegistrationUsers();

        }

        private void AddUserInCmbx(HEntity entity)
        {
            var ent = new RegisteredUsers(entity.Id, entity.Name, entity.Motto, entity.FigureId);
            AddUserInCmbx(ent);
        }


        private void AddUserInCmbx(RegisteredUsers user)
        {
            Invoke((MethodInvoker)delegate
            {
                if (!UsersCmbx.Items.Cast<RegisteredUsers>().Where(x => x.ID == user.ID).Any())
                { 
                    UsersCmbx.Items.Add(user);
                }
            });
            
        }

        private void RemoveUserInCmbx(RegisteredUsers user)
        {
            Invoke((MethodInvoker)delegate
            {
                foreach (var item in UsersCmbx.Items.Cast<RegisteredUsers>())
                {
                    if (item.ID == user.ID)
                    {
                        UsersCmbx.Items.Remove(item);
                        return;
                    }
                }
            });
        }

        private void RemoveUserInCmbx(HEntity entity)
        {
            var ent = new RegisteredUsers(entity.Id, entity.Name, entity.Motto, entity.FigureId);
            RemoveUserInCmbx(ent);
        }



        public override void In_RoomUsers(DataInterceptedEventArgs obj)
        {
            HEntity[] array = HEntity.Parse(obj.Packet);
            if (array.Length != 0)
            {
                foreach (HEntity entity in array)
                {
                    RemoveUserInCmbx(entity);
                }
            }
            WriteRegistrationUsers();
        }

        public override void Out_RequestWearingBadges(DataInterceptedEventArgs e)
        {
            _selectedUserId = e.Packet.ReadInteger();
            var entity = HentityUtils.FindEntityByUserID(_selectedUserId);
            if (entity != null)
            {
                SelectedIndex = entity.Index;
                GetUserinfoTargetUser = UserNickname = entity.Name;
                UserMotto = entity.Motto;
                UserLook = entity.FigureId;
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = entity.Name;
                });
            }
        }

        private async void StartFlood()
        {
            for (int i = 0; i < 26; i++)
            {
                await Task.Delay(50);
                await SendToServer(Out.RoomUserTalk, " ", Bubbleused);
            }
        }

        private void RecordedBan(string username, int time, string reason)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                _ = SendToServer(Out.RoomUserTalk, ":ban " + username + " " + time + " " + reason);
                RecordModeration("BAN", username, reason, time);
            }
        }

        private void RecordedMute(string username, int time)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                _ = SendToServer(Out.RoomUserTalk, ":mutam " + username + " " + time);
                RecordModeration("MUTE", username, "", time);

            }
        }
        private void RecordedUnmute(string username)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                _ = SendToServer(Out.RoomUserTalk, ":unmute " + username);
                RecordModeration("UNMUTE", username, "");

            }
        }

        private void RecordedAlert(string username, string reason)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                _ = SendToServer(Out.RoomUserTalk, ":alert " + username + " " + reason);
                RecordModeration("ALERT", username, reason);

            }
        }


        private void RecordedKickUser(string username, string reason)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                _ = SendToServer(Out.RoomUserTalk, ":cacciam " + username + " " + reason);
                RecordModeration("KICK CON ALERT", username, reason);

            }
        }



        private void RecordModeration(string ACTION, string entityname, string dettagli)
        {
            try
            {
                string Filepath = "../ModerationUtils/" + KnownDomains.GetHostName(Connection.Host) + "_ACTION" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "ModerationUtils";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("Moderation Actions stored at :" + DateTime.Now.ToString());
                        if (newroom)
                        {
                            if (GlobalStrings.UserDetails_Username == null)
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("You left the room at : " + DateTime.Now.ToString());
                            }
                            else
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine(" " + GlobalStrings.UserDetails_Username + "  left the room at : " + DateTime.Now.ToString());
                            }
                            if (GlobalStrings.UserDetails_Username == null)
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("[You Joined this room at : " + DateTime.Now.ToString() + " ]");
                            }
                            else
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("[ " + GlobalStrings.UserDetails_Username + " Joined this room at : " + DateTime.Now.ToString() + " ]");
                            }
                            txtFile.WriteLine("");
                            txtFile.WriteLine("[Room ID: " + GlobalInts.ROOM_ID + " ]");
                            txtFile.WriteLine("[Room Owner : " + GlobalStrings.ROOM_OWNER + " ]");
                            txtFile.WriteLine("[Room Name : " + GlobalStrings.ROOM_NAME + " ]");
                            txtFile.WriteLine("----------------------------------------------------");
                            newroom = false;
                        }
                        txtFile.WriteLine("----------------------------------------------------");
                        txtFile.WriteLine("[" + DateTime.Now + "]");
                        txtFile.WriteLine("[Username] : " + entityname);
                        txtFile.WriteLine("[TIPO MODERAZIONE]: " + ACTION);
                        if (ACTION == "MUTE")
                        {
                            txtFile.WriteLine("[DURATA MUTO IN SECONDI]: " + dettagli);
                        }
                        if (ACTION == "UNMUTE")
                        {
                            txtFile.WriteLine("[L'UTENTE E STATO SMUTATO]");
                        }
                        if (ACTION == "ALERT")
                        {
                            txtFile.WriteLine("[ALERT MESSAGGIO]: " + dettagli);
                        }
                        if (ACTION == "KICK CON ALERT")
                        {
                            txtFile.WriteLine("[MESSAGGIO KICK]: " + dettagli);
                        }
                        if (ACTION == "BAN")
                        {
                            txtFile.WriteLine("[MOTIVO BAN]: " + dettagli);
                        }
                    }
                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        if (newroom)
                        {
                            if (GlobalStrings.UserDetails_Username == null)
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("You left the room at : " + DateTime.Now.ToString());
                            }
                            else
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine(" " + GlobalStrings.UserDetails_Username + "  left the room at : " + DateTime.Now.ToString());
                            }
                            if (GlobalStrings.UserDetails_Username == null)
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("[You Joined this room at : " + DateTime.Now.ToString() + " ]");
                            }
                            else
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("[ " + GlobalStrings.UserDetails_Username + " Joined this room at : " + DateTime.Now.ToString() + " ]");
                            }
                            txtFile.WriteLine("");
                            txtFile.WriteLine("[Room ID: " + GlobalInts.ROOM_ID + " ]");
                            txtFile.WriteLine("[Room Owner : " + GlobalStrings.ROOM_OWNER + " ]");
                            txtFile.WriteLine("[Room Name : " + GlobalStrings.ROOM_NAME + " ]");
                            txtFile.WriteLine("----------------------------------------------------");
                            newroom = false;
                        }
                        else
                        {
                            txtFile.WriteLine("----------------------------------------------------");
                            txtFile.WriteLine("[" + DateTime.Now + "]");
                            txtFile.WriteLine("[Username] : " + entityname);
                            txtFile.WriteLine("[TIPO MODERAZIONE]: " + ACTION);
                            if (ACTION == "MUTE")
                            {
                                txtFile.WriteLine("[DURATA MUTO IN SECONDI]: " + dettagli);
                            }
                            if (ACTION == "UNMUTE")
                            {
                                txtFile.WriteLine("[L'UTENTE E STATO SMUTATO]");
                            }
                            if (ACTION == "ALERT")
                            {
                                txtFile.WriteLine("[ALERT MESSAGGIO]: " + dettagli);
                            }
                            if (ACTION == "KICK CON ALERT")
                            {
                                txtFile.WriteLine("[MESSAGGIO KICK]: " + dettagli);
                            }

                        }
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void RecordModeration(string ACTION, string entityname, string dettagli, int TEMPO)
        {
            try
            {
                string Filepath = "../ModerationUtils/" + KnownDomains.GetHostName(Connection.Host) + "_ACTION" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "ModerationUtils";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("Moderation Actions stored at :" + DateTime.Now.ToString());
                        if (newroom)
                        {
                            if (GlobalStrings.UserDetails_Username == null)
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("You left the room at : " + DateTime.Now.ToString());
                            }
                            else
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine(" " + GlobalStrings.UserDetails_Username + "  left the room at : " + DateTime.Now.ToString());
                            }
                            if (GlobalStrings.UserDetails_Username == null)
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("[You Joined this room at : " + DateTime.Now.ToString() + " ]");
                            }
                            else
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("[ " + GlobalStrings.UserDetails_Username + " Joined this room at : " + DateTime.Now.ToString() + " ]");
                            }
                            txtFile.WriteLine("");
                            txtFile.WriteLine("[Room ID: " + GlobalInts.ROOM_ID + " ]");
                            txtFile.WriteLine("[Room Owner : " + GlobalStrings.ROOM_OWNER + " ]");
                            txtFile.WriteLine("[Room Name : " + GlobalStrings.ROOM_NAME + " ]");
                            txtFile.WriteLine("----------------------------------------------------");
                            newroom = false;
                        }
                        txtFile.WriteLine("----------------------------------------------------");
                        txtFile.WriteLine("[" + DateTime.Now + "]");
                        txtFile.WriteLine("[Username] : " + entityname);
                        txtFile.WriteLine("[TIPO MODERAZIONE]: " + ACTION);
                        if (ACTION == "MUTE")
                        {
                            txtFile.WriteLine("[DURATA MUTO IN SECONDI]: " + dettagli);
                        }
                        if (ACTION == "UNMUTE")
                        {
                            txtFile.WriteLine("[L'UTENTE E STATO SMUTATO]");
                        }
                        if (ACTION == "ALERT")
                        {
                            txtFile.WriteLine("[ALERT MESSAGGIO]: " + dettagli);
                        }
                        if (ACTION == "KICK CON ALERT")
                        {
                            txtFile.WriteLine("[MESSAGGIO KICK]: " + dettagli);
                        }
                        if (ACTION == "BAN")
                        {
                            txtFile.WriteLine("[MOTIVO BAN]: " + dettagli);
                        }
                    }
                }
                else if (File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        if (newroom)
                        {
                            if (GlobalStrings.UserDetails_Username == null)
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("You left the room at : " + DateTime.Now.ToString());
                            }
                            else
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine(" " + GlobalStrings.UserDetails_Username + "  left the room at : " + DateTime.Now.ToString());
                            }
                            if (GlobalStrings.UserDetails_Username == null)
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("[You Joined this room at : " + DateTime.Now.ToString() + " ]");
                            }
                            else
                            {
                                txtFile.WriteLine("");
                                txtFile.WriteLine("[ " + GlobalStrings.UserDetails_Username + " Joined this room at : " + DateTime.Now.ToString() + " ]");
                            }
                            txtFile.WriteLine("");
                            txtFile.WriteLine("[Room ID: " + GlobalInts.ROOM_ID + " ]");
                            txtFile.WriteLine("[Room Owner : " + GlobalStrings.ROOM_OWNER + " ]");
                            txtFile.WriteLine("[Room Name : " + GlobalStrings.ROOM_NAME + " ]");
                            txtFile.WriteLine("----------------------------------------------------");
                            newroom = false;
                        }
                        else
                        {
                            txtFile.WriteLine("----------------------------------------------------");
                            txtFile.WriteLine("[" + DateTime.Now + "]");
                            txtFile.WriteLine("[Username] : " + entityname);
                            txtFile.WriteLine("[TIPO MODERAZIONE]: " + ACTION);
                            if (ACTION == "MUTE")
                            {
                                txtFile.WriteLine("[DURATA MUTO IN SECONDI]: " + TEMPO);
                            }
                            if (ACTION == "UNMUTE")
                            {
                                txtFile.WriteLine("[L'UTENTE E STATO SMUTATO]");
                            }
                            if (ACTION == "ALERT")
                            {
                                txtFile.WriteLine("[ALERT MESSAGGIO]: " + dettagli);
                            }
                            if (ACTION == "KICK CON ALERT")
                            {
                                txtFile.WriteLine("[MESSAGGIO KICK]: " + dettagli);
                            }
                            if (ACTION == "BAN")
                            {
                                txtFile.WriteLine("[MOTIVO BAN]: " + dettagli);
                                txtFile.WriteLine("[TEMPO BAN]: " + TEMPO);

                            }
                        }
                    }
                }
            }

            catch (Exception)
            {

            }
        }



        private void BanUserForSpamBtn_Click(object sender, EventArgs e)
        {
            RecordedBan(UserNickname, 360000000, "Spam di altri retroservers!");
        }

        private void FloodBtn_Click(object sender, EventArgs e)
        {
            StartFlood();
        }

        private void ManualBanBtn_Click(object sender, EventArgs e)
        {
            RecordedBan(UserNickname, ManualBanTime, BanMessage);
        }

        private void MuteUserBtn_click(object sender, EventArgs e)
        {
            RecordedMute(UserNickname, ManualMuteTime);
        }

        private void AlertUserBtn_click(object sender, EventArgs e)
        {
            RecordedAlert(UserNickname, AlertMessage);
        }


        private void KickUserWithAlertBtn_Click(object sender, EventArgs e)
        {
            RecordedKickUser(UserNickname, AlertMessage);

        }

        private void banForInfoLeakBtn_Click(object sender, EventArgs e)
        {
            RecordedBan(UserNickname, 1209600, "Diffusione di informazioni personali");
        }

        private void BanForNicknameNotAllowedBtn_Click(object sender, EventArgs e)
        {
            RecordedBan(UserNickname, 360000000, "Il Tuo Nickname non è consentito in questo hotel!");
        }

        private void BanForSecurityLockBtn_Click(object sender, EventArgs e)
        {
            RecordedBan(UserNickname, 360000000, "Ban di sicurezza! Contatta il support per maggiori informazioni!");
        }

        private void BantimeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManualBanTime = ((BanTime)BantimeCmbx.SelectedItem).ID;
        }


        private void MuteTimeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManualMuteTime = ((MuteTime)MuteTimeCmbx.SelectedItem).ID;
        }

        private void UnmuteUserBtn_Click(object sender, EventArgs e)
        {
            RecordedUnmute(UserNickname);
        }


        private void UsersCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetUserinfoTargetUser = UserNickname = ((RegisteredUsers)UsersCmbx.SelectedItem).Name;
                UserMotto = ((RegisteredUsers)UsersCmbx.SelectedItem).Motto;
                UserLook = ((RegisteredUsers)UsersCmbx.SelectedItem).Look;
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = ((RegisteredUsers)UsersCmbx.SelectedItem).Name;
                });

            }
            catch (Exception) { }
        }



        private void GetUserInfoBtn_Click(object sender, EventArgs e)
        {
            _ = SendToServer(Out.RoomUserTalk, ":userinfo " + GetUserinfoTargetUser, GlobalInts.Selected_bubble_ID);
        }
    }
}

