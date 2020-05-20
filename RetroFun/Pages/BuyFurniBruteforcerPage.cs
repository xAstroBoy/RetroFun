using RetroFun.Controls;
using RetroFun.Helpers;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroFun.Pages
{

    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class BuyFurniBruteforcerPage:  ObservablePage
    {



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
        private string FurniName;
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

        private int _GlobalSleeper;

        public int GlobalSleeper
        {
            get => _GlobalSleeper;
            set
            {
                _GlobalSleeper = value;
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

        public bool CaptureModeCatalog
        {
            get => _CaptureModeCatalog;
            set
            {
                _CaptureModeCatalog = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _FileNameLockToggle;

        public bool FileNameLockToggle
        {
            get => _FileNameLockToggle;
            set
            {
                _FileNameLockToggle = value;
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

        private string _FileNameSave;

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

        private bool _ShowPurchase = false;

        public bool ShowPurchase
        {
            get => _ShowPurchase;
            set
            {
                _ShowPurchase = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _ShowPurchaseFurniName = true;

        public bool ShowPurchaseFurniName
        {
            get => _ShowPurchaseFurniName;
            set
            {
                _ShowPurchaseFurniName = value;
                RaiseOnPropertyChanged();
            }
        }

        public BuyFurniBruteforcerPage()
        {
            InitializeComponent();
            Bind(PurchaseLoopCoolDown, "Value", nameof(SpeedTimer1));
            Bind(CataloguePageIDBox, "Value", nameof(PageIDInt1));
            Bind(CatalogueFurniIDBox, "Value", nameof(FurniIDint1));
            Bind(PageIDRangeNbx, "Value", nameof(PageIDIntRange));
            Bind(FurniIDRangeNbx, "Value", nameof(FurniIDIntRange));
            Bind(GlobalSleepExtraNbx, "Value", nameof(GlobalSleeper));

            Bind(isValidPurchcheck, "Checked", nameof(PurchaseSuccess));
            Bind(PageIDRangeChbx, "Checked", nameof(PageIDRangeToggle));
            Bind(FurniIDRangeChbx, "Checked", nameof(FurniIDRangeToggle));
            Bind(PurchaseConfirmedChbx, "Checked", nameof(ShowPurchase));
            Bind(FurniNameShowChbx, "Checked", nameof(ShowPurchaseFurniName));
            Bind(CheckLockFileNameChbx, "Checked", nameof(FileNameLockToggle));
            Bind(PageIDOptionChbx, "Checked", nameof(PageIDOptionToggle));
            Bind(FurniIDOptionChbx, "Checked", nameof(FurniIDOptionToggle));

            Bind(FileNameTextBox, "Text", nameof(FileNameSave));
            Bind(furnITextBox, "Text", nameof(TextBox));
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

        private void EnableTxbutton(TextBox button, bool enabled)
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


        public override void Out_CatalogBuyItem(DataInterceptedEventArgs e)
        {
            if(CaptureModeCatalog)
            {
                PageIDInt1 = e.Packet.ReadInteger();
                FurniIDint1 = e.Packet.ReadInteger();
                CaptureModeCatalog = false;
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Catalog Bruteforcer]: Required Data Found, Check RetroFun.", 0, 1, 0, -1);
                WriteToButton(CaptureModeBtn, "Capture Mode : OFF");
                e.IsBlocked = true;
            }
        }

        public override void In_PurchaseOK(DataInterceptedEventArgs e)
        {
            try {
                FurniName = e.Packet.ReadString(4);
                PurchaseSuccess = true;
            }
            catch (System.IndexOutOfRangeException)
            {
                return;
            }
        }


        private async void SendPacket(int PageID, int FurniID)
        {
            if (Connection.Remote.IsConnected)
            {
                await Task.Delay(30);
                await Connection.SendToServerAsync(
                Out.CatalogBuyItem,
                PageID,
                FurniID,
                TextBox,
                1
                );

            }
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
                    SendPacket(PageIDInt1, FurniIDint1);
                    Thread.Sleep(SpeedTimer1 + 15);

                    if (PurchaseSuccess)
                    {
                        StoreToInput(PageIDInt1, FurniIDint1);
                        if (ShowPurchase)
                        {
                            if (Connection.Remote.IsConnected)
                            {
                                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + FurniIDint1, 0, 1, 0, -1);
                            }
                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }
                        if (ShowPurchaseFurniName)
                        {
                            if (Connection.Remote.IsConnected)
                            {
                                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bought Furni with name : " + FurniName, 0, 1, 0, -1);
                            }
                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }

                        Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        PurchaseSuccess = false;
                        FurniName = String.Empty;
                    }
                    PageIDInt1++;
                    StoreNewPageIDAttempt(PageIDInt1);
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
                    SendPacket(PageIDInt1, FurniIDint1);
                    Thread.Sleep(SpeedTimer1 + GlobalSleeper);

                    if (PurchaseSuccess)
                    {
                        StoreToInput(PageIDInt1, (FurniIDint1 - 1));
                        Thread.Sleep(SpeedTimer1 + 15);

                        if (ShowPurchase)
                        {
                            if (Connection.Remote.IsConnected)
                            {
                                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + (FurniIDint1 - 1), 0, 1, 0, -1);
                            }
                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }
                        if (ShowPurchaseFurniName)
                        {
                            if (Connection.Remote.IsConnected)
                            {
                                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bought Furni with name : " + FurniName, 0, 1, 0, -1);
                            }
                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }
                        Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        PurchaseSuccess = false;
                        FurniName = String.Empty;
                    }
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
                    StoreNewPageIDAttempt(PageIDInt1);
                }
            }
            else
            {
                if (FurniIDint1 == FurniIDIntRange)
                {
                    FurniIDint1 = 0;
                    PageIDInt1++;
                    StoreNewPageIDAttempt(PageIDInt1);
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
                    SendPacket(PageIDInt1, FurniIDint1);
                    Thread.Sleep(SpeedTimer1 + 15);
                    if (PurchaseSuccess)
                    {
                        StoreToInput(PageIDInt1, (FurniIDint1 - 1));
                        if (ShowPurchase)
                        {
                            if (Connection.Remote.IsConnected)
                            {
                                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + (FurniIDint1 - 1), 0, 1, 0, -1);
                            }
                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }
                        if (ShowPurchaseFurniName)
                        {
                            if (Connection.Remote.IsConnected)
                            {
                                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bought Furni with name : " + FurniName, 0, 1, 0, -1);
                            }
                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }
                        Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        PurchaseSuccess = false;
                        FurniName = String.Empty;
                    }
                    Thread.Sleep(SpeedTimer1);
                } while (GlobalBruteforcerEnabled1);
            }).Start();
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

        private void StoreToInput(int PageId, int FurniID)
        {
            try { 
            string Filepath = "../RetroFunLogs/" + FileNameSave + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";

            string FolderName = "RetroFunLogs";

            Directory.CreateDirectory("../" + FolderName);

            if (!File.Exists(Filepath))
            {
                using (var txtFile = File.AppendText(Filepath))
                {
                    txtFile.WriteLine("RetroFun BruteForcer Output Generated in " + DateTime.Now.ToString());
                    txtFile.WriteLine("");
                    txtFile.WriteLine("----------------------------------------------------");
                    txtFile.WriteLine("[RetroFun BruteForcer]" + "[" + DateTime.Now.ToString() + "] ");
                    txtFile.WriteLine("Furni Name : " + FurniName);
                    txtFile.WriteLine("PageID : " + PageId.ToString());
                    txtFile.WriteLine("FurnIID : " + FurniID);
                    txtFile.WriteLine("----------------------------------------------------");
                }
            }
            else if (File.Exists(Filepath))
            {
                using (var txtFile = File.AppendText(Filepath))
                {
                    txtFile.WriteLine("");
                    txtFile.WriteLine("----------------------------------------------------");
                    txtFile.WriteLine("[RetroFun BruteForcer]" + "[" + DateTime.Now.ToString() + "] ");
                    txtFile.WriteLine("Furni Name : " + FurniName);
                    txtFile.WriteLine("PageID : " + PageId.ToString());
                    txtFile.WriteLine("FurnIID : " + FurniID);
                    txtFile.WriteLine("----------------------------------------------------");
                }
            }
            }
            catch(DirectoryNotFoundException)
            {

            }
        }

        private void StoreNewPageIDAttempt(int PageId)
        {
            string Filepath = "../RetroFunLogs/" + FileNameSave + "_" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
            string FolderName = "RetroFunLogs";

            Directory.CreateDirectory("../" + FolderName);

            if (!File.Exists(Filepath))
            {
                using (var txtFile = File.AppendText(Filepath))
                {
                    txtFile.WriteLine("RetroFun BruteForcer Output Generated in " + DateTime.Now.ToString());
                    txtFile.WriteLine("");
                    txtFile.WriteLine("----------------------------------------------------");
                    txtFile.WriteLine("[RetroFun BruteForcer]" + "[" + DateTime.Now.ToString() + "]  Testing PageID : " + PageId);
                    txtFile.WriteLine("----------------------------------------------------");
                }
            }
            else if (File.Exists(Filepath))
            {
                using (var txtFile = File.AppendText(Filepath))
                {
                    txtFile.WriteLine("");
                    txtFile.WriteLine("----------------------------------------------------");
                    txtFile.WriteLine("[RetroFun BruteForcer]" + "[" + DateTime.Now.ToString() + "]  Testing PageID : " + PageId);
                    txtFile.WriteLine("----------------------------------------------------");
                }
            }
        }

        private void StopGlobalBruteforcer()
        {
            GlobalBruteforcerEnabled1 = false;
            EnableButton(CataloguePageIdBruteforcerbtx, true);
            EnableButton(CatalogueFurnIDBruteForcerbtx, true);
            EnableNButton(CataloguePageIDBox, true);
            EnableNButton(CatalogueFurniIDBox, true);
            WriteToButton(CatalogueBruteForceBtn, "BruteForcer : Off");
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
            EnableButton(CatalogueBruteForceBtn, true);
            EnableButton(CataloguePageIdBruteforcerbtx, true);
            EnableNButton(CataloguePageIDBox, true);
            EnableNButton(CatalogueFurniIDBox, true);
            WriteToButton(CatalogueFurnIDBruteForcerbtx, "FurniID Bruteforcer : Off");
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
            EnableButton(CatalogueBruteForceBtn, true);
            EnableButton(CatalogueFurnIDBruteForcerbtx, true);
            EnableNButton(CataloguePageIDBox, true);
            EnableNButton(CatalogueFurniIDBox, true);
            WriteToButton(CataloguePageIdBruteforcerbtx, "PageID Bruteforcer : Off");
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing PageID Completed." + FurniIDint1, 0, 1, 0, -1);
            }
            Thread.CurrentThread.Abort();
            return;
        }

        private void CheckLockFileNameChbx_CheckedChanged(object sender, EventArgs e)
        {
            if (!FileNameLockToggle)
            {
                EnableTxbutton(FileNameTextBox, true);
            }
            else
            {
                EnableTxbutton(FileNameTextBox, false);
            }
        }

        private void CaptureModeBtn_Click(object sender, EventArgs e)
        {
            if (CaptureModeCatalog)
            {
                CaptureModeCatalog = false;
                WriteToButton(CaptureModeBtn, "Capture Mode : OFF");
            }
            else
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Catalog Bruteforcer]: Please purchase a furni in catalog to intercept the pageid and furniid", 0, 1, 0, -1);
                CaptureModeCatalog = true;
                WriteToButton(CaptureModeBtn, "Capture Mode : ON");
            }
        }

        private void FindHostNameBtn_Click(object sender, EventArgs e)
        {
            FileNameSave = RecognizeDomain.GetHost(Connection.Host);
        }


        private void BuyWithPreviousPageIDBtn_Click(object sender, EventArgs e)
        {
            PageIDInt1--;
            SendPacket(PageIDInt1, FurniIDint1);
        }

        private void BuyWithPreviousFurnIIDBtn_Click(object sender, EventArgs e)
        {
            FurniIDint1--;
            SendPacket(PageIDInt1, FurniIDint1);
        }

    }
}