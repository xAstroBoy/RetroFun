using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using RetroFun.Controls;
using Sulakore.Components;
using Sulakore.Communication;
using Sulakore.Modules;

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

        private int _Speed = 0;
        public int Speed
        {
            get => _Speed;
            set
            {
                _Speed = value;
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


        public RoomBackFun()
        {
            InitializeComponent();
            Bind(TonNbx, "Value", nameof(Tonality));
            Bind(SatNbx, "Value", nameof(Saturation));
            Bind(LightNbx, "Value", nameof(Luminosity));
            Bind(SpeedMan, "Value", nameof(Speed));
            Bind(FurniIDnb, "Value", nameof(FurniID));
            Bind(CaptureBtn, "Checked", nameof(CaptureMode));
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
                CaptureMode = false;
            }
        }

        //[RoomBackground]
        // HEADER
        //{i:684050046} FURNIID 
        // {i:0} Tonality
        // {i:0} Saturation
        // {i:0} Luminosity
        // TODO: Figure how to grab FurniID




        private void StoreSettingBtn_Click(object sender, EventArgs e)
        {
            SaveSettings();
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









        public void SendFullPacket(int furnid, int Tonality, int saturation, int luminosity)
        {
            Connection.SendToServerAsync(Out.RoomBackground, furnid, Tonality, saturation, luminosity);
        }





        private void CheckLiveEditModeStatus()
        {
            if (isLiveEditing)
            {
                isLiveEditing = false;
                WriteToButton(LiveEditBtn, "Live Edit Mode : Disabled");
            }
            else
            {
                WriteToButton(LiveEditBtn, "Live Edit Mode : Enabled");
                isLiveEditing = true;
                StartLiveEditMode();
            }
        }




        private void StartLiveEditMode()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    SendFullPacket(FurniID, Tonality, Saturation, Luminosity);
                    Thread.Sleep(Speed);
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
                    Thread.Sleep(Speed);
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
                    Thread.Sleep(Speed);
                } while (SaturationFader);

            }).Start();
        }





        private void CheckTonalityFadeStatus()
        {
            if(TonalityFader)
            {
                TonalityFader = false;
                EnableButton(TonNbx, true) ;
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
                    Thread.Sleep(Speed);
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
