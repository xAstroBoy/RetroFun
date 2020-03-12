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
using Sulakore.Protocol;
using Sulakore.Communication;
using Sulakore.Components;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class PersonalPage : ObservablePage
    {
        HMessage Permissions;

        private bool HasUserPermissionsMessage;
        private bool _HasModToolsUnlocked;


        public bool HasModToolsUnlocked
        {
            get => _HasModToolsUnlocked;
            set
            {
                _HasModToolsUnlocked = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _HasStaffPermissions;

        public bool HasStaffPermissions
        {
            get => _HasStaffPermissions;
            set
            {
                _HasStaffPermissions = value;
                RaiseOnPropertyChanged();
            }
        }

        private bool _CreditsChecked;

        private bool _CrystalsChecked;
        public bool CrystalsChecked
        {
            get => _CrystalsChecked;
            set
            {
                _CrystalsChecked = value;
                RaiseOnPropertyChanged();
            }
        }

        public bool CreditsChecked
        {
            get => _CreditsChecked;
            set
            {
                _CreditsChecked = value;
                RaiseOnPropertyChanged();
            }
        }


        private bool _DucketsChecked;

        public bool DucketsChecked
        {
            get => _DucketsChecked;
            set
            {
                _DucketsChecked = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _CreditsValue;

        private int _CrystalsValue;
        public int CrystalsValue
        {
            get => _CrystalsValue;
            set
            {
                _CrystalsValue = value;
                RaiseOnPropertyChanged();
            }
        }

        public int CreditsValue
        {
            get => _CreditsValue;
            set
            {
                _CreditsValue = value;
                RaiseOnPropertyChanged();
            }
        }


        private int _DucketsValue;

        public int DucketsValue
        {
            get => _DucketsValue;
            set
            {
                _DucketsValue = value;
                RaiseOnPropertyChanged();
            }
        }


        public PersonalPage()
        {
            InitializeComponent();
            Bind(CreditsChbx, "Checked", nameof(CreditsChecked));
            Bind(CrystalsChbx, "Checked", nameof(CrystalsChecked));
            Bind(DucketsChbx, "Checked", nameof(DucketsChecked));

            Bind(CreditsNbx, "Value", nameof(CreditsValue));
            Bind(CrystalsNbx, "Value", nameof(CrystalsValue));
            Bind(DucketsNbx, "Value", nameof(DucketsValue));

            if (Program.Master != null)
            {
                Triggers.OutAttach(In.UserPermissions, CloneDefaultUserPermissions);
            }


        }

        private void CloneDefaultUserPermissions(DataInterceptedEventArgs e)
        {
            if (!HasUserPermissionsMessage)
            {
                Permissions = e.Packet;
                HasUserPermissionsMessage = true;
            }
        }

        private void EnableModToolsBtn_Click(object sender, EventArgs e)
        {
            ManageModTools();
        }

        private void AcquireMODPermissionsBtn_Click(object sender, EventArgs e)
        {
            ManageModPermissions();
        }

        private void ManageModPermissions()
        {
            if(HasStaffPermissions)
            {
                if (HasUserPermissionsMessage)
                {
                    Speak("Your Normal permissions have been restored.");
                    Connection.SendToClientAsync(Permissions);
                }
                else
                {
                    Speak("Default permissions have been restored.");
                    Connection.SendToClientAsync(In.UserPermissions, 2, 4, false);
                    WriteToButton(AcquireMODPermissionsBtn, "Acquire MOD Permissions (CS)");
                }
                HasStaffPermissions = false;
            }
            else
            {
                Speak("Permissions set to Staff.");
                Connection.SendToClientAsync(In.UserPermissions, int.MaxValue, int.MaxValue, false);
                WriteToButton(AcquireMODPermissionsBtn, "Remove MOD Permissions (CS)");
                HasStaffPermissions = true;

            }
        }

        private void Speak(string text)
        {
            if (Connection.Remote.IsConnected)
            {
                Connection.SendToClientAsync(In.RoomUserWhisper, 0, "[Personal]: " + text, 0, 34, 0, -1);
            }
        }


        private void WriteToButton(SKoreButton button, string text)
        {
            Invoke((MethodInvoker)delegate
            {
                button.Text = text;
            });
        }


        private void ManageModTools()
        {
            if(HasModToolsUnlocked)
            {
                SendPacketModTools(false);
                HasModToolsUnlocked = false;
                WriteToButton(EnableModToolsBtn, "Show Mod Tools (CS)");
            }
            else
            {
                SendPacketModTools(true);
                HasModToolsUnlocked = true;
                WriteToButton(EnableModToolsBtn, "Hide Mod Tools (CS)");
            }
        }


        private void SendPacketModTools(bool value)
        {
            Connection.SendToClientAsync(In.ModTool, new object[]
                {
                0,
                0,
                0,
                value,
                value,
                value,
                value,
                value,
                value,
                value,
                0
});
        }

        private void SetCurrencyBtn_Click(object sender, EventArgs e)
        {
            SetCurrencyOnClient();
        }

        private void SetCurrencyOnClient()
        {

            if(CreditsChecked)
            {
                SetCredits(CreditsValue);
            }
            if(CrystalsChecked)
            {
                SetCrystals(CrystalsValue, DucketsValue);

            if (DucketsChecked)
            {
                    SetDuckets(DucketsValue);
            }
        }
    }

        private void SetCrystals(int crystals, int duckets)
        {
            Connection.SendToClientAsync(In.UserCurrency, new object[]
       {
                        11,
                        0,
                        duckets,
                        1,
                        0,
                        2,
                        0,
                        3,
                        0,
                        4,
                        0,
                        5,
                        crystals,
                        101,
                        0,
                        102,
                        0,
                        103,
                        0,
                        104,
                        0,
                        105,
                        0
       });
        }

        private void SetDuckets(int Duckets)
        {
            Connection.SendToClientAsync(In.UserPoints, Duckets + ".0");
        }

        private void SetCredits(int Credits)
        {
            Connection.SendToClientAsync(In.UserCredits, CreditsValue + ".0");
        }
    }
}
