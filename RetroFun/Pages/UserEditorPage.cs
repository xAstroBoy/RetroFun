using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Habbo;
using Sulakore.Components;
using System.Threading;
using RetroFun.Utils.Globals;

namespace RetroFun.Pages
{

    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class UserEditorPage:  ObservablePage
    {
        private int _selectedUserId;
        private bool _isBlacklistActive = false;

        private bool _IsAddAllUsersInBlacklist;

        private Dictionary<string, HEntity> _removedEntities { get => GlobalDictionaries.removedEntities; }
        private Dictionary<int, HEntity> _users { get => GlobalDictionaries.Dictionary_UsersPresentInRoom; }
        private Dictionary<string, bool> _blacklistedEntities { get => GlobalDictionaries.blacklistedEntities; }


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

        private int _Handitem;
        public int Handitem
        {
            get => _Handitem;
            set
            {
                _Handitem = value;
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




        public UserEditorPage()
        {
            InitializeComponent();
            Bind(UserNameTxbx, "Text", nameof(UserNickname));
            Bind(MottoTxbx, "Text", nameof(UserMotto));
            Bind(LookTxbx, "Text", nameof(UserLook));

            Bind(LockNicknameBoxChbx, "Checked", nameof(LockNickname));
            Bind(LockMottoBoxChbx, "Checked", nameof(LockMotto));
            Bind(lockLookChbx, "Checked", nameof(LockLook));
        }

        private void UpdateRoomUsersLabel()
        {
            Invoke((MethodInvoker)delegate
            {
                TotUserRegistered.Text = GlobalDictionaries.Dictionary_UsersPresentInRoom.Count.ToString();
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

        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {

            CountUserInRoomBlacklist();
            UpdateRoomUsersLabel();
        }

        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            CountUserInRoomBlacklist();
            UpdateRoomUsersLabel();
        }



        public override void In_RoomUserTalk(DataInterceptedEventArgs e)
        {
            var index = e.Packet.ReadInteger();
            if (GlobalInts.OwnUser_index != index)
            {
                if (_isBlacklistActive)
                {
                    e.IsBlocked = IsBlockedEntity(index);
                }
            }
        }

        public override void  In_RoomUserShout(DataInterceptedEventArgs e)
        {
            var index = e.Packet.ReadInteger();
            if (GlobalInts.OwnUser_index != index)
            {
                if (_isBlacklistActive)
                {
                    e.IsBlocked = IsBlockedEntity(index);
                }
            }
        }
        public override void In_RoomUserWhisper(DataInterceptedEventArgs e)
        {
            var index = e.Packet.ReadInteger();
            if (GlobalInts.OwnUser_index != index)
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


        public override void In_RoomUserRemove(DataInterceptedEventArgs e)
        {
            UpdateRoomUsersLabel();
            CountUserInRoomBlacklist();
        }

        public override void In_RoomUsers(DataInterceptedEventArgs obj)
        {
            var removedEntities = new List<HEntity>(); //these need to be removed, they cant be removed inside this method because the clietn doesnt have those users => cant remove either
            try
            {
                HEntity[] array = HEntity.Parse(obj.Packet);
                if (array.Length > 0)
                {
                    foreach (HEntity entity in array)
                    {
                        if (_isBlacklistActive && IsActiveAndBlacklisted(entity.Name))
                        {
                            removedEntities.Add(entity);
                        }
                        if (_IsAddAllUsersInBlacklist)
                        {
                            if (entity.Name != GlobalStrings.UserDetails_Username)
                            {
                                removedEntities.Add(entity);
                            }
                        }
                    }
                }
                UpdateRoomUsersLabel();
                CountUserInRoomBlacklist();

                if (_isBlacklistActive)
                {
                    DeleteBlacklistedUsers();
                }
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        public override void Out_RequestWearingBadges(DataInterceptedEventArgs e)
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

            if (entityToBlacklist.Name == GlobalStrings.UserDetails_Username)
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

                if (entityToRemove.Name == GlobalStrings.UserDetails_Username)
                {
                    Connection.SendToClientAsync(In.RoomUserTalk, entityToRemove.Index, "[User Blacklist] :Hey, you can't blacklist yourself!", 0, 30, 0, -1);
                    return; //ouchie
                }
            RemoveEntity(entityToRemove, true);
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

                if (entityToBlacklist.Name == GlobalStrings.UserDetails_Username)
                {
                    return; //ouchie
                }

                if (_blacklistedEntities.ContainsKey(GlobalStrings.UserDetails_Username))
                {
                    _blacklistedEntities.Remove(GlobalStrings.UserDetails_Username);

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

        private void FakeRespectUserBtn_Click(object sender, EventArgs e)
        {
            Connection.SendToServerAsync(Out.RoomUserAction, 7);
            Connection.SendToServerAsync(Out.RoomUserTalk, "Stanno inviando rispetti a " + UserNickname + "!", 1);
        }
    }
}

