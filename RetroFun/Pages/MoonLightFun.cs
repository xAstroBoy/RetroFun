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

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MoonLightFun : ObservablePage
    {
        #region Ints and stuff



        // DISCO COLORS

        private readonly string LightBlue = "74F5F5";
        private readonly string DarkBlue = "0053F7";
        private readonly string Purple = "E759DE";
        private readonly string Red = "EA4532";
        private readonly string Yellow = "F2F851";
        private readonly string Green = "82F349";

        private bool DiscoLight;
        private bool LiveEditing;

        private int _DiscoCooldown;
        public int DiscoCooldown
        {
            get => _DiscoCooldown;
            set
            {
                _DiscoCooldown = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _LiveEditCooldown;
        public int LiveEditCooldown
        {
            get => _LiveEditCooldown;
            set
            {
                _LiveEditCooldown = value;
                RaiseOnPropertyChanged();
            }
        }

        private int _Density;
        public int Density
        {
            get => _Density;
            set
            {
                _Density = value;
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

        private string _CustomColor;
        public string CustomColor
        {
            get => _CustomColor;
            set
            {
                _CustomColor = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _SelectedCustom;
        public bool SelectedCustom
        {
            get => _SelectedCustom;
            set
            {
                _SelectedCustom = value;
                RaiseOnPropertyChanged();
            }
        }
        #endregion


        public MoonLightFun()
        {
            InitializeComponent();
            Bind(DiscoNumericcool, "Value", nameof(DiscoCooldown));
            Bind(DensityNm, "Value", nameof(Density));
            Bind(OnlyWallChbx, "checked", nameof(JustWallpapers));
            Bind(LiveEditCoolNb, "Value", nameof(LiveEditCooldown));
            Bind(ColorHTMLtxb, "Text", nameof(CustomColor));
            //Bind(LightBluebtx, "checked", nameof(SelectedLightblue));
            //Bind(DarkBluebtx, "checked", nameof(SelectedDarkBlue));
            //Bind(PurpleBtx, "checked", nameof(SelectedPurple));
            //Bind(RedBtx, "checked", nameof(SelectedRed));
            //Bind(YellowBtx, "checked", nameof(SelectedYellow));
            //Bind(GreenBtx, "checked", nameof(SelectedGreen));
            Bind(CustomBtx, "checked", nameof(SelectedCustom));

            DiscoCooldown = 500;
            Density = 79;
            LiveEditCooldown = 500;
        }




        // MoodLightSaveSettings Structure
        // {u:1330} Header
        //{i:1} Presets (use 3)
        //{i:2} Just Wallpapers  ( use Checkbox)
        //{s:#82F349} Colors (String , skip #, HTML Colors.)
        //{i:76} ( Density , use numberupanddown)
        //{b:True} ???


        private void SetMoonBtx_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(CustomColor))
                {
                    SendMoodLightPacket(3, CustomColor, Density);
                }
        }


        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }


        private void SMoonDiscoBtn_Click(object sender, EventArgs e)
        {
            CheckDisco();
        }


        private void CheckDisco()
        {
            if (DiscoLight)
            {
                DiscoLight = false;
                EnableButton(LiveEditBtn, true);
                WriteToButton(SMoonDiscoBtn, "MoonLight Disco : Deactivated");
            }
            else
            {
                DiscoLight = true;
                EnableButton(LiveEditBtn, false);
                WriteToButton(SMoonDiscoBtn, "MoonLight Disco : Activated");
                StartDisco();
            }
        }

        private void EnableButton(SKoreButton button, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = enabled;
            });
        }

        private void EnableTexButton(TextBox textbox, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                textbox.Enabled = enabled;
            });
        }

        private void CheckLiveEdit()
        {
            if (LiveEditing)
            {
                LiveEditing = false;
                EnableButton(SMoonDiscoBtn, true);
                WriteToButton(LiveEditBtn, "Live editing: Deactivated");
            }
            else
            {
                LiveEditing = true;
                EnableButton(SMoonDiscoBtn, false);
                WriteToButton(LiveEditBtn, "Live editing: Activated");
                LiveEdit();
            }
        }

        private void LightBluebtx_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorHTMLtxb.Enabled == true)
            {
                EnableTexButton(ColorHTMLtxb, false);
            }
            CustomColor = LightBlue;
        }

        private void DarkBluebtx_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorHTMLtxb.Enabled == true)
            {
                EnableTexButton(ColorHTMLtxb, false);
            }
            CustomColor = DarkBlue;
        }

        private void PurpleBtx_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorHTMLtxb.Enabled == true)
            {
                EnableTexButton(ColorHTMLtxb, false);
            }
            CustomColor = Purple;
        }

        private void RedBtx_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorHTMLtxb.Enabled == true)
            {
                EnableTexButton(ColorHTMLtxb, false);
            }
            CustomColor = Red;
        }

        private void YellowBtx_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorHTMLtxb.Enabled == true)
            {
                EnableTexButton(ColorHTMLtxb, false);
            }
            CustomColor = Yellow;
        }

        private void GreenBtx_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorHTMLtxb.Enabled == true)
            {
                EnableTexButton(ColorHTMLtxb, false);
            }
            CustomColor = Green;
        }

        private void CustomBtx_CheckedChanged(object sender, EventArgs e)
        {
                EnableTexButton(ColorHTMLtxb, true);
        }

        private void LiveEditBtn_Click(object sender, EventArgs e)
        {

            CheckLiveEdit();
        }

        private void StartDisco()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                    SendMoodLightPacket(3, LightBlue, Density);
                    Thread.Sleep(DiscoCooldown);
                    SendMoodLightPacket(3, DarkBlue, Density);
                    Thread.Sleep(DiscoCooldown);
                    SendMoodLightPacket(3, Purple, Density);
                    Thread.Sleep(DiscoCooldown);
                    SendMoodLightPacket(3, Red, Density);
                    Thread.Sleep(DiscoCooldown);
                    SendMoodLightPacket(3, Yellow, Density);
                    Thread.Sleep(DiscoCooldown);
                    SendMoodLightPacket(3, Green, Density);
                    Thread.Sleep(DiscoCooldown);
                } while (DiscoLight);

            }).Start();
        }


        private void LiveEdit()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                do
                {
                 SendMoodLightPacket(2, CustomColor, Density);
                 Thread.Sleep(LiveEditCooldown);
                } while (LiveEditing);

            }).Start();
        }


        private void SendMoodLightPacket(int preset, string color, int Density)
        {
            if (JustWallpapers)
            {
                Connection.SendToServerAsync(Out.MoodLightSaveSettings, preset, 2, "#" + color, Density, true);
            }
            else
            {
                Connection.SendToServerAsync(Out.MoodLightSaveSettings, preset, 1, "#" + color, Density, true);
            }
        }
    }
}
