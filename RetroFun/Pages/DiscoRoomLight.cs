using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Components;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class DiscoRoomLight : SubscriberPackets
    {
        public MoonLightFunPage LightController;
        private Random Randomizer2 = new Random();
        private Random Randomizer1 = new Random();

        public bool DiscoLight;
        private bool FlashAsk;
        private bool DensityRandomizer1;
        private bool DensityRandomizer2;

        private readonly string LightBlue = "74F5F5";
        private readonly string DarkBlue = "0053F7";
        private readonly string Purple = "E759DE";
        private readonly string Red = "EA4532";
        private readonly string Yellow = "F2F851";
        private readonly string Green = "82F349";
        private readonly string Black = "000000";

        private int _DiscoCooldown = 150;

        public int DiscoCooldown
        {
            get => _DiscoCooldown;
            set
            {
                _DiscoCooldown = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _Density = 79;

        public int Density
        {
            get => _Density;
            set
            {
                _Density = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _FlashDensity = 79;

        public int FlashDensity
        {
            get => _FlashDensity;
            set
            {
                _FlashDensity = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _JustWallpapers;

        public bool JustWallpapers
        {
            get => _JustWallpapers;
            set
            {
                _JustWallpapers = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SelectedLightblue;

        public bool SelectedLightblue
        {
            get => _SelectedLightblue;
            set
            {
                _SelectedLightblue = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SelectedDarkBlue;

        public bool SelectedDarkBlue
        {
            get => _SelectedDarkBlue;
            set
            {
                _SelectedDarkBlue = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SelectedPurple;

        public bool SelectedPurple
        {
            get => _SelectedPurple;
            set
            {
                _SelectedPurple = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SelectedRed;

        public bool SelectedRed
        {
            get => _SelectedRed;
            set
            {
                _SelectedRed = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SelectedYellow;

        public bool SelectedYellow
        {
            get => _SelectedYellow;
            set
            {
                _SelectedYellow = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SelectedGreen;

        public bool SelectedGreen
        {
            get => _SelectedGreen;
            set
            {
                _SelectedGreen = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _SelectedBlack;

        public bool SelectedBlack
        {
            get => _SelectedBlack;
            set
            {
                _SelectedBlack = value;
                RaiseOnPropertyChanged();
            }
        }

        public DiscoRoomLight()
        {
            InitializeComponent();

            Bind(DiscoNumericcool, "Value", nameof(DiscoCooldown));
            Bind(FlashDensityNbx, "Value", nameof(FlashDensity));
            Bind(DensityNm, "Value", nameof(Density));
            Bind(OnlyWallChbx, "checked", nameof(JustWallpapers));
            Bind(LightBluebtx, "checked", nameof(SelectedLightblue));
            Bind(DarkBluebtx, "checked", nameof(SelectedDarkBlue));
            Bind(PurpleBtx, "checked", nameof(SelectedPurple));
            Bind(RedBtx, "checked", nameof(SelectedRed));
            Bind(YellowBtx, "checked", nameof(SelectedYellow));
            Bind(GreenBtx, "checked", nameof(SelectedGreen));
            Bind(BlackBtx, "checked", nameof(SelectedBlack));
        }

        private void CheckDisco()
        {
            if (DiscoLight)
            {
                DiscoLight = false;
                WriteToButton(SMoonDiscoBtn, "MoonLight Disco : Deactivated");
                if (LightController != null)
                {
                    LightController.EnableAll();
                }
            }
            else
            {
                DiscoLight = true;
                WriteToButton(SMoonDiscoBtn, "MoonLight Disco : Activated");
                if (LightController != null)
                {
                    LightController.DeactivateAll();
                }
                StartDisco();
            }
        }

        private void RandomDensityTogglerBtn_Click(object sender, EventArgs e)
        {
            CheckRandomizer1();
        }

        private void CheckRandomizer1()
        {
            if (DensityRandomizer1)
            {
                DensityRandomizer1 = false;
                EnableButton(DensityNm, true);
                WriteToButton(RandomDensityTogglerBtn, "Random Density : Deactivated");
            }
            else
            {
                DensityRandomizer1 = true;
                EnableButton(DensityNm, false);
                WriteToButton(RandomDensityTogglerBtn, "Random Density : Activated");
                RandomizeDensity1();
            }
        }

        private void EnableButton(NumericUpDown button, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = enabled;
            });
        }

        private void CheckRandomizer2()
        {
            if (DensityRandomizer2)
            {
                DensityRandomizer2 = false;
                EnableButton(FlashDensityNbx, true);
                WriteToButton(FlashDensityRandomizer, "Random Density : Deactivated");
            }
            else
            {
                DensityRandomizer2 = true;
                EnableButton(FlashDensityNbx, false);
                WriteToButton(FlashDensityRandomizer, "Random Density : Activated");
                RandomizeDensity2();
            }
        }

        private void FlashLightBlue_Click(object sender, EventArgs e)
        {
            RequestFlash(LightBlue);
        }

        private void FlashDarkBlue_Click(object sender, EventArgs e)
        {
            RequestFlash(DarkBlue);
        }

        private void FlashPurple_Click(object sender, EventArgs e)
        {
            RequestFlash(Purple);
        }

        private void FlashRed_Click(object sender, EventArgs e)
        {
            RequestFlash(Red);
        }

        private void FlashYellow_Click(object sender, EventArgs e)
        {
            RequestFlash(Yellow);
        }

        private void FlashGreen_Click(object sender, EventArgs e)
        {
            RequestFlash(Green);
        }

        private void FlashDensityRandomizer_Click(object sender, EventArgs e)
        {
            CheckRandomizer2();
        }

        private void FlashBlack_Click(object sender, EventArgs e)
        {
            RequestFlash(Black);
        }

        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }

        private void RandomizeDensity1()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    Density = Randomizer1.Next(15, 230);
                    Thread.Sleep(90);
                } while (DensityRandomizer1);
            }).Start();
        }

        private void RandomizeDensity2()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    FlashDensity = Randomizer2.Next(15, 230);
                    Thread.Sleep(90);
                } while (DensityRandomizer2);
            }).Start();
        }

        private void RequestFlash(string color)
        {
            if (!FlashAsk)
            {
                FlashAsk = true;
                Flash(color);
            }
        }

        private void Flash(string color)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    SendMoodLightPacket(3, color, FlashDensity);
                    FlashAsk = false;
                } while (FlashAsk);
            }).Start();
        }

        private void StartDisco()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    if (!FlashAsk)
                    {
                        if (SelectedLightblue)
                        {
                            SendMoodLightPacket(3, LightBlue, Density);
                            Thread.Sleep(DiscoCooldown);
                        }
                        if (SelectedDarkBlue)
                        {
                            SendMoodLightPacket(3, DarkBlue, Density);
                            Thread.Sleep(DiscoCooldown);
                        }
                        if (SelectedPurple)
                        {
                            SendMoodLightPacket(3, Purple, Density);
                            Thread.Sleep(DiscoCooldown);
                        }
                        if (SelectedRed)
                        {
                            SendMoodLightPacket(3, Red, Density);
                            Thread.Sleep(DiscoCooldown);
                        }
                        if (SelectedYellow)
                        {
                            SendMoodLightPacket(3, Yellow, Density);
                            Thread.Sleep(DiscoCooldown);
                        }
                        if (SelectedGreen)
                        {
                            SendMoodLightPacket(3, Green, Density);
                            Thread.Sleep(DiscoCooldown);
                        }
                        if (SelectedBlack)
                        {
                            SendMoodLightPacket(3, Black, Density);
                            Thread.Sleep(DiscoCooldown);
                        }
                    }
                } while (DiscoLight);
            }).Start();
        }

        private void SMoonDiscoBtn_Click_1(object sender, EventArgs e)
        {
            CheckDisco();
        }

        private async void SendMoodLightPacket(int preset, string color, int Density)
        {
            if (Connection.Remote.IsConnected)
            {
                if (JustWallpapers)
                {
                    if (Connection.Remote.IsConnected)
                    {
                        await Connection.SendToServerAsync(Out.MoodLightSaveSettings, preset, 2, "#" + color, Density, true);
                    }
                }
                else
                {
                    if (Connection.Remote.IsConnected)
                    {
                        await Connection.SendToServerAsync(Out.MoodLightSaveSettings, preset, 1, "#" + color, Density, true);
                    }
                }
            }
        }
    }
}