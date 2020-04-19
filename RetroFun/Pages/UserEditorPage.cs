using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Protocol;
using Sulakore.Components;
using System.Threading;

namespace RetroFun.Pages
{

    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class UserEditorPage : ObservablePage, ISubscriber
    {
        private int _selectedUserId;
        private bool _isBlacklistActive = true;
        private Dictionary<string, bool> _blacklistedEntities;
        public int LocalIndex;

        private bool _IsAddAllUsersInBlacklist;

        //username => Removed entity
        private Dictionary<string, HEntity> _removedEntities; //

        private Dictionary<int, HEntity> _users = new Dictionary<int, HEntity>();
        private string psw = "1q1w1e";

        //
        private string OwnUsername;


        private bool _LockNickname;

        public bool LockNickname
        {
            get => _LockNickname;
            set
            {
                _LockNickname = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _LockMotto;

        public bool LockMotto
        {
            get => _LockMotto;
            set
            {
                _LockMotto = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _LockLook;

        public bool LockLook
        {
            get => _LockLook;
            set
            {
                _LockLook = value;
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


        public bool IsReceiving => true;

        public UserEditorPage()
        {
            InitializeComponent();
            Bind(UserNameTxbx, "Text", nameof(UserNickname));
            Bind(MottoTxbx, "Text", nameof(UserMotto));
            Bind(LookTxbx, "Text", nameof(UserLook));
            Bind(passwordtxb, "Text", nameof(UnlockPassword));

            Bind(LockNicknameBoxChbx, "Checked", nameof(LockNickname));
            Bind(LockMottoBoxChbx, "Checked", nameof(LockMotto));
            Bind(lockLookChbx, "Checked", nameof(LockLook));

            _removedEntities = new Dictionary<string, HEntity>();
            _blacklistedEntities = new Dictionary<string, bool>();
        }

        private void WriteRegistrationUsers(int count)
        {
            Invoke((MethodInvoker)delegate
            {
                TotUserRegistered.Text = count.ToString();
            });
        }

        private void CountUserInRoomBlacklist()
        {
            Invoke((MethodInvoker)delegate
            {
                BlackListUserRoomLbl.Text = "Blacklisted Users in room : " + _users.Values.Count(e => _blacklistedEntities.ContainsKey(e.Name) && _blacklistedEntities[e.Name]);
            });
        }

        private void CountNicknamesBlacklisted()
        {
            Invoke((MethodInvoker)delegate
            {
                BlacklistCountLbl.Text = "Blacklisted Users : " + _blacklistedEntities.Count.ToString();
            });
        }

        private void EnableTxbx(TextBox txb, bool value)
        {
            Invoke((MethodInvoker)delegate
            {
                txb.Enabled = value;
            });
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {

        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {

        }

        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
            _users.Clear();
            _removedEntities.Clear();

            CountUserInRoomBlacklist();
            WriteRegistrationUsers(_users.Count);
        }

        public void OnLatencyTest(DataInterceptedEventArgs obj)
        {
            if (OwnUsername == null)
            {
                Connection.SendToServerAsync(Out.RequestUserData);
            }
        }

        public void OnUsername(DataInterceptedEventArgs obj)
        {
            string username = obj.Packet.ReadString();

            if (OwnUsername == null)
            {
                OwnUsername = username;
            }
        }

        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {

        }
        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {

        }
        public void InPurchaseOk(DataInterceptedEventArgs e)
        {

        }
        public void InItemExtraData(DataInterceptedEventArgs e)
        {
        }


        public void OnRoomUserTalk(DataInterceptedEventArgs e)
        {

        }
        public void OnRoomUserShout(DataInterceptedEventArgs e)
        { }
        public void OnRoomUserWhisper(DataInterceptedEventArgs e)
        { }

        public void InRoomUserTalk(DataInterceptedEventArgs e)
        {
            var index = e.Packet.ReadInteger();
            if (LocalIndex != index)
            {
                if (_isBlacklistActive)
                {
                    e.IsBlocked = IsBlockedEntity(index);
                }
            }
        }

        public void InRoomUserShout(DataInterceptedEventArgs e)
        {
            var index = e.Packet.ReadInteger();
            if (LocalIndex != index)
            {
                if (_isBlacklistActive)
                {
                    e.IsBlocked = IsBlockedEntity(index);
                }
            }
        }
        public void InRoomUserWhisper(DataInterceptedEventArgs e)
        {
            var index = e.Packet.ReadInteger();
            if (LocalIndex != index)
            {
                if (_isBlacklistActive)
                {
                    e.IsBlocked = IsBlockedEntity(index);
                }
            }
        }


        private bool IsBlockedEntity(int index)
        {
            //This "entity" we grab here is gives the _original_ entity, so we can check if that _original_ username exists in the removed dictionary, or in the blacklisted users list and is active => the boolean value is true:)
            var entity = _users.Values.FirstOrDefault(e => e.Index == index);
            if (entity == null) return false;

            return _removedEntities.ContainsKey(entity.Name) || IsActiveAndBlacklisted(entity.Name);
        }
        private bool IsActiveAndBlacklisted(string username)
        {
            //_isBlacklistActive and username is in blacklist and THAT blacklist entry is active (  VVVVVVVVVVV )
            return (_blacklistedEntities.ContainsKey(username) && _blacklistedEntities[username]);
        }


        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
            int index = int.Parse(e.Packet.ReadString());
            var entity = _users.Values.FirstOrDefault(ent => ent.Index == index);
            if (entity == null) return;

            _users.Remove(entity.Id);

            WriteRegistrationUsers(_users.Count);
            CountUserInRoomBlacklist();
        }

        public void InUserEnterRoom(DataInterceptedEventArgs obj)
        {
            var removedEntities = new List<HEntity>(); //these need to be removed, they cant be removed inside this method because the clietn doesnt have those users => cant remove either
            try
            {
                HEntity[] array = HEntity.Parse(obj.Packet);
                if (array.Length > 0)
                {
                    foreach (HEntity entity in array)
                    {


                        if (!_users.ContainsKey(entity.Id))
                        {
                            _users.Add(entity.Id, entity);
                        }

                        if (entity.Name == OwnUsername)
                        {
                            LocalIndex = entity.Index;
                        }

                        if (_isBlacklistActive && IsActiveAndBlacklisted(entity.Name))
                        {
                            removedEntities.Add(entity);
                        }
                        if (_IsAddAllUsersInBlacklist)
                        {
                            if (entity.Name != OwnUsername)
                            {
                                removedEntities.Add(entity);
                            }
                        }
                    }
                }
                WriteRegistrationUsers(_users.Count);
                CountUserInRoomBlacklist();

                //obj.Continue(); //hopefully 
                //
                ////Before we can remove them using RemoveEntity, the RoomUsers packet has to be received by our client. Otherwise this call below doesnt do anything because theres no users to remove yet.
                //foreach (var entity in removedEntities)
                //{
                //    RemoveEntity(entity);
                //}
                if (_isBlacklistActive)
                {
                    DeleteBlacklistedUsers();
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
            _selectedUserId = e.Packet.ReadInteger();

            if (_users.TryGetValue(_selectedUserId, out HEntity entity))
            {
                SelectedIndex = entity.Index;

                if (!LockNickname)
                {
                    UserNickname = entity.Name;
                }
                if (!LockMotto)
                {
                    UserMotto = entity.Motto;
                }
                if (!LockLook)
                {
                    UserLook = entity.FigureId;
                }

                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = entity.Name;
                });
            }
        }

        public void InUserProfile(DataInterceptedEventArgs e)
        {

        }

        private void RemoveEntity(string username, bool ShouldBlacklist)
        {
            var entity = _users.Values.FirstOrDefault(e => e.Name == username);
            RemoveEntity(entity, ShouldBlacklist);
        }
        private void RemoveEntity(int index, bool shouldblacklist)
        {
            var entity = _users.Values.FirstOrDefault(e => e.Index == index);
            RemoveEntity(entity, shouldblacklist);
        }
        private void RemoveEntity(HEntity entity, bool shouldblacklist)
        {
            //Connection.SendToClientAsync(In.RoomUserWhisper, 0, $"[User Blacklist] : DEBUG - RemoveEntity(entity.. {{ name: {entity.Name}, entity.index: {entity.Index} }}) ", 0, 34, 0, -1);

            //Cache the og entity we removed 
            if (shouldblacklist)
            {
                if (entity != null)
                {
                    if (!_removedEntities.ContainsKey(entity.Name))
                        _removedEntities.Add(entity.Name, entity);


                    RemoveRoomUser(entity.Index);
                }
            }
        }

        private void RemoveRoomUser(int index)
        {
            Connection.SendToClientAsync(In.RoomUserRemove, index.ToString());
        }

        private void RestoreEntity(string username)
        {
            if (_removedEntities.TryGetValue(username, out HEntity entity))
            {
                if (_users.TryGetValue(entity.Id, out _))
                {
                    //Remove fake entity
                    RemoveRoomUser(entity.Index);


                    //Add original entity back
                    AddUser(entity.Id, entity.Index, entity.Name, entity.Motto, entity.FigureId, entity.Tile, entity.Gender, entity.FavoriteGroup);

                    //Remove the original data because we have it already
                    _removedEntities.Remove(username);
                }
            }

        }

        private void ReplaceUser(int id, string newName, string motto, string look, bool shouldstore)
        {
            if (!_users.TryGetValue(id, out var entity))
            {
                //ouch
                return;
            }
            if (shouldstore)

            {
                if (_blacklistedEntities.ContainsKey(entity.Name))
                {

                    _blacklistedEntities[entity.Name] = false;
                }
                //Connection.SendToClientAsync(In.RoomUserWhisper, 0, $"[User Blacklist] : DEBUG - ReplaceUser(index: {entity.Index}, {entity.Name}=>{newName}, {entity.Motto}=>{motto}..)", 0, 34, 0, -1);
            }

            //remove it
            RemoveEntity(entity, shouldstore);

            //Add our edited entity
            AddUser(id, entity.Index, newName, motto, look, entity.Tile, entity.Gender, entity.FavoriteGroup);
        }

        private void AddUser(int id, int index, string name, string motto, string figureId, HPoint tile, HGender gender, string favoriteGroup)
        {
            Connection.SendToClientAsync(In.RoomUsers,
                1,
                id,
                name,
                motto,
                figureId,
                index,
                tile.X, tile.Y,
                tile.Z.ToString(),
                1,
                1,
                ((char)gender).ToString(),
                1,
                1,
                favoriteGroup,
                "",
                1,
                false
            );
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            ReplaceUser(_selectedUserId, _userNickname, _userMotto, _userLook, false);
        }

        private void lockLookChbx_CheckedChanged(object sender, EventArgs e)
        {
            EnableTxbx(LookTxbx, LockLook);
        }
        private void LockMottoBoxChbx_CheckedChanged(object sender, EventArgs e)
        {
            EnableTxbx(MottoTxbx, LockMotto);
        }
        private void LockNicknameBoxChbx_CheckedChanged(object sender, EventArgs e)
        {
            EnableTxbx(UserNameTxbx, LockNickname); //Because that LockX bool is always same as your true and false if bodies
        }

        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }

        private void isVisibileButton(SKoreButton button, bool isVisible)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Visible = isVisible;
            });
        }

        private void isEnabledButton(SKoreButton button, bool isEnabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = isEnabled;
            });
        }


        private void isVisibileTextBox(TextBox textbox, bool text)
        {
            Invoke((MethodInvoker)delegate
            {
                textbox.Visible = text;
            });
        }

        private void isEnableTextBox(TextBox textbox, bool text)
        {
            Invoke((MethodInvoker)delegate
            {
                textbox.Enabled = text;
            });
        }
        private void BlacklistBtn_Click(object sender, EventArgs e)
        {
            _isBlacklistActive = !_isBlacklistActive;
            WriteToButton(BlacklistBtn, "Blacklist: " + (_isBlacklistActive ? "ON" : "OFF"));

            if (!_isBlacklistActive)
            {
                RestoreBlacklistedUsers();
            }
            else DeleteBlacklistedUsers();
        }

        //_blacklistedEntitities entry.Key: string name, entry.Value: "is active" bool
        private void DeleteBlacklistedUsers()
        {
            foreach (var entry in _blacklistedEntities)
            {
                RemoveEntity(entry.Key, true);
            }
        }
        private void RestoreBlacklistedUsers()
        {
            foreach (var entry in _blacklistedEntities.ToArray())
            {
                RestoreEntity(entry.Key);

                //De-activate this blacklistEntry
                _blacklistedEntities[entry.Key] = false;
            }
        }

        private void ClearBlacklistBtn_Click(object sender, EventArgs e)
        {
            //Restore em before clearing the list
            RestoreBlacklistedUsers();

            _blacklistedEntities.Clear();

            CountUserInRoomBlacklist();
            CountNicknamesBlacklisted();
        }

        private void AddSelectedUserInBlacklistBtn_Click(object sender, EventArgs e)
        {
            if (!_users.TryGetValue(_selectedUserId, out var entityToBlacklist))
            {
                //ouch
                return;
            }

            if (entityToBlacklist.Name == OwnUsername)
            {
                Connection.SendToClientAsync(In.RoomUserTalk, entityToBlacklist.Index, "[User Blacklist] :Hey, you can't blacklist yourself!", 0, 30, 0, -1);
                return; //ouchie
            }

            if (_blacklistedEntities.ContainsKey(entityToBlacklist.Name))
            {
                Connection.SendToClientAsync(In.RoomUserTalk, entityToBlacklist.Index, "[User Blacklist] : Hey, im already added in your blacklist!", 0, 30, 0, -1);

                return; //ouchie
            }

            //Blacklist it, add blacklist entry
            _blacklistedEntities.Add(entityToBlacklist.Name, true);

            //Remove it
            if (_isBlacklistActive)
            {
                RemoveEntity(entityToBlacklist, true);
            }

            CountNicknamesBlacklisted();
        }

        private void RemoveUserFromRoomBtn_Click(object sender, EventArgs e)
        {
            // TODO : MAKE SURE IS JUST A TEMPORARY REMOVAL, AND NOT THE BLACKLIST REMOVAL.

            if (_users.TryGetValue(_selectedUserId, out var entityToRemove))

                if (entityToRemove.Name == OwnUsername)
                {
                    Connection.SendToClientAsync(In.RoomUserTalk, entityToRemove.Index, "[User Blacklist] :Hey, you can't blacklist yourself!", 0, 30, 0, -1);
                    return; //ouchie
                }
            RemoveEntity(entityToRemove, true);
        }

        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
        }

