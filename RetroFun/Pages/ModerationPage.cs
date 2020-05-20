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
        private int Bubbleused = 0;
        private readonly string psw = "1q1w1e";
        private int RoomID = 0;
        private string OwnerName = "NOT INITIATED";
        private string roomname = "NOT INITIATED";
        private bool newroom = true;

        private  RegisteredUsers[] _registeredUsers;
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

        private string _UnlockPassword;

        public string UnlockPassword
        {
            get => _UnlockPassword;
            set
            {
                _UnlockPassword = value;
                RaiseOnPropertyChanged();
            }
        }




        public ModerationPage()
        {

            InitializeComponent();

            _registeredUsers = new RegisteredUsers[] { };

            BantimeCmbx.Items.AddRange(_BanTime);
            BantimeCmbx.SelectedIndex = 0;
            MuteTimeCmbx.Items.AddRange(_MuteTime);
            MuteTimeCmbx.SelectedIndex = 0;

            Bind(UserNameTxbx, "Text", nameof(UserNickname));
            Bind(MottoTxbx, "Text", nameof(UserMotto));
            Bind(LookTxbx, "Text", nameof(UserLook));
            Bind(passwordtxb, "Text", nameof(UnlockPassword));


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



        private void EnableTxbx(TextBox txb, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                txb.Enabled = value;
            });
        }


        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            GlobalLists.UsersInRoom.Count().ToString();
            Invoke((MethodInvoker)delegate
            {
                UsersCmbx.Items.Clear();
            });
        }

        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                UsersCmbx.Items.Clear();
            });
        }


        public override void Out_RoomUserTalk(DataInterceptedEventArgs e)
        {
            e.Packet.ReadString();
            int Bubble = e.Packet.ReadInteger();
            if (Bubbleused != Bubble)
            {
                Bubbleused = Bubble;
            }
        }
        public override void In_RoomUserShout(DataInterceptedEventArgs e)
        {
            e.Packet.ReadString();
            int Bubble = e.Packet.ReadInteger();
            if (Bubbleused != Bubble)
            {
                Bubbleused = Bubble;
            }
        }
        private class RegisteredUsers
        {
            public string Name { get; set; }
            public string  Motto { get; set; }
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
            var entity = HentityUtils.FindEntityByIndex(int.Parse(e.Packet.ReadString()));
            if (entity != null)
            {
                RegisterRemovedUser(entity);
            }
        }


        private  void RegisterRemovedUser(HEntity entity)
        {
            if (!_registeredUsers.Where(x => x.ID == entity.Id).Any())
            {
                AddUserInCmbx(entity);
            }
        }


        private void AddUserInCmbx(HEntity entity)
        {
            var user = new RegisteredUsers(entity.Id, entity.Name, entity.Motto, entity.FigureId);
            Invoke((MethodInvoker)delegate
            {
                if (!UsersCmbx.Items.Contains(user))
                {
                     UsersCmbx.Items.Add(user);
                }
            });
        }

        private void RemoveUserInCmbx(string username)
        {
            if (_registeredUsers.Where(x => x.Name == username).Any())
            {
                UsersCmbx.Items.Remove(username);
            }
        }

        public override void In_RoomUsers(DataInterceptedEventArgs obj)
        {
          WriteRegistrationUsers();
        }

        public override void Out_RequestWearingBadges(DataInterceptedEventArgs e)
        {
            _selectedUserId = e.Packet.ReadInteger();
            var entity = HentityUtils.FindEntityByUserID(_selectedUserId);
            if (entity != null)
            {
                SelectedIndex = entity.Index;
                UserNickname = entity.Name;
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
               await Connection.SendToServerAsync(Out.RoomUserTalk, " ", Bubbleused);
            }
        }

        private void RecordedBan(string username, int time , string reason)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                Connection.SendToServerAsync(Out.RoomUserTalk, ":ban " + username + " " + time + " " + reason);
                RecordModeration("BAN", username, reason, time);
            }
        }

        private void RecordedMute(string username, int time)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                Connection.SendToServerAsync(Out.RoomUserTalk, ":mutam " + username + " " + time);
                RecordModeration("MUTE", username, "" , time);

            }
        }
        private void RecordedUnmute(string username)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                Connection.SendToServerAsync(Out.RoomUserTalk, ":unmute " + username);
                RecordModeration("UNMUTE", username, "");

            }
        }

        private void RecordedAlert(string username, string reason)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                Connection.SendToServerAsync(Out.RoomUserTalk, ":alert " + username + " " + reason);
                RecordModeration("ALERT", username, reason);

            }
        }


        private void RecordedKickUser(string username, string reason)
        {
            if (UserNickname != GlobalStrings.UserDetails_Username)
            {
                Connection.SendToServerAsync(Out.RoomUserTalk, ":cacciam " + username + " " + reason);
                RecordModeration("KICK CON ALERT", username, reason);

            }
        }



        private void RecordModeration(string ACTION, string entityname, string dettagli)
        {
            try
            {
                string Filepath = "../ModerationUtils/" + RecognizeDomain.GetHost(Connection.Host) + "_Chatlog" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "ModerationUtils";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("Moderation Chatlog stored at :" + DateTime.Now.ToString());
                        if (newroom)
                        {
                            txtFile.WriteLine("You left the room at : " + DateTime.Now.ToString());
                            txtFile.WriteLine("");
                            txtFile.WriteLine("Room : " + RoomID + " Room Owner : " + OwnerName + " Room Name : " + roomname);
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
                            txtFile.WriteLine("You left the room at : " + DateTime.Now.ToString());
                            txtFile.WriteLine("");
                            txtFile.WriteLine("Room : " + RoomID + " Room Owner : " + OwnerName + " Room Name : " + roomname);
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
                string Filepath = "../ModerationUtils/" + RecognizeDomain.GetHost(Connection.Host) + "_Chatlog" + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
                string FolderName = "ModerationUtils";

                Directory.CreateDirectory("../" + FolderName);

                if (!File.Exists(Filepath))
                {
                    using (var txtFile = File.AppendText(Filepath))
                    {
                        txtFile.WriteLine("Moderation Chatlog stored at :" + DateTime.Now.ToString());
                        if (newroom)
                        {
                            txtFile.WriteLine("Player left the room at : " + DateTime.Now.ToString());
                            txtFile.WriteLine("");
                            txtFile.WriteLine("Room : " + RoomID + " Room Owner : " + OwnerName + " Room Name : " + roomname);
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
                            txtFile.WriteLine("Player left the room at : " + DateTime.Now.ToString());
                            txtFile.WriteLine("");
                            txtFile.WriteLine("Room : " + RoomID + " Room Owner : " + OwnerName + " Room Name : " + roomname);
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

        private bool IsPasswordCorrect(string password)
        {

            if (password == psw)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void isUnblocked(TextBox textbox, bool status)
        {
            Invoke((MethodInvoker)delegate
            {
                textbox.Visible = status;
                textbox.Enabled = status;
            });
        }

        private void isUnblocked(NumericUpDown numericbox, bool status)
        {
            Invoke((MethodInvoker)delegate
            {
                numericbox.Visible = status;
                numericbox.Enabled = status;
            });
        }

        private void isUnblocked(GroupBox box, bool status)
        {
            Invoke((MethodInvoker)delegate
            {
                box.Visible = status;
                box.Enabled = status;
            });
        }

        private void isUnblocked(Label label, bool status)
        {
            Invoke((MethodInvoker)delegate
            {
                label.Visible = status;
                label.Enabled = status;
            });
        }

        private void isUnblocked(SKoreButton button, bool status)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Visible = status;
                button.Enabled = status;
            });
        }

        private void isUnblocked(ComboBox combobox, bool status)
        {
            Invoke((MethodInvoker)delegate
            {
                combobox.Visible = status;
                combobox.Enabled = status;
            });
        }


        private void UnlockStaffFeatures()
        {
            if (IsPasswordCorrect(UnlockPassword))
            {
                isUnblocked(UserNameTxbx, true);
                isUnblocked(groupBox1, true);
                isUnblocked(SelectUserLabel, true);
                isUnblocked(groupBox4, true);
                isUnblocked(TotUserRegistered, true);
                isUnblocked(MottoTxbx, true);
                isUnblocked(LookTxbx, true);
                isUnblocked(label1, true);
                isUnblocked(label2, true);
                isUnblocked(Label3, true);
                isUnblocked(BanUserForSpamBtn, true);
                isUnblocked(FloodBtn, true);
                isUnblocked(MuteUserBtn, true);
                isUnblocked(groupBox2, true);
                isUnblocked(UnmuteUserBtn, true);
                isUnblocked(MuteTimeCmbx, true);
                isUnblocked(label4, true);
                isUnblocked(MutaUtenteTimerNbx, true);
                isUnblocked(Utente, true);
                isUnblocked(groupBox3, true);
                isUnblocked(KickUserWithAlertBtn, true);
                isUnblocked(AlertBoxTxb, true);
                isUnblocked(AlertUserBtn, true);
                isUnblocked(groupBox5, true);
                isUnblocked(banForInfoLeakBtn, true);
                isUnblocked(BanForNicknameNotAllowedBtn, true);
                isUnblocked(BanForSecurityLockBtn, true);
                isUnblocked(ManualBanBtn, true);
                isUnblocked(groupBox6, true);
                isUnblocked(label7, true);
                isUnblocked(label5, true);
                isUnblocked(BanTimeManualNbx, true);
                isUnblocked(BantimeCmbx, true);
                isUnblocked(BanManualReasonTxb, true);
                isUnblocked(UsersCmbx, true);
                isUnblocked(FakeRespectUserBtn, true);

                isUnblocked(UnlockStaffUtilsBtn, false);
                isUnblocked(passwordtxb, false);

            }
            else
            {
                UnlockPassword = "";
            }
        }


        private void UnlockStaffUtilsBtn_Click(object sender, EventArgs e)
        {
            UnlockStaffFeatures();

        }

        private void UsersCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UserNickname = ((RegisteredUsers)UsersCmbx.SelectedItem).Name;
                UserMotto = ((RegisteredUsers)UsersCmbx.SelectedItem).Motto;
                UserLook = ((RegisteredUsers)UsersCmbx.SelectedItem).Look;
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = ((RegisteredUsers)UsersCmbx.SelectedItem).Name;
                });

            }
            catch (Exception) { }
        }

        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }



        private void FakeRespectThisUserBtn_click(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(Out.RoomUserAction, 7);
            Connection.SendToServerAsync(Out.RoomUserTalk, "Stanno inviando rispetti a " + UserNickname + "!", 1);
        }
    }
}

