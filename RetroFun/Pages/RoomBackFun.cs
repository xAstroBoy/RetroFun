using RetroFun.Controls;
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
    public partial class RoomBackFun : ObservablePage
    {
        private int OldTonality;
        private int OldSaturation;
        private int OldLuminosity;
        private bool TonalityFader;
        private bool SaturationFader;
        private bool LuminosityFader;
        private bool isLiveEditing;

        private int _GlobalSpeed = 150;

        public int GlobalSpeed
        {
            get => _GlobalSpeed;
            set
            {
                _GlobalSpeed = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _LiveEditSpeed = 150;

        public int LiveEditSpeed
        {
            get => _LiveEditSpeed;
            set
            {
                _LiveEditSpeed = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _Tonality = 0;

        public int Tonality
        {
            get => _Tonality;
            set
            {
                _Tonality = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _SpeedTonality = 150;

        public int SpeedTonality
        {
            get => _SpeedTonality;
            set
            {
                _SpeedTonality = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _Saturation = 0;

        public int Saturation
        {
            get => _Saturation;
            set
            {
                _Saturation = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _SpeedSaturation = 150;

        public int SpeedSaturation
        {
            get => _SpeedSaturation;
            set
            {
                _SpeedSaturation = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _Luminosity = 0;

        public int Luminosity
        {
            get => _Luminosity;
            set
            {
                _Luminosity = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _SpeedLuminosity = 150;

        public int SpeedLuminosity
        {
            get => _SpeedLuminosity;
            set
            {
                _SpeedLuminosity = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FurniID = 0;

        public int FurniID
        {
            get => _FurniID;
            set
            {
                _FurniID = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _CaptureMode;

        public bool CaptureMode
        {
            get => _CaptureMode;
            set
            {
                _CaptureMode = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _GlobalSpeedSwitch;

        public bool GlobalSpeedSwitch
        {
            get => _GlobalSpeedSwitch;
            set
            {
                _GlobalSpeedSwitch = value;
                RaiseOnPropertyChanged();
            }
        }

        public RoomBackFun()
        {
            InitializeComponent();
            Bind(TonNbx, "Value", nameof(Tonality));
            Bind(SatNbx, "Value", nameof(Saturation));
            Bind(LightNbx, "Value", nameof(Luminosity));
            Bind(GlobalSpeedNbx, "Value", nameof(GlobalSpeed));
            Bind(LumSpeedNbx, "Value", nameof(SpeedLuminosity));
            Bind(SatSpeednbx, "Value", nameof(SpeedSaturation));
            Bind(TonSpeednbx, "Value", nameof(SpeedTonality));
            Bind(LiveEditSpeedNBx, "Value", nameof(LiveEditSpeed));
            Bind(FurniIDnb, "Value", nameof(FurniID));
            Bind(CaptureBtn, "Checked", nameof(CaptureMode));
            Bind(GlobalSpeedChbx, "Checked", nameof(GlobalSpeedSwitch));

            if (Program.Master != null)
            {
                Triggers.OutAttach(Out.RoomBackground, CaptureCurrent);
            }
        }

        public void CaptureCurrent(DataInterceptedEventArgs e)
        {
            if (CaptureMode)
            {
                FurniID = e.Packet.ReadInteger();
                Tonality = e.Packet.ReadInteger();
                Saturation = e.Packet.ReadInteger();
                Luminosity = e.Packet.ReadInteger();
                SaveSettings();
                Speak("FurniID Set to : " + FurniID.ToString());
                e.IsBlocked = true;
                CaptureMode = false;
            }
        }

        private void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                base.Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[RoomBackGroundFun]: " + text + ".", 0, 34, 0, -1);
            }
        }

        private void RestoreSettingsBtn_Click(object sender, EventArgs e)
        {
            RestoreSettings();
        }

        private void TonFadeBtn_Click(object sender, EventArgs e)
        {
            CheckTonalityFadeStatus();
        }

        private void SaturationFadeBtn_Click(object sender, EventArgs e)
        {
            CheckSaturationFadeStatus();
        }

        private void LuminosityFadeBtn_Click(object sender, EventArgs e)
        {
            CheckLuminosityFadeStatus();
        }

        private void LiveEditBtn_Click(object sender, EventArgs e)
        {
            CheckLiveEditModeStatus();
        }

        private void GlobalSpeedChbx_CheckedChanged(object sender, EventArgs e)
        {
            GlobalSpeedCheck();
        }

        public void SendFullPacket(int furnid, int Tonality, int saturation, int luminosity)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToServerAsync(Out.RoomBackground, furnid, Tonality, saturation, luminosity);
            }
        }

        private void GlobalSpeedCheck()
        {
            if (GlobalSpeedSwitch)
            {
                GlobalSpeedSwitch = false;
                EnableButton(TonSpeednbx, true);
                EnableButton(SatSpeednbx, true);
                EnableButton(LumSpeedNbx, true);
                EnableButton(GlobalSpeedNbx, false);
            }
            else
            {
                GlobalSpeedSwitch = true;
                EnableButton(TonSpeednbx, false);
                EnableButton(SatSpeednbx, false);
                EnableButton(LumSpeedNbx, false);
                EnableButton(GlobalSpeedNbx, true);
                StartGlobalSpeedUpdater();
            }
        }

        private void CheckLiveEditModeStatus()
        {
            if (isLiveEditing)
            {
                isLiveEditing = false;
                WriteToButton(LiveEditBtn, "Live Edit Mode : Off");
            }
            else
            {
                WriteToButton(LiveEditBtn, "Live Edit Mode : On");
                isLiveEditing = true;
                StartLiveEditMode();
            }
        }

        private void StartGlobalSpeedUpdater()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    SpeedTonality = GlobalSpeed;
                    SpeedSaturation = GlobalSpeed;
                    SpeedLuminosity = GlobalSpeed;
                } while (GlobalSpeedSwitch);
            }).Start();
        }

        private void StartLiveEditMode()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    SendFullPacket(FurniID, Tonality, Saturation, Luminosity);
                    Thread.Sleep(LiveEditSpeed);
                } while (isLiveEditing);
            }).Start();
        }

        private void CheckLuminosityFadeStatus()
        {
            if (LuminosityFader)
            {
                LuminosityFader = false;
                EnableButton(LightNbx, true);
                WriteToButton(LuminosityFadeBtn, "Luminosity Fade : Deactivated");
            }
            else
            {
                WriteToButton(LuminosityFadeBtn, "Luminosity Fade : Activated");
                LuminosityFader = true;
                EnableButton(LightNbx, false);
                StartLuminosityFader();
            }
        }

        private void StartLuminosityFader()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (Luminosity == 255)
                    {
                        Luminosity = 0;
                    }
                    else
                    {
                        Luminosity++;
                    }

                    SendFullPacket(FurniID, Tonality, Saturation, Luminosity);
                    Thread.Sleep(SpeedLuminosity);
                } while (LuminosityFader);
            }).Start();
        }

        private void CheckSaturationFadeStatus()
        {
            if (SaturationFader)
            {
                SaturationFader = false;
                EnableButton(SatNbx, true);
                WriteToButton(SaturationFadeBtn, "Saturation Fade : Deactivated");
            }
            else
            {
                WriteToButton(SaturationFadeBtn, "Saturation Fade : Activated");
                SaturationFader = true;
                EnableButton(SatNbx, false);
                StartSaturationFader();
            }
        }

        private void StartSaturationFader()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (Saturation == 255)
                    {
                        Saturation = 0;
                    }
                    else
                    {
                        Saturation++;
                    }

                    SendFullPacket(FurniID, Tonality, Saturation, Luminosity);
                    Thread.Sleep(SpeedSaturation);
                } while (SaturationFader);
            }).Start();
        }

        private void CheckTonalityFadeStatus()
        {
            if (TonalityFader)
            {
                TonalityFader = false;
                EnableButton(TonNbx, true);
                WriteToButton(TonFadeBtn, "Tonality Fade : Deactivated");
            }
            else
            {
                WriteToButton(TonFadeBtn, "Tonality Fade : Activated");
                TonalityFader = true;
                EnableButton(TonNbx, false);
                StartTonalityFader();
            }
        }

        private void StartTonalityFader()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (Tonality == 255)
                    {
                        Tonality = 0;
                    }
                    else
                    {
                        Tonality++;
                    }

                    SendFullPacket(FurniID, Tonality, Saturation, Luminosity);
                    Thread.Sleep(SpeedTonality);
                } while (TonalityFader);
            }).Start();
        }

        private void EnableButton(NumericUpDown button, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = enabled;
            });
        }

        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }

        private void SaveSettings()
        {
            OldTonality = Tonality;
            OldSaturation = Saturation;
            OldLuminosity = Luminosity;
        }

        private void RestoreSettings()
        {
            Tonality = OldTonality;
            Saturation = OldSaturation;
            Luminosity = OldLuminosity;
            SendFullPacket(FurniID, Tonality, Saturation, Luminosity);
        }
    }
}