        public void InFloorItemUpdate(DataInterceptedEventArgs e)
        {
        }




        private void AddAllUsersInBlacklist()
        {
            foreach (KeyValuePair<int, HEntity> entity in _users)
            {
                if (!_users.TryGetValue(entity.Key, out var entityToBlacklist))
                {
                    //ouch
                    return;
                }

                if (entityToBlacklist.Name == OwnUsername)
                {
                    return; //ouchie
                }

                if (_blacklistedEntities.ContainsKey(OwnUsername))
                {
                    //Blacklist it, add blacklist entry
                    _blacklistedEntities.Remove(OwnUsername);

                }

                if (!_blacklistedEntities.ContainsKey(entityToBlacklist.Name))
                {

                    //Blacklist it, add blacklist entry
                    _blacklistedEntities.Add(entityToBlacklist.Name, true);

                    //Remove it
                    if (_isBlacklistActive)
                    {
                        RemoveEntity(entityToBlacklist, true);
                    }

                }
                CountNicknamesBlacklisted();
            }
        }


        private void StartAllUserRemover()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    try
                    {
                        if (_IsAddAllUsersInBlacklist)
                        {
                            AddAllUsersInBlacklist();
                            Thread.Sleep(150);
                        }
                    }
                    catch (Exception e)
                    {

                    }

                } while (_IsAddAllUsersInBlacklist);
            }).Start();
        }


        private void AddAllUsersOnBlacklistBtn_Click(object sender, EventArgs e)
        {
            if (_IsAddAllUsersInBlacklist)
            {
                _IsAddAllUsersInBlacklist = false;
                WriteToButton(AddAllUsersOnBlacklistBtn, "Add All Users in blacklist : OFF");
            }
            else
            {
                _IsAddAllUsersInBlacklist = true;
                StartAllUserRemover();
                WriteToButton(AddAllUsersOnBlacklistBtn, "Add All Users in blacklist : ON");

            }
        }

        private void RestoreBlacklistBtn_Click(object sender, EventArgs e)
        {
            //foreach (var entry in _blacklistedEntities.ToArray())
            //{

            //    RestoreEntity(entry.Key);

            //    //De-activate this blacklistEntry
            //    _blacklistedEntities[entry.Key] = false;
            //}
        }

        private async void executeantispam()
        {
            if (UserNickname != OwnUsername)
            {
                await Connection.SendToServerAsync(Out.RoomUserTalk, ":ban " + UserNickname + " 360000000 SPAM");
            }
        }


        private async void StartFlood()
        {
            for (int i = 0; i < 26; i++)
            {
                await Task.Delay(50);
               await Connection.SendToServerAsync(Out.RoomUserTalk, " ", 23);
            }
        }


        private bool IsPasswordCorrect(string password)
        {
            
            if(password == psw)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UnlockStaffFeatures()
        {
            if(IsPasswordCorrect(UnlockPassword))
            {
                isEnabledButton(FloodBtn, true);
                isEnabledButton(BanUserForSpamBtn, true);
                isVisibileButton(FloodBtn, true);
                isVisibileButton(BanUserForSpamBtn, true);
                isVisibileTextBox(passwordtxb, false);
                isEnableTextBox(passwordtxb, false);
                isVisibileButton(UnlockStaffUtilsBtn, false);
                isEnabledButton(UnlockStaffUtilsBtn, false);
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

        private void BanUserForSpamBtn_Click(object sender, EventArgs e)
        {
            executeantispam();
        }

        private void FloodBtn_Click(object sender, EventArgs e)
        {
            StartFlood();
        }
    }
}

