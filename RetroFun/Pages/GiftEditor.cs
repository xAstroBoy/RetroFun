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

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class GiftEditor : ObservablePage
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


        private int _SpeedTimer;
        public int SpeedTimer
        {
            get => _SpeedTimer;
            set
            {
                _SpeedTimer = value;
                RaiseOnPropertyChanged();
            }
        }


        public GiftEditor()
        {
            InitializeComponent();
            Bind(AnonymousChbx, "Checked", nameof(isAnonymous));
            Bind(LoopCoolDown, "Value", nameof(SpeedTimer));
            SpeedTimer = 6000;
        }

        private void PageIdBox_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PageIdBox.Text, "[^0-9]"))
            {
                PageIdBox.Text = PageIdBox.Text.Remove(PageIdBox.Text.Length - 1);
            }
        }

        private void FurniIDBox_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(FurniIDBox.Text, "[^0-9]"))
            {
                FurniIDBox.Text = FurniIDBox.Text.Remove(FurniIDBox.Text.Length - 1);
            }
        }

        private void SendGiftBtn_Click_1(object sender, EventArgs e)
        {
            SendPacket();
        }

        private void SButtonLoopToggle_Click(object sender, EventArgs e)
        {
            CheckLoopStatus();
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


        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }


        private void SendPacket()
        {

            if (String.IsNullOrEmpty(PageIdBox.Text) || String.IsNullOrEmpty(FurniIDBox.Text) || String.IsNullOrEmpty(UsernameTextBox.Text))
            {
                return;
            }
   Connection.SendToServerAsync(
   Out.CatalogBuyItemAsGift, //{l}{u:451}
   int.Parse(PageIdBox.Text), //{i:PAGEID}
   int.Parse(FurniIDBox.Text), //{i:FURNID}
   furnITextBox.Text, //{s:wtfisthisshit}
   UsernameTextBox.Text, // {s:Nickname}
   GiftTextBox.Text, // {s:MORE DIAMONDS BOI}
   3376, // {i:3376}
   5, // {i:5}
   0, // {i:0}
   isAnonymous //  {b:False}
   );

        }

       

        private void StartLoop()
        {


            new Thread(() =>
            {


                Thread.CurrentThread.Name = "GiftThread";
                Thread.CurrentThread.IsBackground = true;
                bool Paused = false;
                if (EnableLoop)
                {
                    SendPacket();
                    Thread.Sleep(SpeedTimer);
                    StartLoop();
                }

            }).Start();
        }










    }
}

