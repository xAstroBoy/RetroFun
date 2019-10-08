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
using System.Threading;
using Sulakore.Components;
using Sulakore.Modules;
using Sulakore.Communication;
using RetroFun.Subscribers;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class GiftEditor : ObservablePage , ISubscriber
    {
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

        public GiftEditor()
        {
            InitializeComponent();
            Bind(AnonymousChbx, "Checked", nameof(isAnonymous));
            Bind(LoopCoolDown, "Value", nameof(SpeedTimer));
            Bind(PageIDBox, "Value", nameof(PageIDInt));
            Bind(FurniIDBox, "Value", nameof(FurniIDint));

            SpeedTimer = 6000;
            PageIDInt = 0;
            FurniIDint = 0;
            //Triggers.InAttach(In.PurchaseOK, CooldownEnabler);
        }

        private void SendGiftBtn_Click_1(object sender, EventArgs e)
        {
            SendPacket();
        }

        private void SButtonLoopToggle_Click(object sender, EventArgs e)
        {
            CheckLoopStatus();
        }

        private void PageIdBruteforcerbtx_Click(object sender, EventArgs e)
        {
            CheckPageIDBruteforcer();
        }

        private void FurnIDBruteForcerbtx_Click(object sender, EventArgs e)
        {
            CheckFurniIDBruteforcer();
        }


        private void BruteForceBtn_Click(object sender, EventArgs e)
        {
            CheckBruteForcer();
        }

        private void CheckLoopStatus()
        {
            if (EnableLoop)
            {
                EnableLoop = false;
                WriteToButton(SButtonLoopToggle, "Send The Gift On loop : Disabled");
            }
            else
            {
                EnableLoop = true;
                WriteToButton(SButtonLoopToggle, "Send The Gift On loop : Enabled");
                StartLoop();
            }
        }


        private void CheckFurniIDBruteforcer()
        {
            if (FurnIIDBruteforcerEnabled)
            {
                FurnIIDBruteforcerEnabled = false;
                EnableButton(BruteForceBtn, true);
                EnableButton(PageIdBruteforcerbtx, true);
                EnableNButton(PageIDBox, true);
                EnableNButton(FurniIDBox, true);
                WriteToButton(FurnIDBruteForcerbtx, "FurniID Bruteforcer : Disabled");
            }
            else
            {
                FurnIIDBruteforcerEnabled = true;
                EnableButton(BruteForceBtn, false);
                EnableButton(PageIdBruteforcerbtx, false);
                EnableNButton(PageIDBox, false);
                EnableNButton(FurniIDBox, false);
                WriteToButton(FurnIDBruteForcerbtx, "FurniID Bruteforcer : Enabled");
                BruteForceFurniID();
            }
        }

        private void CheckPageIDBruteforcer()
        {
            if (PageIDBruteForcerEnabled)
            {
                PageIDBruteForcerEnabled = false;
                EnableButton(BruteForceBtn, true);
                EnableButton(FurnIDBruteForcerbtx, true);
                EnableNButton(PageIDBox, true);
                EnableNButton(FurniIDBox, true);
                WriteToButton(PageIdBruteforcerbtx, "PageID Bruteforcer : Disabled");
            }
            else
            {
                PageIDBruteForcerEnabled = true;
                EnableButton(BruteForceBtn, false);
                EnableButton(FurnIDBruteForcerbtx, false);
                EnableNButton(PageIDBox, false);
                EnableNButton(FurniIDBox, false);
                WriteToButton(PageIdBruteforcerbtx, "PageID Bruteforcer : Enabled");
                BruteForcePageID();
            }
        }

        private void CheckBruteForcer()
        {
            if (GlobalBruteforcerEnabled)
            {
                GlobalBruteforcerEnabled = false;
                EnableButton(PageIdBruteforcerbtx, true);
                EnableButton(FurnIDBruteForcerbtx, true);
                EnableNButton(PageIDBox, true);
                EnableNButton(FurniIDBox, true);
                WriteToButton(BruteForceBtn, "BruteForcer : Disabled");
            }
            else
            {
                GlobalBruteforcerEnabled = true;
                EnableButton(PageIdBruteforcerbtx, false);
                EnableButton(FurnIDBruteForcerbtx, false);
                EnableNButton(PageIDBox, false);
                EnableNButton(FurniIDBox, false);
                WriteToButton(BruteForceBtn, "BruteForcer : Enabled");
                GlobalBruteForcer();
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


        public void OnOutDiceTrigger(DataInterceptedEventArgs e) { }


        private void SendPacket()
        {

            if (String.IsNullOrEmpty(UsernameTextBox.Text))
            {
                return;
            }

            Connection.SendToServerAsync(
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

        private void SendTestPacket(string GiftBoxTest)
        {
            Connection.SendToServerAsync(
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


                Thread.CurrentThread.Name = "PageIDBRuteforcer";
                Thread.CurrentThread.IsBackground = true;

                if (String.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    PageIDBruteForcerEnabled = false;
                    EnableButton(BruteForceBtn, true);
                    EnableButton(FurnIDBruteForcerbtx, true);
                    EnableNButton(PageIDBox, true);
                    EnableNButton(FurniIDBox, true);
                    WriteToButton(PageIdBruteforcerbtx, "PageID Bruteforcer : Disabled");
                    Thread.CurrentThread.Abort();
                    return;
                }

                do
                {
                    if (Purchased)
                    {
                        Thread.Sleep(SpeedTimer);
                        Purchased = false;
                    }

                    if (PageIDInt == int.MaxValue)
                    {
                        PageIDBruteForcerEnabled = false;
                        EnableButton(BruteForceBtn, true);
                        EnableButton(FurnIDBruteForcerbtx, true);
                        EnableNButton(PageIDBox, true);
                        EnableNButton(FurniIDBox, true);
                        WriteToButton(PageIdBruteforcerbtx, "PageID Bruteforcer : Disabled");
                        Thread.CurrentThread.Abort();
                        return;
                    }
                    else



                        SendTestPacket("VALID PAGEID : " + PageIDInt + " For FurniID : " + FurniIDint);

                    PageIDInt = PageIDInt + 1;

                } while (PageIDBruteForcerEnabled);

            }).Start();
        }

        private void BruteForceFurniID()
        {
            new Thread(() =>
            {


                Thread.CurrentThread.Name = "FurniIDBRuteforcer";
                Thread.CurrentThread.IsBackground = true;

                if (String.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    FurnIIDBruteforcerEnabled = false;
                    EnableButton(BruteForceBtn, true);
                    EnableButton(PageIdBruteforcerbtx, true);
                    EnableNButton(PageIDBox, true);
                    EnableNButton(FurniIDBox, true);
                    WriteToButton(FurnIDBruteForcerbtx, "FurniID Bruteforcer : Disabled");
                    Thread.CurrentThread.Abort();
                }

                do 
                {
                    if (Purchased)
                    {
                        Thread.Sleep(SpeedTimer);
                        Purchased = false;
                    }

                    if (FurniIDint == int.MaxValue)
                    {
                        FurnIIDBruteforcerEnabled = false;
                        EnableButton(BruteForceBtn, true);
                        EnableButton(PageIdBruteforcerbtx, true);
                        EnableNButton(PageIDBox, true);
                        EnableNButton(FurniIDBox, true);
                        WriteToButton(FurnIDBruteForcerbtx, "FurniID Bruteforcer : Disabled");
                        Thread.CurrentThread.Abort();
                        return;
                    }
                        SendTestPacket("VALID PAGEID : " + PageIDInt + " For FurniID : " + FurniIDint);
                        FurniIDint = FurniIDint + 1;

                } while (FurnIIDBruteforcerEnabled);

            }).Start();
        }

        private void GlobalBruteForcer()
        {
            new Thread(() =>
            {


                Thread.CurrentThread.Name = "GlobalBruteForcer";
                Thread.CurrentThread.IsBackground = true;

                do
                {
                    if (String.IsNullOrEmpty(UsernameTextBox.Text))
                    {
                        GlobalBruteforcerEnabled = false;
                        EnableButton(PageIdBruteforcerbtx, true);
                        EnableButton(FurnIDBruteForcerbtx, true);
                        EnableNButton(PageIDBox, true);
                        EnableNButton(FurniIDBox, true);
                        WriteToButton(BruteForceBtn, "BruteForcer : Disabled");
                        Thread.CurrentThread.Abort();
                        return;
                    }

                    if (Purchased)
                    {
                        Thread.Sleep(SpeedTimer);
                        Purchased = false;
                    }

                    if (FurniIDint == int.MaxValue)
                    {
                        FurniIDint = 0;
                        PageIDInt++;
                    }
                    if (PageIDInt == int.MaxValue)
                    {
                        if (FurniIDint == int.MaxValue)
                        {
                            GlobalBruteforcerEnabled = false;
                            EnableButton(PageIdBruteforcerbtx, true);
                            EnableButton(FurnIDBruteForcerbtx, true);
                            EnableNButton(PageIDBox, true);
                            EnableNButton(FurniIDBox, true);
                            WriteToButton(BruteForceBtn, "BruteForcer : Disabled");
                            Thread.CurrentThread.Abort();
                            return;
                        }
                    }
                    SendTestPacket("VALID PAGEID : " + PageIDInt + " For FurniID : " + FurniIDint);
                    FurniIDint++;
                } while (GlobalBruteforcerEnabled);
            }).Start();
        }
    }
}

