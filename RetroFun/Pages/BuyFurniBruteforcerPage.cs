using System;
using System.ComponentModel;
using System.Windows.Forms;
using RetroFun.Controls;
using System.Threading;
using Sulakore.Components;
using Sulakore.Communication;
using RetroFun.Subscribers;
using Sulakore.Modules;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Net;

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
            Bind(PageIDRangeNbx, "Value", nameof(PageIDIntRange));
            Bind(FurniIDRangeNbx, "Value", nameof(FurniIDIntRange));
            Bind(GlobalSleepExtraNbx, "Value", nameof(GlobalSleeper));

            
            Bind(isValidPurchcheck, "Checked", nameof(PurchaseSuccess));
            Bind(PageIDRangeChbx, "Checked", nameof(PageIDRangeToggle));
            Bind(FurniIDRangeChbx, "Checked", nameof(FurniIDRangeToggle));
            Bind(PurchaseConfirmedChbx, "Checked", nameof(ShowOutput));
            Bind(FurniNameShowChbx, "Checked", nameof(ShowOutput1));

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


        private bool _ShowOutput = true;
        public bool ShowOutput
        {
            get => _ShowOutput;
            set
            {
                _ShowOutput = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _ShowOutput1 = true;
        public bool ShowOutput1
        {
            get => _ShowOutput1;
            set
            {
                _ShowOutput1 = value;
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

        public void OnUserLeaveRoom(DataInterceptedEventArgs e) { }
        public void InRoomUserLeft(DataInterceptedEventArgs e) { }
        public void InUserEnterRoom(DataInterceptedEventArgs e) { }
        public void OnOutUserRequestBadge(DataInterceptedEventArgs e) { }
        public void inUserProfile(DataInterceptedEventArgs e) { }


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

            FurniName = e.Packet.ReadString(4);
            PurchaseSuccess = true;
        }


        private void SendPacket(int PageID, int FurniID)
        {
            Connection.SendToServerAsync(
            Out.CatalogBuyItem,
            PageID,
            FurniID,
            TextBox,
            1
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
                    if (!PageIDRangeToggle)
                    {
                        if (PageIDInt1 == int.MaxValue)
                        {
                            PageIDBruteForcerEnabled1 = false;

                            EnableButton(CatalogueBruteForceBtn, true);
                            EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                            EnableNButton(CataloguePageIDBox, true);
                            EnableNButton(CatalogueFurniIDBox, true);
                            WriteToButton(CataloguePageIdBruteforcerbtx, "PageID Bruteforcer : Off");
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing PageID Completed." + FurniIDint1, 0, 1, 0, -1);
                            Thread.CurrentThread.Abort();
                            return;
                        }
                    }
                    else
                    {
                        if (PageIDInt1 == PageIDIntRange)
                        {
                            PageIDBruteForcerEnabled1 = false;

                            EnableButton(CatalogueBruteForceBtn, true);
                            EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                            EnableNButton(CataloguePageIDBox, true);
                            EnableNButton(CatalogueFurniIDBox, true);
                            WriteToButton(CataloguePageIdBruteforcerbtx, "PageID Bruteforcer : Off");
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing PageID Completed." + FurniIDint1, 0, 1, 0, -1);
                            Thread.CurrentThread.Abort();
                            return;
                        }
                    }
                    SendPacket(PageIDInt1, FurniIDint1);
                    Thread.Sleep(SpeedTimer1 + 15);

                    if (PurchaseSuccess)
                    {
                        StoreToInput(PageIDInt1, FurniIDint1);
                        if (ShowOutput)
                        {

                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + FurniIDint1, 0, 1, 0, -1);
                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }
                        if (ShowOutput1)
                        {
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bought Furni with name : " + FurniName, 0, 1, 0, -1);
                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }

                        Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        PurchaseSuccess = false;
                        FurniName = String.Empty;
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
                    if (!FurniIDRangeToggle)
                    {
                        if (FurniIDint1 == int.MaxValue)
                        {
                            FurnIIDBruteforcerEnabled1 = false;
                            EnableButton(CatalogueBruteForceBtn, true);
                            EnableButton(CataloguePageIdBruteforcerbtx, true);
                            EnableNButton(CataloguePageIDBox, true);
                            EnableNButton(CatalogueFurniIDBox, true);
                            WriteToButton(CatalogueFurnIDBruteForcerbtx, "FurniID Bruteforcer : Off");
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing FurniID Completed." + FurniIDint1, 0, 1, 0, -1);
                            Thread.CurrentThread.Abort();
                            return;
                        }
                    }
                    else
                    {
                        if (FurniIDint1 == FurniIDIntRange)
                        {
                            FurnIIDBruteforcerEnabled1 = false;
                            EnableButton(CatalogueBruteForceBtn, true);
                            EnableButton(CataloguePageIdBruteforcerbtx, true);
                            EnableNButton(CataloguePageIDBox, true);
                            EnableNButton(CatalogueFurniIDBox, true);
                            WriteToButton(CatalogueFurnIDBruteForcerbtx, "FurniID Bruteforcer : Off");
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing FurniID Completed." + FurniIDint1, 0, 1, 0, -1);
                            Thread.CurrentThread.Abort();
                            return;
                        }
                    }
                    SendPacket(PageIDInt1, FurniIDint1);
                    Thread.Sleep(SpeedTimer1 + GlobalSleeper);

                    if (PurchaseSuccess)
                    {
                        StoreToInput(PageIDInt1, (FurniIDint1 - 1));
                        Thread.Sleep(SpeedTimer1 + 15);

                        if (ShowOutput)
                        {
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + (FurniIDint1 - 1) , 0, 1, 0, -1);

                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);
                        }
                        if (ShowOutput1)
                        {
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bought Furni with name : " + FurniName, 0, 1, 0, -1);
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

        private void GlobalBruteForcer()
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
                                GlobalBruteforcerEnabled1 = false;
                                EnableButton(CataloguePageIdBruteforcerbtx, true);
                                EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                                EnableNButton(CataloguePageIDBox, true);
                                EnableNButton(CatalogueFurniIDBox, true);
                                WriteToButton(CatalogueBruteForceBtn, "BruteForcer : Off");
                                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing Completed." + FurniIDint1, 0, 1, 0, -1);
                                Thread.CurrentThread.Abort();
                                return;
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
                                    GlobalBruteforcerEnabled1 = false;
                                    EnableButton(CataloguePageIdBruteforcerbtx, true);
                                    EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                                    EnableNButton(CataloguePageIDBox, true);
                                    EnableNButton(CatalogueFurniIDBox, true);
                                    WriteToButton(CatalogueBruteForceBtn, "BruteForcer : Off");
                                    Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing  Completed." + FurniIDint1, 0, 1, 0, -1);
                                    Thread.CurrentThread.Abort();
                                    return;
                                }
                            }
                            else
                            {
                                if (FurniIDint1 == FurniIDIntRange)
                                {
                                    GlobalBruteforcerEnabled1 = false;
                                    EnableButton(CataloguePageIdBruteforcerbtx, true);
                                    EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                                    EnableNButton(CataloguePageIDBox, true);
                                    EnableNButton(CatalogueFurniIDBox, true);
                                    WriteToButton(CatalogueBruteForceBtn, "BruteForcer : Off");
                                    Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing  Completed." + FurniIDint1, 0, 1, 0, -1);
                                    Thread.CurrentThread.Abort();
                                    return;
                                }
                                if (FurniIDint1 == FurniIDIntRange && PageIDInt1 == PageIDIntRange)
                                {
                                    GlobalBruteforcerEnabled1 = false;
                                    EnableButton(CataloguePageIdBruteforcerbtx, true);
                                    EnableButton(CatalogueFurnIDBruteForcerbtx, true);
                                    EnableNButton(CataloguePageIDBox, true);
                                    EnableNButton(CatalogueFurniIDBox, true);
                                    WriteToButton(CatalogueBruteForceBtn, "BruteForcer : Off");
                                    Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bruteforcing  Completed." + FurniIDint1, 0, 1, 0, -1);
                                    Thread.CurrentThread.Abort();
                                    return;
                                }
                            }

                        }
                    }

                    FurniIDint1++;
                    SendPacket(PageIDInt1, FurniIDint1);
                    Thread.Sleep(SpeedTimer1 + 15);


                    if (PurchaseSuccess)
                    {
                                                StoreToInput(PageIDInt1, (FurniIDint1 - 1));

                        if (ShowOutput)
                        {
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Found valid PageID : " + PageIDInt1 + " with FurniID : " + (FurniIDint1 - 1), 0, 1, 0, -1);

                            Thread.Sleep(SpeedTimer1 + GlobalSleeper);

                        }
                        if(ShowOutput1)
                        {
                            Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Bruteforcer]: Bought Furni with name : " + FurniName, 0, 1, 0, -1);
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
            if(!PageIDRangeToggle)
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
            string Filepath = "../RetroFunLogs/"+ Dns.GetHostEntry(Connection.Remote.EndPoint.Host).HostName + "BruteForcerOutput" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Year.ToString() + ".log";
            string FolderName = "RetroFunLogs";
            string FolderName2 = Dns.GetHostEntry(Connection.Remote.EndPoint.Host).HostName;

            Directory.CreateDirectory("../" + FolderName);
            Directory.CreateDirectory("../" + FolderName + "/"+ FolderName2);


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
    }
}
