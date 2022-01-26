using RetroFun.Subscribers;
using Geode.Network;

using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class MoonLightFunPage : ObservablePage
    {
        #region Ints and stuff

        // DISCO COLORS

        private readonly string LightBlue = "74F5F5";
        private readonly string DarkBlue = "0053F7";
        private readonly string Purple = "E759DE";
        private readonly string Red = "EA4532";
        private readonly string Yellow = "F2F851";
        private readonly string Green = "82F349";
        private readonly string Black = "000000";

        private bool LiveEditing;

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

        #endregion Ints and stuff

        public MoonLightFunPage()
        {
            InitializeComponent();
            Bind(DensityNm, "Value", nameof(Density));
            Bind(OnlyWallChbx, "checked", nameof(JustWallpapers));
            Bind(ColorHTMLtxb, "Text", nameof(CustomColor));

            Bind(CustomBtx, "checked", nameof(SelectedCustom));
        }

        public void DeactivateAll()
        {
            LiveEditing = false;
            EnableGroup(ColorBox, false);
            EnableButton(SetMoonBtx, false);
        }

        public void EnableAll()
        {
            EnableGroup(ColorBox, true);
            EnableButton(SetMoonBtx, true);
        }

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

        private void EnableButton(SKoreButton button, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = enabled;
            });
        }

        private void RadioCheck(RadioButton button, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Enabled = enabled;
            });
        }

        private void EnableGroup(GroupBox group, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                group.Enabled = enabled;
            });
        }

        private void EnableTexButton(TextBox textbox, bool enabled)
        {
            Invoke((MethodInvoker)delegate
            {
                textbox.Enabled = enabled;
            });
        }
        public override void Out_RequestRoomHeightmap(DataInterceptedEventArgs e)
        {
            DisableLiveEdit();
        }

        public override void Out_RequestRoomLoad(DataInterceptedEventArgs e)
        {
            DisableLiveEdit();
        }

        private void DisableLiveEdit()
        {
            LiveEditing = false;
            WriteToButton(LiveEditBtn, "Live editing: Deactivated");
        }

        private void CheckLiveEdit()
        {
            if (LiveEditing)
            {
                LiveEditing = false;
                WriteToButton(LiveEditBtn, "Live editing: Deactivated");
            }
            else
            {
                LiveEditing = true;
                WriteToButton(LiveEditBtn, "Live editing: Activated");
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

        private void BlackRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorHTMLtxb.Enabled == true)
            {
                EnableTexButton(ColorHTMLtxb, false);
            }
            CustomColor = Black;
        }

        private void CustomBtx_CheckedChanged(object sender, EventArgs e)
        {
            EnableTexButton(ColorHTMLtxb, true);
        }

        private void LiveEditBtn_Click(object sender, EventArgs e)
        {
            CheckLiveEdit();
        }

        private async void SendMoodLightPacket(int preset, string color, int Density)
        {
                if (JustWallpapers)
                {
                  await  SendToServer(Out.MoodLightSaveSettings, preset, 2, "#" + color, Density, true);
                }
                else
                {
                   await  SendToServer(Out.MoodLightSaveSettings, preset, 1, "#" + color, Density, true);
                }
        }

        private void ColorHTMLtxb_TextChanged(object sender, EventArgs e)
        {
            if (LiveEditing)
            {
                SendMoodLightPacket(2, CustomColor, Density);
            }
        }

        private void DensityNm_ValueChanged(object sender, EventArgs e)
        {
            if (LiveEditing)
            {
                SendMoodLightPacket(2, CustomColor, Density);
            }
        }
    }
}