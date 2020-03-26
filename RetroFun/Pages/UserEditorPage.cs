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

namespace RetroFun.Pages
{

    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class UserEditorPage : ObservablePage, ISubscriber
    {

        private int TempUserID;


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

        private int _SelectedIndex;

        public int SelectedIndex
        {
            get => _SelectedIndex;
            set
            {
                _SelectedIndex = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _UserNickname;

        public string UserNickname
        {
            get => _UserNickname;
            set
            {
                _UserNickname = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _UserMotto;

        public string UserMotto
        {
            get => _UserMotto;
            set
            {
                _UserMotto = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _UserLook;

        public string UserLook
        {
            get => _UserLook;
            set
            {
                _UserLook = value;
                RaiseOnPropertyChanged();
            }
        }

        private Dictionary<int, HEntity> users = new Dictionary<int, HEntity>();

        public bool IsReceiving => true;

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

        private void WriteRegistrationUsers(int count)
        {
            Invoke((MethodInvoker)delegate
            {
                TotUserRegistered.Text = count.ToString();
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

        }

        public void OnLatencyTest(DataInterceptedEventArgs e)
        {

        }

        public void OnUsername(DataInterceptedEventArgs e)
        {

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

        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
            int index = int.Parse(e.Packet.ReadString());
            var UserLeaveEntity = users.Values.FirstOrDefault(ent => ent.Index == index);
            if (UserLeaveEntity == null) return;

            users.Remove(UserLeaveEntity.Id);
            WriteRegistrationUsers(users.Count);
        }

        public void InUserEnterRoom(DataInterceptedEventArgs obj)
        {
            try
            {
                HEntity[] array = HEntity.Parse(obj.Packet);
                if (array.Length != 0)
                {
                    foreach (HEntity hentity in array)
                    {
                        if (!users.ContainsKey(hentity.Id))
                        {
                            users.Add(hentity.Id, hentity);
                        }
                    }
                }
                WriteRegistrationUsers(users.Count);
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
            TempUserID = e.Packet.ReadInteger();
            if (users.TryGetValue(TempUserID, out var entity))
            {
                SelectedIndex = entity.Index;
                SelectUserLabel.Invoke((MethodInvoker)delegate
                {
                    SelectUserLabel.Text = entity.Name;
                    if(!LockNickname)
                    {
                        UserNickname = entity.Name;
                    }
                    if(!LockMotto)
                    {
                        UserMotto = entity.Motto;
                    }
                    if(!LockLook)
                    {
                        UserLook = entity.FigureId;
                    }
                });
            }
        }

        public void inUserProfile(DataInterceptedEventArgs e)
        {

        }

        private void RemoveUserFromRoomBtn_Click(object sender, EventArgs e)
        {
            RemoveUser(SelectedIndex);
        }

        private void RemoveUser(int index)
        {
            Connection.SendToClientAsync(In.RoomUserRemove, index.ToString());
        }



        private void ReplaceUser(string nickname, string motto, string look)
        {
            if (users.TryGetValue(TempUserID, out var entity))
            {
                RemoveUser(SelectedIndex);
                Connection.SendToClientAsync(In.RoomUsers,
                    1,
                    entity.Id,
                    nickname,
                    motto,
                    look,
                    SelectedIndex,
                    entity.Tile.X,
                    entity.Tile.Y,
                    entity.Tile.Z.ToString(),
                    1,
                    1,
                    ((char)entity.Gender).ToString(),
                   1,
                   1,
                    entity.FavoriteGroup,
                    "",
                    1,
                    false
            );


            }
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            ReplaceUser(UserNickname, UserMotto, UserLook);
        }

        private void lockLookChbx_CheckedChanged(object sender, EventArgs e)
        {
            if(LockLook)
            {
                EnableTxbx(LookTxbx, true);
            }
            else
            {
                EnableTxbx(LookTxbx, false);
            }
        }

        private void LockMottoBoxChbx_CheckedChanged(object sender, EventArgs e)
        {
            if (LockMotto)
            {
                EnableTxbx(MottoTxbx, true);
            }
            else
            {
                EnableTxbx(MottoTxbx, false);
            }
        }

        private void LockNicknameBoxChbx_CheckedChanged(object sender, EventArgs e)
        {
            if (LockNickname)
            {
                EnableTxbx(UserNameTxbx, true);
            }
            else
            {
                EnableTxbx(UserNameTxbx, false);
            }
        }
    }
}
