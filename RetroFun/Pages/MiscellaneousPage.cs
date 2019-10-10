using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using Sulakore.Components;
using Sulakore.Modules;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MiscellaneousPage : ObservablePage
    {
        Random Randomizer = new Random();
        private int OldRandom = 100;
        private int OldRandom1 = 100;
        private int OldRandom2 = 100;
        private int OldRandom3 = 100;

        private string OldLook = "";
        #region SignCountBools

        private bool SignCountEnabled;
        private bool DecreasingMode;
        private bool IncreasingMode = true;
        private bool ActionLoopEnabled;
        private readonly int Respect = 7;
        private readonly int Wave = 1;
        private readonly int Sleep = 5;
        private readonly int Laugh = 3;
        private readonly int Kiss = 2;
        private bool SitModeEnabled;

        #region ActionsBools

        private bool _RespectSelected;
        public bool RespectSelected
        {
            get => _RespectSelected;
            set
            {
                _RespectSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _WaveSelected;
        public bool WaveSelected
        {
            get => _WaveSelected;
            set
            {
                _WaveSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SleepSelected;
        public bool SleepSelected
        {
            get => _SleepSelected;
            set
            {
                _SleepSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _LaughSelected;
        public bool LaughSelected
        {
            get => _LaughSelected;
            set
            {
                _LaughSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _KissSelected;
        public bool KissSelected
        {
            get => _KissSelected;
            set
            {
                _KissSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        #endregion

        //private bool ZeroUsed;
        //private bool OneUsed;
        //private bool TwoUsed;
        //private bool ThreeUsed;
        //private bool FourUsed;
        //private bool FiveUsed;
        //private bool SixUsed;
        //private bool SevenUsed;
        //private bool EightUsed;
        //private bool NineUsed;
        //private bool TenUsed;


        private bool _ZeroSelected;
        public bool ZeroSelected
        {
            get => _ZeroSelected;
            set
            {
                _ZeroSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _OneSelected;
        public bool OneSelected
        {
            get => _OneSelected;
            set
            {
                _OneSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _TwoSelected;
        public bool TwoSelected
        {
            get => _TwoSelected;
            set
            {
                _TwoSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _ThreeSelected;
        public bool ThreeSelected
        {
            get => _ThreeSelected;
            set
            {
                _ThreeSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _FourSelected;
        public bool FourSelected
        {
            get => _FourSelected;
            set
            {
                _FourSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _FiveSelected;
        public bool FiveSelected
        {
            get => _FiveSelected;
            set
            {
                _FiveSelected = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _SixSelected;
        public bool SixSelected
        {
            get => _SixSelected;
            set
            {
                _SixSelected = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _SevenSelected;
        public bool SevenSelected
        {
            get => _SevenSelected;
            set
            {
                _SevenSelected = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _EightSelected;
        public bool EightSelected
        {
            get => _EightSelected;
            set
            {
                _EightSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _NineSelected;
        public bool NineSelected
        {
            get => _NineSelected;
            set
            {
                _NineSelected = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _TenSelected;
        public bool TenSelected
        {
            get => _TenSelected;
            set
            {
                _TenSelected = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _SignCounterCoolDown;
        public int SignCounterCoolDown
        {
            get => _SignCounterCoolDown;
            set
            {
                _SignCounterCoolDown = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _ActionsCooldown = 250;
        public int ActionsCooldown
        {
            get => _ActionsCooldown;
            set
            {
                _ActionsCooldown = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _SitsCooldown = 250;
        public int SitsCooldown
        {
            get => _SitsCooldown;
            set
            {
                _SitsCooldown = value;
                RaiseOnPropertyChanged();
            }
        }

        #endregion

        #region miscvars
        private bool _AntiFriendRemove = true;
        public bool AntiFriendRemove
        {
            get => _AntiFriendRemove;
            set
            {
                _AntiFriendRemove = value;
                RaiseOnPropertyChanged();
            }
        }
        #endregion



        public MiscellaneousPage()
        {
            InitializeComponent();

            Bind(NoRemoveFriendOnReport, "Checked", nameof(AntiFriendRemove));
            Bind(ZeroChbx, "Checked", nameof(ZeroSelected));
            Bind(OneChbx, "Checked", nameof(OneSelected));
            Bind(TwoChbx, "Checked", nameof(TwoSelected));
            Bind(ThreeChbx, "Checked", nameof(ThreeSelected));
            Bind(FourChbx, "Checked", nameof(FourSelected));
            Bind(FiveChbx, "Checked", nameof(FiveSelected));
            Bind(SixChbx, "Checked", nameof(SixSelected));
            Bind(SevenChbx, "Checked", nameof(SevenSelected));
            Bind(EightChbx, "Checked", nameof(EightSelected));
            Bind(NineChbx, "Checked", nameof(NineSelected));
            Bind(TenChBx, "Checked", nameof(TenSelected));
            Bind(Action_respect, "Checked", nameof(RespectSelected));
            Bind(Action_handwave, "Checked", nameof(WaveSelected));
            Bind(Action_sleep, "Checked", nameof(SleepSelected));
            Bind(Action_laugh, "Checked", nameof(LaughSelected));
            Bind(Action_Kiss, "Checked", nameof(KissSelected));

            Bind(SignCountCoolDown, "Value", nameof(SignCounterCoolDown));
            Bind(ActionsCooldownnbx, "Value", nameof(ActionsCooldown));
            Bind(SitCoolDownNbx, "Value", nameof(SitsCooldown));

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RemoveFriend, BlockFriendRemoval);
            }

        }





        private void SignCountBtn_Click(object sender, EventArgs e)
        {
            SignCountCheck();
        }

        private void SignCountCheck()
        {
            if(SignCountEnabled)
            {
                SignCountEnabled = false;
                WriteToButton(SignCountBtn, "Sign Count : Off");

            }
            else
            {
                SignCountEnabled = true;
                WriteToButton(SignCountBtn, "Sign Count : On");
 
                SignCountThread();

            }
        }

        private void ActionOnLoopBtn_Click(object sender, EventArgs e)
        {
            ActionLooper();
        }


        private void ActionLooper()
        {
            if (ActionLoopEnabled)
            {
                ActionLoopEnabled = false;
                WriteToButton(ActionOnLoopBtn, "Actions On Loop : Off");
            }
            else
            {
                WriteToButton(ActionOnLoopBtn, "Actions On Loop : On");
                ActionLoopEnabled = true;
                ActionOnLoop();
            }
        }



        private void SitLoop()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    UserSit();
                    Thread.Sleep(SitsCooldown);
                } while (SitModeEnabled);

            }).Start();
        }

        private void ActionOnLoop()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if(RespectSelected)
                    {
                        SendActionPacket(Respect);
                        Thread.Sleep(ActionsCooldown);
                    }
                    else if(WaveSelected)
                    {
                        SendActionPacket(Wave);
                        Thread.Sleep(ActionsCooldown);
                    }
                    else if (SleepSelected)
                    {
                        SendActionPacket(Sleep);
                        Thread.Sleep(ActionsCooldown);
                    }
                    else if (LaughSelected)
                    {
                        SendActionPacket(Laugh);
                        Thread.Sleep(ActionsCooldown);
                    }
                    else if (KissSelected)
                    {
                        SendActionPacket(Kiss);
                        Thread.Sleep(ActionsCooldown);
                    }
                } while (ActionLoopEnabled);

            }).Start();
        }

        private void SendActionPacket(int Action)
        {
            Connection.SendToServerAsync(Out.RoomUserAction, Action);
        }


        private void SignCountThread()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (IncreasingMode)
                    {
                        if (ZeroSelected)
                        {
                            SendRoomSign(0);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (OneSelected)
                        {
                            SendRoomSign(1);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (TwoSelected)
                        {
                            SendRoomSign(2);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (ThreeSelected)
                        {
                            SendRoomSign(3);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (FourSelected)
                        {
                            SendRoomSign(4);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (FiveSelected)
                        {
                            SendRoomSign(5);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (SixSelected)
                        {
                            SendRoomSign(6);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (SevenSelected)
                        {
                            SendRoomSign(7);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (EightSelected)
                        {
                            SendRoomSign(8);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (NineSelected)
                        {
                            SendRoomSign(9);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (TenSelected)
                        {
                            SendRoomSign(10);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                    }

                    if(DecreasingMode)
                    {
                        if (TenSelected)
                        {
                            SendRoomSign(10);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (NineSelected)
                        {
                            SendRoomSign(9);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (EightSelected)
                        {
                            SendRoomSign(8);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (SevenSelected)
                        {
                            SendRoomSign(7);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (SixSelected)
                        {
                            SendRoomSign(6);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (FiveSelected)
                        {
                            SendRoomSign(5);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (FourSelected)
                        {
                            SendRoomSign(4);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (ThreeSelected)
                        {
                            SendRoomSign(3);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (TwoSelected)
                        {
                            SendRoomSign(2);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (OneSelected)
                        {
                            SendRoomSign(1);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                        if (ZeroSelected)
                        {
                            SendRoomSign(0);
                            Thread.Sleep(SignCounterCoolDown);
                        }
                    }
                } while (SignCountEnabled);

            }).Start();
        }

        private void SendRoomSign(int Sign)
        {
            Connection.SendToServerAsync(Out.RoomUserSign, Sign);
        }

        private void UserSit()
        {
            Connection.SendToServerAsync(Out.RoomUserSit);
        }

        [OutDataCapture("RemoveFriend")]
        public void BlockFriendRemoval(DataInterceptedEventArgs e)	
        {	
            if (AntiFriendRemove)	
                e.IsBlocked = true;	
        }

        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }


        private void CountingBtn_Click(object sender, EventArgs e)
        {
            ChangeCounting();
        }

        private void ChangeCounting()
        {
            if(IncreasingMode)
            {
                IncreasingMode = false;
                DecreasingMode = true;
                WriteToButton(CountingBtn, "10→0");
            }
            else if(DecreasingMode)
            {
                IncreasingMode = true;
                DecreasingMode = false;
                WriteToButton(CountingBtn, "0→10");
            }
        }




        private void UserSitBtn_Click(object sender, EventArgs e)
        {
            UserSit();
        }


        private void SitCheck()
        {

            if (SitModeEnabled)
            {
                SitModeEnabled = false;
                WriteToButton(SitOnLoopBtn, "Sit Loop : Off");
            }
            else
            {
                SitModeEnabled = true;
                WriteToButton(SitOnLoopBtn, "Sit Loop : On");
                SitLoop();
            }
        }

        private void SitOnLoopBtn_Click(object sender, EventArgs e)
        {
            SitCheck();
        }

        public string GenInt()
        {
            int Random = Randomizer.Next(0, 9);
            
            //if(!(OldRandom == Random))
            //{
            //    OldRandom = Random;
                return Random.ToString();
            //}
            //return GenInt();
        }



        private void GenerateMaleLook()
        {
            string Look = "ca-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".ch-" + GenInt() + GenInt() + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".lg-" + GenInt() + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".sh-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + GenInt() + GenInt() + ".wa-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + GenInt() + ".hd-" + GenInt() + GenInt() + GenInt() + "-" + GenInt() + ".hr-" + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".ha-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".ea-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + "";
            if(Look != OldLook)
            {
                OldLook = Look;
                Console.WriteLine("USer Look set to : " + Look) ;
                Connection.SendToServerAsync(Out.UserSaveLook, "M", Look);
            }
            else
            {
                Console.WriteLine("Found Duplicated look!");
                GenerateMaleLook();
            }
        }

        private void GenerateFemaleLook()
        {
            Connection.SendToServerAsync(Out.UserSaveLook, "F", "ca-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".ch-" + GenInt() + GenInt() + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".lg-" + GenInt() + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".sh-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + GenInt() + GenInt() + ".wa-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + GenInt() + ".hd-" + GenInt() + GenInt() + GenInt() + "-" + GenInt() + ".hr-" + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".ha-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + ".ea-" + GenInt() + GenInt() + GenInt() + GenInt() + "-" + GenInt() + GenInt() + "");
        }


        private void GenLookGenThreadBtn_Click(object sender, EventArgs e)
        {

        }

        private void ToggleLookGen()
        {

        }

        private void GenFemaleLookBtn_Click(object sender, EventArgs e)
        {
            GenerateFemaleLook();
        }

        private void GenMaleLookBtn_Click(object sender, EventArgs e)
        {
            GenerateMaleLook();
        }
    }
}