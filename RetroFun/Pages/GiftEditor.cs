using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class GiftEditor : ObservablePage, ISubscriber
    {
        #region miscvars

        private bool _isAnonymous;

        public bool isAnonymous
        {
            get => _isAnonymous;
            set
            {
                _isAnonymous = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _EnableLoop;

        public bool EnableLoop
        {
            get => _EnableLoop;
            set
            {
                _EnableLoop = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _PageIDBruteForcerEnabled;

        public bool PageIDBruteForcerEnabled
        {
            get => _PageIDBruteForcerEnabled;
            set
            {
                _PageIDBruteForcerEnabled = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _FurnIIDBruteforcerEnabled;

        public bool FurnIIDBruteforcerEnabled
        {
            get => _FurnIIDBruteforcerEnabled;
            set
            {
                _FurnIIDBruteforcerEnabled = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _GlobalBruteforcerEnabled;

        public bool GlobalBruteforcerEnabled
        {
            get => _GlobalBruteforcerEnabled;
            set
            {
                _GlobalBruteforcerEnabled = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _SpeedTimer = 100;

        public int SpeedTimer
        {
            get => _SpeedTimer;
            set
            {
                _SpeedTimer = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _PageIDInt = 0;

        public int PageIDInt
        {
            get => _PageIDInt;
            set
            {
                _PageIDInt = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FurniIDint = 0;

        public int FurniIDint
        {
            get => _FurniIDint;
            set
            {
                _FurniIDint = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _Purchased;

        public bool Purchased
        {
            get => _Purchased;
            set
            {
                _Purchased = value;
                RaiseOnPropertyChanged();
            }
        }

        #endregion miscvars

        public GiftEditor()
        {
            InitializeComponent();
            Bind(AnonymousChbx, "Checked", nameof(isAnonymous));
            Bind(LoopCoolDown, "Value", nameof(SpeedTimer));

            Bind(PurchaseLoopCoolDown, "Value", nameof(SpeedTimer1));
            Bind(CataloguePageIDBox, "Value", nameof(PageIDInt1));
            Bind(CatalogueFurniIDBox, "Value", nameof(FurniIDint1));
            Bind(PageIDRangeNbx, "Value", nameof(PageIDIntRange));
            Bind(FurniIDRangeNbx, "Value", nameof(FurniIDIntRange));

            Bind(PageIDRangeChbx, "Checked", nameof(PageIDRangeToggle));
            Bind(FurniIDRangeChbx, "Checked", nameof(FurniIDRangeToggle));
            Bind(PageIDOptionChbx, "Checked", nameof(PageIDOptionToggle));
            Bind(FurniIDOptionChbx, "Checked", nameof(FurniIDOptionToggle));

            Bind(furnITextBox, "Text", nameof(FurniIDStringBox));

            Bind(UsernameTextBox, "Text", nameof(GiftReceiver));

        }


        private bool PageIDBruteForcerEnabled1;
        private bool FurnIIDBruteforcerEnabled1;
        private bool GlobalBruteforcerEnabled1;
        private int _SpeedTimer1 = 100;

        public int SpeedTimer1
        {
            get => _SpeedTimer1;
            set
            {
                _SpeedTimer1 = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _PageIDInt1;

        public int PageIDInt1
        {
            get => _PageIDInt1;
            set
            {
                _PageIDInt1 = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FurniIDint1;

        public int FurniIDint1
        {
            get => _FurniIDint1;
            set
            {
                _FurniIDint1 = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _PageIDIntRange = 0;

        public int PageIDIntRange
        {
            get => _PageIDIntRange;
            set
            {
                _PageIDIntRange = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FurniIDIntRange = 0;

        public int FurniIDIntRange
        {
            get => _FurniIDIntRange;
            set
            {
                _FurniIDIntRange = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _FurniIDRangeToggle;

        public bool FurniIDRangeToggle
        {
            get => _FurniIDRangeToggle;
            set
            {
                _FurniIDRangeToggle = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _CaptureModeCatalog;

        public bool GiftCaptureModeCatalog
        {
            get => _CaptureModeCatalog;
            set
            {
                _CaptureModeCatalog = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _PageIDRangeToggle;

        public bool PageIDRangeToggle
        {
            get => _PageIDRangeToggle;
            set
            {
                _PageIDRangeToggle = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _FurniIDOptionToggle = true;

        public bool FurniIDOptionToggle
        {
            get => _FurniIDOptionToggle;
            set
            {
                _FurniIDOptionToggle = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _PageIDOptionToggle;

        public bool PageIDOptionToggle
        {
            get => _PageIDOptionToggle;
            set
            {
                _PageIDOptionToggle = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _FurniIDStringBox = "";

        public string FurniIDStringBox
        {
            get => _FurniIDStringBox;
            set
            {
                _FurniIDStringBox = value;
                RaiseOnPropertyChanged();
            }
        }


        private string _GiftReceiver;

        public string GiftReceiver
        {
            get => _GiftReceiver;
            set
            {
                _GiftReceiver = value;
                RaiseOnPropertyChanged();
            }
        }


        private string _FileNameSave = "Unnamed.RetroFun";

        public string FileNameSave
        {
            get => _FileNameSave;
            set
            {
                _FileNameSave = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _PurchaseSuccess;

        public bool PurchaseSuccess
        {
            get => _PurchaseSuccess;
            set
            {
                _PurchaseSuccess = value;
                RaiseOnPropertyChanged();
            }
        }



        private void SendGiftBtn_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(GiftReceiver))
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Gift BruteForcer]: You need to put a username !", 0, 1, 0, -1);
                return;

            }
            else
            {
                SendPacket();
            }
        }

        private void SButtonLoopToggle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(GiftReceiver))
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Gift BruteForcer]: You need to put a username !", 0, 1, 0, -1);
                return;

            }
            else
            {
                CheckLoopStatus();
            }
        }




        private void CheckLoopStatus()
        {
            if (EnableLoop)
            {
                EnableLoop = false;
                WriteToButton(SButtonLoopToggle, "Send The Gift On loop : Off");
            }
            else
            {
                EnableLoop = true;
                WriteToButton(SButtonLoopToggle, "Send The Gift On loop : On");
                StartLoop();
            }
        }







        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }

        private void EnableNButton(NumericUpDown button, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = enabled;
            });
        }

        private void EnableButton(SKoreButton button, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = enabled;
            });
        }

        public bool IsReceiving => true;

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
            Purchased = true;
        }
        public void OnLatencyTest(DataInterceptedEventArgs e)
        {
        }
        public void OnUsername(DataInterceptedEventArgs e)
        {
        }
        public void OnRequestRoomLoad(DataInterceptedEventArgs e)
        {
        }

        public void OnCatalogBuyItem(DataInterceptedEventArgs e)
        {
            if (GiftCaptureModeCatalog)
            {
                PageIDInt1 = e.Packet.ReadInteger();
                FurniIDint1 = e.Packet.ReadInteger();
                GiftCaptureModeCatalog = false;
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Gift Bruteforcer]: Required Data Found, Check RetroFun.", 0, 1, 0, -1);
                WriteToButton(CaptureCatalogGiftDataBtn, "Capture Mode : OFF");
                e.IsBlocked = true;

            }
        }


        public void InRoomUserLeft(DataInterceptedEventArgs e)
        {
        }

        public void InUserEnterRoom(DataInterceptedEventArgs e)
        {
        }

        public void InItemExtraData(DataInterceptedEventArgs e)
        {
        }

        public void OnOutDiceTrigger(DataInterceptedEventArgs e)
        {
        }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e)
        {
        }

        public void InUserProfile(DataInterceptedEventArgs e)
        {
        }

        public void InRoomData(DataInterceptedEventArgs e)
        {

        }
        public void OnRoomUserWalk(DataInterceptedEventArgs e)
        {
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e)
        {
        }

        private async void SendPacket()
        {
            if (String.IsNullOrEmpty(UsernameTextBox.Text))
            {
               return;
            }
            if (Connection.Remote.IsConnected)
            {
               await  Connection.SendToServerAsync(
            Out.CatalogBuyItemAsGift,
            PageIDInt,
            FurniIDint,
            furnITextBox.Text,
            UsernameTextBox.Text,
            GiftTextBox.Text,
            3376,
            5,
            0,
            isAnonymous
            );
            }
        }

        private async void SendBruteForceGiftPacket(string GiftBoxTest)
        {
            if (Connection.Remote.IsConnected)
            {
                await Connection.SendToServerAsync(
            Out.CatalogBuyItemAsGift,
            PageIDInt,
            FurniIDint,
            furnITextBox.Text,
            UsernameTextBox.Text,
            GiftBoxTest,
            3376,
            5,
            0,
            isAnonymous
            );
            }
        }

        private void StartLoop()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.Name = "GiftThread";
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    SendPacket();
                    Thread.Sleep(SpeedTimer);
                } while (EnableLoop);
            }).Start();
        }



        private void BruteForcePageID()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (!PageIDRangeToggle)
                    {
                        if (PageIDInt1 == int.MaxValue)
                        {
                            StopPageIDBruteforcer();
                        }
                    }
                    else
                    {
                        if (PageIDInt1 == PageIDIntRange)
                        {
                            StopPageIDBruteforcer();
                        }
                    }
                    SendBruteForceGiftPacket("FOUND VALID PAGEID :" + PageIDInt1 + " AND FURNIID : " + FurniIDint1);
                    Thread.Sleep(SpeedTimer1);
                    PageIDInt1++;
                } while (PageIDBruteForcerEnabled1);
            }).Start();
        }

        private void BruteForceFurniID()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                do
                {
                    if (!FurniIDRangeToggle)
                    {
                        if (FurniIDint1 == int.MaxValue)
                        {
                            StopFurniIDBruteforcer();
                        }
                    }
                    else
                    {
                        if (FurniIDint1 == FurniIDIntRange)
                        {
                            StopFurniIDBruteforcer();
                        }
                    }
                    SendBruteForceGiftPacket("FOUND VALID PAGEID :" + PageIDInt1 + " AND FURNIID : " + FurniIDint1);
                    FurniIDint1++;
                    Thread.Sleep(SpeedTimer1);
                } while (FurnIIDBruteforcerEnabled1);
            }).Start();
        }



        private void FurniIDGlobalBruteForce()
        {
            if (!FurniIDRangeToggle)
            {
                if (FurniIDint1 == int.MaxValue)
                {
                    FurniIDint1 = 0;
                    PageIDInt1++;
                }
            }
            else
            {
                if (FurniIDint1 == FurniIDIntRange)
                {
                    FurniIDint1 = 0;
                    PageIDInt1++;
                }
            }
            if (!PageIDRangeToggle)
            {
                if (PageIDInt1 == int.MaxValue)
                {
                    if (FurniIDint1 == int.MaxValue)
                    {
                        StopGlobalBruteforcer();
                    }
                }
            }
            else
            {
                if (PageIDInt1 == PageIDIntRange)
                {
                    if (!FurniIDRangeToggle)
                    {
                        if (FurniIDint1 == int.MaxValue)
                        {
                            StopGlobalBruteforcer();
                        }
                    }
                    else
                    {
                        if (FurniIDint1 == FurniIDIntRange)
                        {
                            StopGlobalBruteforcer();
                        }
                        if (FurniIDint1 == FurniIDIntRange && PageIDInt1 == PageIDIntRange)
                        {
                            StopGlobalBruteforcer();
                        }
                    }
                }
            }
            FurniIDint1++;
        }



        private void GlobalPageIDBruteforcer()
        {
            if (!PageIDRangeToggle)
            {
                if (PageIDInt1 == int.MaxValue)
                {
                    PageIDInt1 = 0;
                    FurniIDint1++;
                }
            }
            else
            {
                if (PageIDInt1 == PageIDIntRange)
                {
                    PageIDInt1 = 0;
                    FurniIDint1++;
                }
            }
            if (!PageIDRangeToggle)
            {
                if (PageIDInt1 == int.MaxValue)
                {
                    if (FurniIDint1 == int.MaxValue)
                    {
                        StopGlobalBruteforcer();
                    }
                }
            }
            else
            {
                if (PageIDInt1 == PageIDIntRange)
                {
                    if (!FurniIDRangeToggle)
                    {
                        if (FurniIDint1 == int.MaxValue)
                        {
                            StopGlobalBruteforcer();
                        }
                    }
                    else
                    {
                        if (FurniIDint1 == FurniIDIntRange)
                        {
                            StopGlobalBruteforcer();
                        }
                        if (FurniIDint1 == FurniIDIntRange && PageIDInt1 == PageIDIntRange)
                        {
                            StopGlobalBruteforcer();
                        }
                    }
                }
            }
            PageIDInt1++;
        }





        private void GlobalBruteForcer()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (FurniIDOptionToggle)
                    {
                        FurniIDGlobalBruteForce();
                    }
                    if (PageIDOptionToggle)
                    {
                        GlobalPageIDBruteforcer();
                    }
                    SendBruteForceGiftPacket("FOUND VALID PAGEID :" +  PageIDInt1 + " AND FURNIID : " +  FurniIDint1);
                    Thread.Sleep(SpeedTimer1);
                } while (GlobalBruteforcerEnabled1);
            }).Start();
        }








        private void StopGlobalBruteforcer()
        {
            GlobalBruteforcerEnabled1 = false;
            EnableButton(GiftPageIDBruteForcerBtn, true);
            EnableButton(GiftFurniIDBruteforcerBtn, true);
            EnableNButton(CataloguePageIDBox, true);
            EnableNButton(CatalogueFurniIDBox, true); 
            WriteToButton(GiftBruteForceBtn, "BruteForcer : Off");
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing Completed.", 0, 1, 0, -1);
            }
            Thread.CurrentThread.Abort();
            return;
        }

        private void StopFurniIDBruteforcer()
        {
            FurnIIDBruteforcerEnabled1 = false;
            EnableButton(GiftBruteForceBtn, true);
            EnableButton(GiftPageIDBruteForcerBtn, true);
            EnableNButton(CataloguePageIDBox, true);
            EnableNButton(CatalogueFurniIDBox, true);
            WriteToButton(GiftFurniIDBruteforcerBtn, "FurniID Bruteforcer : Off");
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing FurniID Completed.", 0, 1, 0, -1);
            }
            Thread.CurrentThread.Abort();
            return;
        }

        private void StopPageIDBruteforcer()
        {
            PageIDBruteForcerEnabled1 = false;
            EnableButton(GiftBruteForceBtn, true);
            EnableButton(GiftFurniIDBruteforcerBtn, true);
            EnableNButton(CataloguePageIDBox, true);
            EnableNButton(CatalogueFurniIDBox, true);
            WriteToButton(GiftPageIDBruteForcerBtn, "PageID Bruteforcer : Off");
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing PageID Completed." + FurniIDint1, 0, 1, 0, -1);
            }
            Thread.CurrentThread.Abort();
            return;
        }

        private void GiftFurniIDBruteforcerBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(GiftReceiver))
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Gift BruteForcer]: You need to put a username !", 0, 1, 0, -1);
                return;

            }
            CheckFurniIDBruteforcer();
        }

        private void GiftPageIDBruteForcerBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(GiftReceiver))
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Gift BruteForcer]: You need to put a username !", 0, 1, 0, -1);
                return;

            }
            else
            {
                CheckPageIDBruteforcer();
            }
        }

        private void GiftBruteForceBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(GiftReceiver))
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Gift BruteForcer]: You need to put a username !", 0, 1, 0, -1);
                return;

            }
            else
            {
                CheckGiftBruteForcer();
            }
        }


        private void CheckFurniIDBruteforcer()
        {
            if (FurnIIDBruteforcerEnabled1)
            {
                FurnIIDBruteforcerEnabled1 = false;

                EnableButton(GiftBruteForceBtn, true);
                EnableButton(GiftPageIDBruteForcerBtn, true);
                EnableNButton(CataloguePageIDBox, true);
                EnableNButton(CatalogueFurniIDBox, true);
                WriteToButton(GiftFurniIDBruteforcerBtn, "FurniID Bruteforcer : Off");
            }
            else
            {
                FurnIIDBruteforcerEnabled1 = true;
                EnableButton(GiftBruteForceBtn, false);
                EnableButton(GiftPageIDBruteForcerBtn, false);
                EnableNButton(CataloguePageIDBox, false);
                EnableNButton(CatalogueFurniIDBox, false);
                WriteToButton(GiftFurniIDBruteforcerBtn, "FurniID Bruteforcer : On");
                BruteForceFurniID();
            }
        }

        private void CheckPageIDBruteforcer()
        {
            if (PageIDBruteForcerEnabled1)
            {
                PageIDBruteForcerEnabled1 = false;
                EnableButton(GiftBruteForceBtn, true);
                EnableButton(GiftFurniIDBruteforcerBtn, true);
                EnableNButton(CataloguePageIDBox, true);
                EnableNButton(CatalogueFurniIDBox, true);
                WriteToButton(GiftPageIDBruteForcerBtn, "PageID Bruteforcer : Off");
            }
            else
            {
                PageIDBruteForcerEnabled1 = true;
                EnableButton(GiftBruteForceBtn, false);
                EnableButton(GiftFurniIDBruteforcerBtn, false);
                EnableNButton(CataloguePageIDBox, false);
                EnableNButton(CatalogueFurniIDBox, false);
                WriteToButton(GiftPageIDBruteForcerBtn, "PageID Bruteforcer : On");
                BruteForcePageID();
            }
        }

        private void CheckGiftBruteForcer()
        {
            if (GlobalBruteforcerEnabled1)
            {
                GlobalBruteforcerEnabled1 = false;
                EnableButton(GiftPageIDBruteForcerBtn, true);
                EnableButton(GiftFurniIDBruteforcerBtn, true);
                EnableNButton(CataloguePageIDBox, true);
                EnableNButton(CatalogueFurniIDBox, true);
                WriteToButton(GiftBruteForceBtn, "BruteForcer : Off");
            }
            else
            {
                GlobalBruteforcerEnabled1 = true;
                EnableButton(GiftPageIDBruteForcerBtn, false);
                EnableButton(GiftFurniIDBruteforcerBtn, false);
                EnableNButton(CataloguePageIDBox, false);
                EnableNButton(CatalogueFurniIDBox, false);
                WriteToButton(GiftBruteForceBtn, "BruteForcer : On");
                GlobalBruteForcer();
            }
        }

        private void PageIDRangeChbx_CheckedChanged(object sender, EventArgs e)
        {
            if (!PageIDRangeToggle)
            {
                EnableNButton(PageIDRangeNbx, true);
            }
            else
            {
                EnableNButton(PageIDRangeNbx, false);
            }
        }

        private void FurniIDRangeChbx_CheckedChanged(object sender, EventArgs e)
        {
            if (!FurniIDRangeToggle)
            {
                EnableNButton(FurniIDRangeNbx, true);
            }
            else
            {
                EnableNButton(FurniIDRangeNbx, false);
            }
        }

        private void CaptureCatalogGiftDataBtn_Click(object sender, EventArgs e)
        {
            if (GiftCaptureModeCatalog)
            {
                GiftCaptureModeCatalog = false;
                WriteToButton(CaptureCatalogGiftDataBtn, "Capture Mode : OFF");
            }
            else
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Gift Bruteforcer]: Please purchase a furni in catalog to intercept the pageid and furniid", 0, 1, 0, -1);
                GiftCaptureModeCatalog = true;
                WriteToButton(CaptureCatalogGiftDataBtn, "Capture Mode : ON");
            }

        }
        public void OnRoomUserTalk(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserShout(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserWhisper(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserTalk(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserShout(DataInterceptedEventArgs e)
        {

        }

        public void InRoomUserWhisper(DataInterceptedEventArgs e)
        {

        }

        public void OnRoomUserStartTyping(DataInterceptedEventArgs e)
        {
        }

        public void InFloorItemUpdate(DataInterceptedEventArgs e)
        {
        }
    }
}