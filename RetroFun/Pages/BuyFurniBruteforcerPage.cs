using System;
using System.ComponentModel;
using System.Windows.Forms;
using RetroFun.Controls;
using System.Threading;
using Sulakore.Components;
using Sulakore.Communication;
using RetroFun.Subscribers;
using Sulakore.Modules;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class BuyFurniBruteforcerPage : ObservablePage, ISubscriber
    {
        public BuyFurniBruteforcerPage()
        {
            InitializeComponent();
            Bind(PurchaseLoopCoolDown, "Value", nameof(SpeedTimer1));
            Bind(CataloguePageIDBox, "Value", nameof(PageIDInt1));
            Bind(CatalogueFurniIDBox, "Value", nameof(FurniIDint1));
            Bind(isValidPurchcheck, "Checked", nameof(PurchaseSuccess));
            Bind(furnITextBox, "Text", nameof(TextBox));

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

        private bool PageIDBruteForcerEnabled1;
        private bool FurnIIDBruteforcerEnabled1;
        private bool GlobalBruteforcerEnabled1;

        private int _SpeedTimer1;
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


        private string _TextBox = "";
        public string TextBox
        {
            get => _TextBox;
            set
            {
                _TextBox = value;
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



        private void SendPurchaseBtn_Click(object sender, EventArgs e)
        {
            SendPacket(PageIDInt1, FurniIDint1);
        }

        private void CatalogueSButtonLoopToggle_Click(object sender, EventArgs e)
        {
            CheckLoopStatus();
        }

        private void CataloguePageIdBruteforcerbtx_Click(object sender, EventArgs e)
        {
            CheckPageIDBruteforcer();
        }

        private void CatalogueFurnIDBruteForcerbtx_Click(object sender, EventArgs e)
        {
            CheckFurniIDBruteforcer();
        }

        public void OnOutUserRequestBadge(DataInterceptedEventArgs e) { }


        private void CatalogueBruteForceBtn_Click(object sender, EventArgs e)
        {
            CheckBruteForcer();
        }

        private void CheckLoopStatus()
        {
            if (EnableLoop)
            {
                EnableLoop = false;
                WriteToButton(CatalogueSButtonLoopToggle, "Buy On loop : Off");
            }
            else
            {
                EnableLoop = true;
                WriteToButton(CatalogueSButtonLoopToggle, "Buy On loop : On");
                StartLoop();
            }
        }

        private void CheckFurniIDBruteforcer()
        {
            if (FurnIIDBruteforcerEnabled1)
            {
                FurnIIDBruteforcerEnabled1 = false;

                EnableButton(CatalogueBruteForceBtn, true);
                EnableButton(CataloguePageIdBruteforcerbtx, true);
                EnableNButton(CataloguePageIDBox, true);
                EnableNButton(CatalogueFurniIDBox, true);
                WriteToButton(CatalogueFurnIDBruteForcerbtx, "FurniID Bruteforcer : Off");
            }
            else
            {
                FurnIIDBruteforcerEnabled1 = true;
                EnableButton(CatalogueBruteForceBtn, false);
                EnableButton(CataloguePageIdBruteforcerbtx, false);
                EnableNButton(CataloguePageIDBox, false);
                EnableNButton(CatalogueFurniIDBox, false);
                WriteToButton(CatalogueFurnIDBruteForcerbtx, "FurniID Bruteforcer : On");
                BruteForceFurniID();
            }
        }

        private void CheckPageIDBruteforcer()
        {
            if (PageIDBruteForcerEnabled1)
            {
                PageIDBruteForcerEnabled1 = false;
                EnableButton(CatalogueBruteForceBtn, true);
                EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                EnableNButton(CataloguePageIDBox, true);
                EnableNButton(CatalogueFurniIDBox, true);
                WriteToButton(CataloguePageIdBruteforcerbtx, "PageID Bruteforcer : Off");
            }
            else
            {
                PageIDBruteForcerEnabled1 = true;
                EnableButton(CatalogueBruteForceBtn, false);
                EnableButton(CatalogueFurnIDBruteForcerbtx, false);
                EnableNButton(CataloguePageIDBox, false);
                EnableNButton(CatalogueFurniIDBox, false);
                WriteToButton(CataloguePageIdBruteforcerbtx, "PageID Bruteforcer : On");
                BruteForcePageID();
            }
        }

        private void CheckBruteForcer()
        {
            if (GlobalBruteforcerEnabled1)
            {
                GlobalBruteforcerEnabled1 = false;
                EnableButton(CataloguePageIdBruteforcerbtx, true);
                EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                EnableNButton(CataloguePageIDBox, true);
                EnableNButton(CatalogueFurniIDBox, true);
                WriteToButton(CatalogueBruteForceBtn, "BruteForcer : Off");
            }
            else
            {
                GlobalBruteforcerEnabled1 = true;
                EnableButton(CataloguePageIdBruteforcerbtx, false);
                EnableButton(CatalogueFurnIDBruteForcerbtx, false);
                EnableNButton(CataloguePageIDBox, false);
                EnableNButton(CatalogueFurniIDBox, false);
                WriteToButton(CatalogueBruteForceBtn, "BruteForcer : On");
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

        private void ToggleCheck(CheckBox button, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Checked = enabled;
            });
        }

        public bool IsReceiving => true;

        public void OnOutDiceTrigger(DataInterceptedEventArgs e) { }

        public void OnUserFriendRemoval(DataInterceptedEventArgs e) { }

        public void InPurchaseOk(DataInterceptedEventArgs e)
        {
            PurchaseSuccess = true;
        }


        private void SendPacket(int PageID, int FurniID)
        {
            Connection.SendToServerAsync(
            Out.CatalogBuyItem,
            PageID,
            FurniID,
            TextBox
            );
        }

        private void StartLoop()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do 
                {
                    SendPacket(PageIDInt1, FurniIDint1);
                    Thread.Sleep(SpeedTimer1);
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
                    if (PageIDInt1 == int.MaxValue)
                    {
                        PageIDBruteForcerEnabled1 = false;

                        EnableButton(CatalogueBruteForceBtn, true);
                        EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                        EnableNButton(CataloguePageIDBox, true);
                        EnableNButton(CatalogueFurniIDBox, true);
                        WriteToButton(CataloguePageIdBruteforcerbtx, "PageID Bruteforcer : Off");
                        Thread.CurrentThread.Abort();
                        return;
                    }
                    SendPacket(PageIDInt1, FurniIDint1);
                    if (PurchaseSuccess)
                    {
                        Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + FurniIDint1, 0, 34, 0, -1);
                        PurchaseSuccess = false;
                    }
                    PageIDInt1++;
                    Thread.Sleep(SpeedTimer1);
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

                    if (FurniIDint1 == int.MaxValue)
                    {
                        FurnIIDBruteforcerEnabled1 = false;
                        EnableButton(CatalogueBruteForceBtn, true);
                        EnableButton(CataloguePageIdBruteforcerbtx, true);
                        EnableNButton(CataloguePageIDBox, true);
                        EnableNButton(CatalogueFurniIDBox, true);
                        WriteToButton(CatalogueFurnIDBruteForcerbtx, "FurniID Bruteforcer : Off");
                        Thread.CurrentThread.Abort();
                        return;
                    }
                    SendPacket(PageIDInt1, FurniIDint1);
                    if (PurchaseSuccess)
                    {
                        Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + FurniIDint1, 0, 34, 0, -1);
                        PurchaseSuccess = false;
                    }
                    FurniIDint1++;
                    Thread.Sleep(SpeedTimer1);

                } while (FurnIIDBruteforcerEnabled1);

            }).Start();
        }

        private void GlobalBruteForcer()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (FurniIDint1 == int.MaxValue)
                    {
                        FurniIDint1 = 0;
                        PageIDInt1++;
                    }
                    if (PageIDInt1 == int.MaxValue)
                    {
                        if (FurniIDint1 == int.MaxValue)
                        {
                            GlobalBruteforcerEnabled1 = false;
                            EnableButton(CataloguePageIdBruteforcerbtx, true);
                            EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                            EnableNButton(CataloguePageIDBox, true);
                            EnableNButton(CatalogueFurniIDBox, true);
                            WriteToButton(CatalogueBruteForceBtn, "BruteForcer : Off");
                            Thread.CurrentThread.Abort();
                            return;
                        }
                    }
                    FurniIDint1++;
                    SendPacket(PageIDInt1, FurniIDint1);
                    if (PurchaseSuccess)
                    {
                        Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + FurniIDint1, 0, 34, 0, -1);
                        PurchaseSuccess = false;
                      }
                    Thread.Sleep(SpeedTimer1);

                } while (GlobalBruteforcerEnabled1);
            }).Start();
        }
    }
}
